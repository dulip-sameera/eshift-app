using eshift.Database;
using eshift.Model;
using eshift.Enums;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace eshift.Dao.Impl
{
    internal class TransportUnitDaoImpl : ITransportUnitDao
    {
        public List<TransportUnitModel> GetAllTransportUnits()
        {
            var list = new List<TransportUnitModel>();
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, tu_id, vehicle, driver, assistant, available FROM transport_unit";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var available = Enum.TryParse<TransportUnitAvailableEnum>(reader.GetString("available"), out var availEnum) ? availEnum : TransportUnitAvailableEnum.NO;
                list.Add(new TransportUnitModel(
                    reader.GetInt32("id"),
                    reader.GetString("tu_id"),
                    reader.GetInt32("vehicle"),
                    reader.GetInt32("driver"),
                    reader.GetInt32("assistant"),
                    available
                ));
            }
            return list;
        }

        public TransportUnitModel? GetTransportUnitByTuId(string tuId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, tu_id, vehicle, driver, assistant, available FROM transport_unit WHERE tu_id = @tuId LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuId", tuId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var available = Enum.TryParse<TransportUnitAvailableEnum>(reader.GetString("available"), out var availEnum) ? availEnum : TransportUnitAvailableEnum.NO;
                return new TransportUnitModel(
                    reader.GetInt32("id"),
                    reader.GetString("tu_id"),
                    reader.GetInt32("vehicle"),
                    reader.GetInt32("driver"),
                    reader.GetInt32("assistant"),
                    available
                );
            }
            return null;
        }

        public bool DeleteTransportUnitByTuId(string tuId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "DELETE FROM transport_unit WHERE tu_id = @tuId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuId", tuId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool CreateTransportUnit(TransportUnitModel model)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"INSERT INTO transport_unit (tu_id, vehicle, driver, assistant, available)
                             VALUES (@tuId, @vehicle, @driver, @assistant, @available)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuId", model.TuId);
            cmd.Parameters.AddWithValue("@vehicle", model.VehicleId);
            cmd.Parameters.AddWithValue("@driver", model.DriverId);
            cmd.Parameters.AddWithValue("@assistant", model.AssistantId);
            cmd.Parameters.AddWithValue("@available", model.Available.ToString());
            return cmd.ExecuteNonQuery() > 0;
        }

        public string? GetLastTransportUnitId()
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT tu_id FROM transport_unit ORDER BY id DESC LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            var result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : null;
        }

        public VehicleModel? GetVehicleByRegNo(string regNo)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT id, brand, model, registration_number, container_volume, max_weight FROM vehicle WHERE registration_number = @regNo LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@regNo", regNo);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new VehicleModel
                {
                    Id = reader.GetInt32("id"),
                    Brand = reader.GetString("brand"),
                    Model = reader.GetString("model"),
                    RegistrationNumber = reader.GetString("registration_number"),
                    ContainerVolume = reader.GetDouble("container_volume"),
                    MaxWeight = reader.GetDouble("max_weight")
                };
            }
            return null;
        }

        // Helper for grid info: fetch vehicle reg no, driver/assistant staff id and first name
        public (string vehicleRegNo, string driverStaffId, string driverFirstName, string assistantStaffId, string assistantFirstName) GetGridInfoForTransportUnit(TransportUnitModel model)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"
                SELECT v.registration_number, sd.staff_id AS driver_staff_id, sd.first_name AS driver_first_name,
                       sa.staff_id AS assistant_staff_id, sa.first_name AS assistant_first_name
                FROM vehicle v
                JOIN staff sd ON sd.id = @driverId
                JOIN staff sa ON sa.id = @assistantId
                WHERE v.id = @vehicleId
                LIMIT 1";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@vehicleId", model.VehicleId);
            cmd.Parameters.AddWithValue("@driverId", model.DriverId);
            cmd.Parameters.AddWithValue("@assistantId", model.AssistantId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (
                    reader.GetString("registration_number"),
                    reader.GetString("driver_staff_id"),
                    reader.GetString("driver_first_name"),
                    reader.GetString("assistant_staff_id"),
                    reader.GetString("assistant_first_name")
                );
            }
            return ("", "", "", "", "");
        }

        public bool IsDriverInTransportUnit(int driverDbId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT COUNT(*) FROM transport_unit WHERE driver = @driverDbId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@driverDbId", driverDbId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public bool IsAssistantInTransportUnit(int assistantDbId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT COUNT(*) FROM transport_unit WHERE assistant = @assistantDbId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@assistantDbId", assistantDbId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public bool IsVehicleInTransportUnit(int vehicleDbId)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = "SELECT COUNT(*) FROM transport_unit WHERE vehicle = @vehicleDbId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@vehicleDbId", vehicleDbId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        public bool UpdateTransportUnit(TransportUnitModel model)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            string query = @"UPDATE transport_unit SET vehicle = @vehicle, driver = @driver, assistant = @assistant, available = @available WHERE tu_id = @tuId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@vehicle", model.VehicleId);
            cmd.Parameters.AddWithValue("@driver", model.DriverId);
            cmd.Parameters.AddWithValue("@assistant", model.AssistantId);
            cmd.Parameters.AddWithValue("@available", model.Available.ToString());
            cmd.Parameters.AddWithValue("@tuId", model.TuId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public int GetTotalTransportUnitCount()
        {
            try
            {
                using var conn = DatabaseConnection.Instance.Connection;
                string query = "SELECT COUNT(*) FROM transport_unit";
                using var cmd = new MySqlCommand(query, conn);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTotalTransportUnitCount: {ex.Message}");
                throw new Exception("Failed to get total transport unit count", ex);
            }
        }

        public int GetTransportUnitCountrByAvailability(string availability)
        {
            try
            {
                using var conn = DatabaseConnection.Instance.Connection;
                string query = "SELECT COUNT(*) FROM transport_unit WHERE available = @availability";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@availability", availability);
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTransportUnitCountrByAvailability: {ex.Message}");
                throw new Exception($"Failed to get transport unit count for availability {availability}", ex);
            }
        }
    }
}