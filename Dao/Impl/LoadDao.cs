using eshift.Database;
using eshift.Dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dao.Impl
{
    internal class LoadDao : ILoadDao
    {
        public List<LoadDto> GetLoadsByJobId(int jobId)
        {
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                var loads = new List<LoadDto>();
                string query = "SELECT load_id, description, volume, weight FROM `load` WHERE job = @jobId";
                
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jobId", jobId);
                using var reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    var load = new LoadDto
                    {
                        LoadId = reader.GetString("load_id"),
                        Description = reader.GetString("description"),
                        Volume = reader.GetDouble("volume"),
                        Weight = reader.GetDouble("weight")
                    };
                    loads.Add(load);
                }
                
                return loads;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetLoadsByJobId: {ex.Message}");
                throw new Exception($"Failed to get loads for job ID {jobId}", ex);
            }
        }
    }
}
