using eshift.Database;
using eshift.Enums;
using eshift.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace eshift.Dao.Impl
{
    internal class StaffDaoImpl : IStaffDao
    {
        public List<(StaffModel, string)> GetAllStaffWithUsernames()
        {
            var staffList = new List<(StaffModel, string)>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT s.id, s.staff_id, s.first_name, s.last_name, s.phone, s.email, s.licese_number, 
                                    st.id AS type_id, st.name AS type_name, s.user_account, s.status, u.username
                             FROM staff s
                             LEFT JOIN staff_type st ON s.type = st.id
                             LEFT JOIN user u ON s.user_account = u.id";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var typeId = reader.IsDBNull(reader.GetOrdinal("type_id")) ? 0 : reader.GetInt32("type_id");
                var typeName = reader.IsDBNull(reader.GetOrdinal("type_name")) ? "" : reader.GetString("type_name");
                var userAccount = reader.IsDBNull(reader.GetOrdinal("user_account")) ? (int?)null : reader.GetInt32("user_account");
                var status = Enum.TryParse<StaffStatusEnum>(reader.GetString("status"), out var parsedStatus) ? parsedStatus : StaffStatusEnum.ACTIVE;
                var staff = new StaffModel(
                    reader.GetInt32("id"),
                    reader.GetString("staff_id"),
                    reader.GetString("first_name"),
                    reader.GetString("last_name"),
                    reader.GetString("phone"),
                    reader.GetString("email"),
                    reader.IsDBNull(reader.GetOrdinal("licese_number")) ? "" : reader.GetString("licese_number"),
                    new StaffTypeModel(typeId, typeName),
                    userAccount,
                    status
                );
                var username = reader.IsDBNull(reader.GetOrdinal("username")) ? "" : reader.GetString("username");
                staffList.Add((staff, username));
            }
            return staffList;
        }

        public (StaffModel, string)? GetStaffWithUsernameByStaffId(string staffId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT s.id, s.staff_id, s.first_name, s.last_name, s.phone, s.email, s.licese_number, 
                                    st.id AS type_id, st.name AS type_name, s.user_account, s.status, u.username
                             FROM staff s
                             LEFT JOIN staff_type st ON s.type = st.id
                             LEFT JOIN user u ON s.user_account = u.id
                             WHERE s.staff_id = @staffId
                             LIMIT 1";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@staffId", staffId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var type = new StaffTypeModel(reader.GetInt32("type_id"), reader.GetString("type_name"));
                var status = Enum.TryParse<StaffStatusEnum>(reader.GetString("status"), out var parsedStatus) ? parsedStatus : StaffStatusEnum.ACTIVE;
                var staff = new StaffModel(
                    reader.GetInt32("id"),
                    reader.GetString("staff_id"),
                    reader.GetString("first_name"),
                    reader.GetString("last_name"),
                    reader.GetString("phone"),
                    reader.GetString("email"),
                    reader.IsDBNull(reader.GetOrdinal("licese_number")) ? null : reader.GetString("licese_number"),
                    type,
                    reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account"),
                    status
                );
                var username = reader.IsDBNull(reader.GetOrdinal("username")) ? "" : reader.GetString("username");
                return (staff, username);
            }
            return null;
        }

        public bool UpdateStaffStatusByStaffId(string staffId, StaffStatusEnum status)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"UPDATE staff SET status = @status WHERE staff_id = @staffId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status.ToString());
            cmd.Parameters.AddWithValue("@staffId", staffId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool CreateStaff(StaffModel staff)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"INSERT INTO staff (staff_id, first_name, last_name, phone, email, licese_number, type, user_account, status)
                             VALUES (@staffId, @firstName, @lastName, @phone, @email, @licenseNumber, @type, @userAccount, @status)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@staffId", staff.StaffId);
            cmd.Parameters.AddWithValue("@firstName", staff.FirstName);
            cmd.Parameters.AddWithValue("@lastName", staff.LastName);
            cmd.Parameters.AddWithValue("@phone", staff.Phone);
            cmd.Parameters.AddWithValue("@email", staff.Email);
            cmd.Parameters.AddWithValue("@licenseNumber", staff.LicenseNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@type", staff.Type.Id);
            cmd.Parameters.AddWithValue("@userAccount", staff.UserAccount ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@status", staff.Status.ToString());
            return cmd.ExecuteNonQuery() > 0;
        }

        public string? GetLastStaffId()
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT staff_id FROM staff ORDER BY id DESC LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            var result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }

        public bool UpdateStaff(string staffId, StaffModel staff)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"UPDATE staff SET 
                                first_name = @firstName,
                                last_name = @lastName,
                                phone = @phone,
                                email = @email,
                                licese_number = @licenseNumber,
                                type = @type,
                                status = @status,
                                user_account = @userAccount
                             WHERE staff_id = @staffId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@firstName", staff.FirstName);
            cmd.Parameters.AddWithValue("@lastName", staff.LastName);
            cmd.Parameters.AddWithValue("@phone", staff.Phone);
            cmd.Parameters.AddWithValue("@email", staff.Email);
            cmd.Parameters.AddWithValue("@licenseNumber", staff.LicenseNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@type", staff.Type.Id);
            cmd.Parameters.AddWithValue("@status", staff.Status.ToString());
            cmd.Parameters.AddWithValue("@staffId", staffId);
            cmd.Parameters.AddWithValue("@userAccount", staff.UserAccount.HasValue ? staff.UserAccount : DBNull.Value);
            return cmd.ExecuteNonQuery() > 0;
        }

        public StaffModel? GetStaffByStaffId(string staffId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT id, staff_id, first_name, last_name, phone, email, licese_number, type, user_account, status FROM staff WHERE staff_id = @staffId LIMIT 1";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@staffId", staffId);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var type = new StaffTypeModel(reader.GetInt32("type"), "");
                    var status = Enum.TryParse<StaffStatusEnum>(reader.GetString("status"), out var parsedStatus) ? parsedStatus : StaffStatusEnum.ACTIVE;
                    return new StaffModel(
                        reader.GetInt32("id"),
                        reader.GetString("staff_id"),
                        reader.GetString("first_name"),
                        reader.GetString("last_name"),
                        reader.GetString("phone"),
                        reader.GetString("email"),
                        reader.IsDBNull(reader.GetOrdinal("licese_number")) ? null : reader.GetString("licese_number"),
                        type,
                        reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account"),
                        status
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetStaffByStaffId: {ex.Message}");
                throw;
            }
        }

        public StaffModel? GetStaffByUseraccount(int userAccount)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"SELECT id, staff_id, first_name, last_name, phone, email, licese_number, type, user_account, status FROM staff WHERE user_account = @userAccount LIMIT 1";
            try
            {
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userAccount", userAccount);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var type = new StaffTypeModel(reader.GetInt32("type"), ""); // name not fetched here
                    var status = Enum.TryParse<StaffStatusEnum>(reader.GetString("status"), out var parsedStatus) ? parsedStatus : StaffStatusEnum.ACTIVE;
                    return new StaffModel(
                        reader.GetInt32("id"),
                        reader.GetString("staff_id"),
                        reader.GetString("first_name"),
                        reader.GetString("last_name"),
                        reader.GetString("phone"),
                        reader.GetString("email"),
                        reader.IsDBNull(reader.GetOrdinal("licese_number")) ? null : reader.GetString("licese_number"),
                        type,
                        reader.IsDBNull(reader.GetOrdinal("user_account")) ? null : reader.GetInt32("user_account"),
                        status
                    );
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetStaffByUseraccount: {ex.Message}");
                throw;
            }
        }
    }
}