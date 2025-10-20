using eshift.Model;
using eshift.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace eshift.Dao.Impl
{
    internal class UserDaoImpl : IUserDao
    {
        private readonly IRoleDao _roleDao;

        public UserDaoImpl(IRoleDao roleDao)
        {
            _roleDao = roleDao;
        }

        public List<UserModel> GetAllUsers()
        {
            var users = new List<UserModel>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, username, password, role FROM user";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var roleId = reader.GetInt32("role");
                    var role = new RoleModel(roleId);
                    var user = new UserModel(
                        reader.GetInt32("id"),
                        reader.GetString("username"),
                        reader.GetString("password"),
                        role
                    );
                    users.Add(user);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllUsers: {ex.Message}");
                throw;
            }
            return users;
        }

        public UserModel? GetUserById(int id)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, username, password, role FROM user WHERE id = @id LIMIT 1";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var roleId = reader.GetInt32("role");
                    var role = new RoleModel(roleId);
                    return new UserModel(
                        reader.GetInt32("id"),
                        reader.GetString("username"),
                        reader.GetString("password"),
                        role
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetUserById: {ex.Message}");
                throw;
            }
            return null;
        }

        public UserModel? GetUserByUsername(string username)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, username, password, role FROM user WHERE username = @username LIMIT 1";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var roleId = reader.GetInt32("role");
                    var role = new RoleModel(roleId);
                    return new UserModel(
                        reader.GetInt32("id"),
                        reader.GetString("username"),
                        reader.GetString("password"),
                        role
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetUserByUsername: {ex.Message}");
                throw;
            }
            return null;
        }

        public List<UserModel> FilterUsersByUsername(string searchString)
        {
            var users = new List<UserModel>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, username, password, role FROM user WHERE username LIKE @searchString";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchString", $"%{searchString}%");
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var roleId = reader.GetInt32("role");
                    var role = new RoleModel(roleId);
                    var user = new UserModel(
                        reader.GetInt32("id"),
                        reader.GetString("username"),
                        reader.GetString("password"),
                        role
                    );
                    users.Add(user);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in FilterUsersByUsername: {ex.Message}");
                throw;
            }
            return users;
        }

        public UserModel CreateUser(UserModel userModel)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "INSERT INTO user (username, password, role) VALUES (@username, @password, @role)";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", userModel.Username);
                cmd.Parameters.AddWithValue("@password", userModel.Password);
                cmd.Parameters.AddWithValue("@role", userModel.Role.Id);
                cmd.ExecuteNonQuery();
                // Get the newly created user
                return GetUserByUsername(userModel.Username)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateUser: {ex.Message}");
                throw;
            }
        }

        public UserModel UpdateUser(UserModel userModel)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "UPDATE user SET password = @password, username = @username WHERE id = @id";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", userModel.Password);
                cmd.Parameters.AddWithValue("@username", userModel.Username);
                cmd.Parameters.AddWithValue("@id", userModel.Id);
                cmd.ExecuteNonQuery();
                // returns the updated user
                return GetUserByUsername(userModel.Username)!;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateUser: {ex.Message}");
                throw;
            }
        }

        public void DeleteUserByUsername(string username)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "DELETE FROM user WHERE username = @username";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteUserByUsername: {ex.Message}");
                throw;
            }
        }
    }
}
