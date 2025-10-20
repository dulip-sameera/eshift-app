using eshift.Model;
using eshift.Database;
using MySql.Data.MySqlClient;

namespace eshift.Dao.Impl
{
    internal class VehicleDaoImpl : IVehicleDao
    {
        public List<VehicleModel> GetVehicles()
        {
            var vehicles = new List<VehicleModel>();
            using var conn = DatabaseConnection.Instance.Connection;
            using var cmd = new MySqlCommand("SELECT id, brand, model, registration_number, container_volume, max_weight FROM vehicle", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                vehicles.Add(new VehicleModel(
                    reader.GetInt32("id"),
                    reader.GetString("brand"),
                    reader.GetString("model"),
                    reader.GetString("registration_number"),
                    reader.GetDouble("container_volume"),
                    reader.GetDouble("max_weight")
                ));
            }
            return vehicles;
        }

        public VehicleModel? GetVehicleByRegNo(string regNo)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            using var cmd = new MySqlCommand("SELECT id, brand, model, registration_number, container_volume, max_weight FROM vehicle WHERE registration_number = @regNo", conn);
            cmd.Parameters.AddWithValue("@regNo", regNo);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new VehicleModel(
                    reader.GetInt32("id"),
                    reader.GetString("brand"),
                    reader.GetString("model"),
                    reader.GetString("registration_number"),
                    reader.GetDouble("container_volume"),
                    reader.GetDouble("max_weight")
                );
            }
            return null;
        }

        public VehicleModel? GetVehicleById(int id)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            using var cmd = new MySqlCommand("SELECT id, brand, model, registration_number, container_volume, max_weight FROM vehicle WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new VehicleModel(
                    reader.GetInt32("id"),
                    reader.GetString("brand"),
                    reader.GetString("model"),
                    reader.GetString("registration_number"),
                    reader.GetDouble("container_volume"),
                    reader.GetDouble("max_weight")
                );
            }
            return null;
        }

        public bool DeleteVehicleByRegNo(string regNo)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            using var cmd = new MySqlCommand("DELETE FROM vehicle WHERE registration_number = @regNo", conn);
            cmd.Parameters.AddWithValue("@regNo", regNo);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateVehicle(string prevRegNo, VehicleModel vehicle)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            using var cmd = new MySqlCommand(@"UPDATE vehicle SET brand = @brand, model = @model, registration_number = @regNo, container_volume = @containerVolume, max_weight = @maxWeight WHERE registration_number = @prevRegNo", conn);
            cmd.Parameters.AddWithValue("@brand", vehicle.Brand);
            cmd.Parameters.AddWithValue("@model", vehicle.Model);
            cmd.Parameters.AddWithValue("@containerVolume", vehicle.ContainerVolume);
            cmd.Parameters.AddWithValue("@maxWeight", vehicle.MaxWeight);
            cmd.Parameters.AddWithValue("@regNo", vehicle.RegistrationNumber);
            cmd.Parameters.AddWithValue("@prevRegNo", prevRegNo);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool CreateVehicle(VehicleModel vehicle)
        {
            using var conn = DatabaseConnection.Instance.Connection;
            using var cmd = new MySqlCommand(@"INSERT INTO vehicle (brand, model, registration_number, container_volume, max_weight) VALUES (@brand, @model, @regNo, @containerVolume, @maxWeight)", conn);
            cmd.Parameters.AddWithValue("@brand", vehicle.Brand);
            cmd.Parameters.AddWithValue("@model", vehicle.Model);
            cmd.Parameters.AddWithValue("@regNo", vehicle.RegistrationNumber);
            cmd.Parameters.AddWithValue("@containerVolume", vehicle.ContainerVolume);
            cmd.Parameters.AddWithValue("@maxWeight", vehicle.MaxWeight);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}