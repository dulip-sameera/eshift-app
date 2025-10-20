using eshift.Model;
using eshift.Database;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace eshift.Dao.Impl
{
    internal class RoleDaoImpl : IRoleDao
    {
        public List<RoleModel> GetAllRoles()
        {
            var list = new List<RoleModel>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, name FROM role";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var role = new RoleModel(
                    reader.GetInt32("id"),
                    reader.IsDBNull(reader.GetOrdinal("name")) ? string.Empty : reader.GetString("name")
                );
                list.Add(role);
            }
            return list;
        }

        public RoleModel? GetRoleById(int id)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, name FROM role WHERE id = @id LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new RoleModel(
                    reader.GetInt32("id"),
                    reader.IsDBNull(reader.GetOrdinal("name")) ? string.Empty : reader.GetString("name")
                );
            }
            return null;
        }
    }
}
