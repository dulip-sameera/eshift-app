using eshift.Dto;
using eshift.Model;
using eshift.Dao;
using eshift.Dao.Impl;
using eshift.Utils.Mapper;
using System.Collections.Generic;

namespace eshift.Service.Impl
{
    internal class TransportUnitServiceImpl : ITransportUnitService
    {
        private readonly ITransportUnitDao transportUnitDao = new TransportUnitDaoImpl();

        public List<TransportUnitGridDto> GetAllTransportUnitsForGrid()
        {
            var tuModels = transportUnitDao.GetAllTransportUnits();
            if (tuModels == null || tuModels.Count == 0)
                throw new KeyNotFoundException("No transport units found.");

            return TransportUnitMapper.ToGridDtoList(
                tuModels,
                model => transportUnitDao.GetGridInfoForTransportUnit(model)
            );
        }

        public TransportUnitGridDto? GetTransportUnitForGridByTuId(string tuId) // Added
        {
            var model = transportUnitDao.GetTransportUnitByTuId(tuId);
            if (model == null) return null;
            var info = transportUnitDao.GetGridInfoForTransportUnit(model);
            return TransportUnitMapper.ToGridDto(model, info.vehicleRegNo, info.driverStaffId, info.driverFirstName, info.assistantStaffId, info.assistantFirstName);
        }

        public void DeleteTransportUnitByTuId(string tuId)
        {
            if (string.IsNullOrWhiteSpace(tuId))
                throw new ArgumentException("Transport Unit ID cannot be empty.");

            var existing = transportUnitDao.GetTransportUnitByTuId(tuId);
            if (existing == null)
                throw new KeyNotFoundException("Transport Unit not found for deletion.");

            bool deleted = transportUnitDao.DeleteTransportUnitByTuId(tuId);
            if (!deleted)
                throw new Exception("Failed to delete transport unit.");
        }

        public void CreateTransportUnit(TransportUnitDto dto)
        {
            if (dto == null) throw new ArgumentException("Transport unit data is required.");
            bool created = transportUnitDao.CreateTransportUnit(TransportUnitMapper.ToModel(dto));
            if (!created) throw new Exception("Failed to create transport unit.");
        }
        public int GetVehicleDbIdByRegNo(string regNo)
        {
            var vehicleModel = transportUnitDao.GetVehicleByRegNo(regNo);
            if (vehicleModel == null) throw new KeyNotFoundException("Vehicle not found.");
            return vehicleModel.Id;
        }

        public bool IsDriverInTransportUnit(int driverDbId)
        {
            return transportUnitDao.IsDriverInTransportUnit(driverDbId);
        }

        public bool IsAssistantInTransportUnit(int assistantDbId)
        {
            return transportUnitDao.IsAssistantInTransportUnit(assistantDbId);
        }

        public bool IsVehicleInTransportUnit(int vehicleDbId)
        {
            return transportUnitDao.IsVehicleInTransportUnit(vehicleDbId);
        }

        public void UpdateTransportUnit(TransportUnitDto dto)
        {
            if (dto == null) throw new ArgumentException("Transport unit data is required.");
            var existing = transportUnitDao.GetTransportUnitByTuId(dto.TuId);
            if (existing == null) throw new KeyNotFoundException("Transport unit not found for update.");
            // Only update vehicle, driver, assistant, available
            existing.VehicleId = dto.VehicleId;
            existing.DriverId = dto.DriverId;
            existing.AssistantId = dto.AssistantId;
            existing.Available = dto.Available;
            bool updated = transportUnitDao.UpdateTransportUnit(existing);
            if (!updated) throw new Exception("Failed to update transport unit.");
        }
    }
}