using eshift.Dto;
using eshift.Model;
using eshift.Dao;
using eshift.Dao.Impl;
using eshift.Utils.Mapper;
using eshift.Utils.Validation;
using System.Collections.Generic;

namespace eshift.Service.Impl
{
    internal class VehicleServiceImpl : IVehicleService
    {
        private readonly IVehicleDao vehicleDao = new VehicleDaoImpl();

        public List<VehicleDto> GetVehicles()
        {
            try
            {
                var models = vehicleDao.GetVehicles();
                return VehicleMapper.ToDtoList(models);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching vehicles: {ex.Message}");
                return new List<VehicleDto>();
            }
        }

        public VehicleDto? GetVehicleByRegNo(string regNo)
        {
            try
            {
                var model = vehicleDao.GetVehicleByRegNo(regNo);
                return VehicleMapper.ToDto(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching vehicle: {ex.Message}");
                return null;
            }
        }

        public VehicleDto? GetVehicleById(int id)
        {
            try
            {
                var model = vehicleDao.GetVehicleById(id);
                return VehicleMapper.ToDto(model);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching vehicle by id: {ex.Message}");
                return null;
            }
        }

        public void DeleteVehicleByRegNo(string regNo)
        {
            try
            {
                var existing = vehicleDao.GetVehicleByRegNo(regNo);
                if (existing == null)
                {
                    throw new KeyNotFoundException("Vehicle not found for deletion.");
                }
                bool deleted = vehicleDao.DeleteVehicleByRegNo(regNo);
                if (!deleted)
                {
                    throw new Exception("Failed to delete vehicle.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting vehicle: {ex.Message}");
                throw;
            }
        }

        public void UpdateVehicle(string prevRegNo, VehicleDto vehicle)
        {
            var errors = VehicleValidator.Validate(
                vehicle.Brand,
                vehicle.Model,
                vehicle.RegistrationNumber,
                vehicle.ContainerVolume,
                vehicle.MaxWeight
            );
            if (errors.Count > 0)
            {
                throw new ArgumentException("Validation errors: " + string.Join(", ", errors.Values));
            }

            var existing = vehicleDao.GetVehicleByRegNo(prevRegNo);
            if (existing == null)
            {
                throw new KeyNotFoundException("Vehicle not found for update.");
            }

            // If registration number is changed, check for duplicate
            if (!string.Equals(prevRegNo, vehicle.RegistrationNumber, StringComparison.OrdinalIgnoreCase))
            {
                var duplicate = vehicleDao.GetVehicleByRegNo(vehicle.RegistrationNumber);
                if (duplicate != null)
                {
                    throw new ArgumentException("Duplicate registration number.");
                }
            }

            var model = VehicleMapper.ToModel(vehicle);
            // Use the previous registration number for WHERE clause
            model.RegistrationNumber = prevRegNo;
            bool updated = vehicleDao.UpdateVehicle(prevRegNo ,model);
            if (!updated)
            {
                throw new Exception("Failed to update vehicle.");
            }
        }

        public void CreateVehicle(VehicleDto vehicle)
        {
            var errors = VehicleValidator.Validate(
                vehicle.Brand,
                vehicle.Model,
                vehicle.RegistrationNumber,
                vehicle.ContainerVolume,
                vehicle.MaxWeight
            );
            if (errors.Count > 0)
            {
                throw new ArgumentException("Validation errors: " + string.Join(", ", errors.Values));
            }

            var existing = vehicleDao.GetVehicleByRegNo(vehicle.RegistrationNumber);
            if (existing != null)
            {
                throw new ArgumentException("Vehicle with this registration number already exists.");
            }

            var model = VehicleMapper.ToModel(vehicle);
            bool created = vehicleDao.CreateVehicle(model);
            if (!created)
            {
                throw new Exception("Failed to create vehicle.");
            }
        }
    }
}
