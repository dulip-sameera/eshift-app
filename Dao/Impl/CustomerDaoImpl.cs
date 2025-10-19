using eshift.Model;
using eshift.Database;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace eshift.Dao.Impl
{
    internal class CustomerDaoImpl : ICustomerDao
    {
        public List<(CustomerModel, string)> GetAllCustomersWithUsernames()
        {
            var customers = new List<(CustomerModel, string)>();
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT c.id, c.cus_id, c.first_name, c.last_name, c.email, c.phone, c.address, c.city, c.zip_code, 
                                    c.user_account, cs.id AS status_id, cs.name AS status_name, u.username
                             FROM customer c
                             LEFT JOIN customer_status cs ON c.status = cs.id
                             LEFT JOIN user u ON c.user_account = u.id";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var status = new CustomerStatusModel(reader.GetInt32("status_id"), reader.GetString("status_name"));
                var customer = new CustomerModel(
                    reader.GetInt32("id"),
                    reader.GetString("cus_id"),
                    reader.GetString("first_name"),
                    reader.GetString("last_name"),
                    reader.GetString("email"),
                    reader.GetString("phone"),
                    reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address"),
                    reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city"),
                    reader.IsDBNull(reader.GetOrdinal("zip_code")) ? "" : reader.GetString("zip_code"),
                    status,
                    reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account")
                );
                var username = reader.IsDBNull(reader.GetOrdinal("username")) ? "" : reader.GetString("username");
                customers.Add((customer, username));
            }
            return customers;
        }

        public (CustomerModel, string)? GetCustomerWithUsernameByCusId(string cusId)
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT c.id, c.cus_id, c.first_name, c.last_name, c.email, c.phone, c.address, c.city, c.zip_code, 
                                    c.user_account, cs.id AS status_id, cs.name AS status_name, u.username
                             FROM customer c
                             LEFT JOIN customer_status cs ON c.status = cs.id
                             LEFT JOIN user u ON c.user_account = u.id
                             WHERE c.cus_id = @cusId
                             LIMIT 1";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cusId", cusId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var status = new CustomerStatusModel(reader.GetInt32("status_id"), reader.GetString("status_name"));
                var customer = new CustomerModel(
                    reader.GetInt32("id"),
                    reader.GetString("cus_id"),
                    reader.GetString("first_name"),
                    reader.GetString("last_name"),
                    reader.GetString("email"),
                    reader.GetString("phone"),
                    reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address"),
                    reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city"),
                    reader.IsDBNull(reader.GetOrdinal("zip_code")) ? "" : reader.GetString("zip_code"),
                    status,
                    reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account")
                );
                var username = reader.IsDBNull(reader.GetOrdinal("username")) ? "" : reader.GetString("username");
                return (customer, username);
            }
            return null;
        }

        public bool UpdateCustomerStatusByCusId(string cusId, int statusId)
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = "UPDATE customer SET status = @statusId WHERE cus_id = @cusId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@statusId", statusId);
            cmd.Parameters.AddWithValue("@cusId", cusId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool CreateCustomer(CustomerModel customer)
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"INSERT INTO customer (cus_id, first_name, last_name, email, phone, address, city, zip_code, status) 
                             VALUES (@cusId, @firstName, @lastName, @email, @phone, @address, @city, @zipCode, @status)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cusId", customer.CusId);
            cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
            cmd.Parameters.AddWithValue("@lastName", customer.LastName);
            cmd.Parameters.AddWithValue("@email", customer.Email);
            cmd.Parameters.AddWithValue("@phone", customer.Phone);
            cmd.Parameters.AddWithValue("@address", customer.Address);
            cmd.Parameters.AddWithValue("@city", customer.City);
            cmd.Parameters.AddWithValue("@zipCode", customer.ZipCode);
            cmd.Parameters.AddWithValue("@status", customer.Status.Id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public string? GetLastCustomerId()
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT cus_id FROM customer ORDER BY id DESC LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            var result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }

        public bool UpdateCustomer(string cusId, CustomerModel customer)
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"UPDATE customer SET 
                                first_name = @firstName,
                                last_name = @lastName,
                                email = @email,
                                phone = @phone,
                                address = @address,
                                city = @city,
                                zip_code = @zipCode,
                                status = @status,
                                user_account = @user_account
                             WHERE cus_id = @cusId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
            cmd.Parameters.AddWithValue("@lastName", customer.LastName);
            cmd.Parameters.AddWithValue("@email", customer.Email);
            cmd.Parameters.AddWithValue("@phone", customer.Phone);
            cmd.Parameters.AddWithValue("@address", customer.Address);
            cmd.Parameters.AddWithValue("@city", customer.City);
            cmd.Parameters.AddWithValue("@zipCode", customer.ZipCode);
            cmd.Parameters.AddWithValue("@status", customer.Status.Id);
            cmd.Parameters.AddWithValue("@cusId", cusId);
            cmd.Parameters.AddWithValue("@user_account", customer.UserAccount.HasValue ? customer.UserAccount : DBNull.Value);
            return cmd.ExecuteNonQuery() > 0;
        }

        public CustomerModel? GetCustomerByCusId(string cusId)
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT id, cus_id, first_name, last_name, email, phone, address, city, zip_code, status, user_account FROM customer WHERE cus_id = @cusId LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cusId", cusId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var status = new CustomerStatusModel(reader.GetInt32("status"), ""); // Status name not fetched here
                return new CustomerModel(
                    reader.GetInt32("id"),
                    reader.GetString("cus_id"),
                    reader.GetString("first_name"),
                    reader.GetString("last_name"),
                    reader.GetString("email"),
                    reader.GetString("phone"),
                    reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address"),
                    reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city"),
                    reader.IsDBNull(reader.GetOrdinal("zip_code")) ? "" : reader.GetString("zip_code"),
                    status,
                    reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account")
                );
            }
            return null;
        }

        public CustomerModel? GetCustomerByUseraccount(int userAccount)
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT id, cus_id, first_name, last_name, email, phone, address, city, zip_code, status, user_account FROM customer WHERE user_account = @userAccount LIMIT 1";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userAccount", userAccount);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var status = new CustomerStatusModel(reader.GetInt32("status"), ""); // Status name not fetched here
                    return new CustomerModel(
                        reader.GetInt32("id"),
                        reader.GetString("cus_id"),
                        reader.GetString("first_name"),
                        reader.GetString("last_name"),
                        reader.GetString("email"),
                        reader.GetString("phone"),
                        reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address"),
                        reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city"),
                        reader.IsDBNull(reader.GetOrdinal("zip_code")) ? "" : reader.GetString("zip_code"),
                        status,
                        reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account")
                    );
                }
                return null;
        }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCustomerByUseraccount: {ex.Message}");
                throw;
            }
        }

        public CustomerModel? GetCustomerById(int id)
        {
            var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT id, cus_id, first_name, last_name, email, phone, address, city, zip_code, status, user_account FROM customer WHERE id = @id LIMIT 1";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var status = new CustomerStatusModel(reader.GetInt32("status"), "");
                    return new CustomerModel(
                        reader.GetInt32("id"),
                        reader.GetString("cus_id"),
                        reader.GetString("first_name"),
                        reader.GetString("last_name"),
                        reader.GetString("email"),
                        reader.GetString("phone"),
                        reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address"),
                        reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city"),
                        reader.IsDBNull(reader.GetOrdinal("zip_code")) ? "" : reader.GetString("zip_code"),
                        status,
                        reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account")
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCustomerById: {ex.Message}");
                throw;
            }
        }
    }
}