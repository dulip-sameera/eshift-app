using eshift.Dto;
using eshift.Service;
using eshift.Service.Impl;
using System.Collections.Generic;

namespace eshift.Controller.Impl
{
    internal class TransportUnitControllerImpl : ITransportUnitController
    {
        private readonly ITransportUnitService transportUnitService;

        public TransportUnitControllerImpl()
        {
            transportUnitService = new TransportUnitServiceImpl();
        }

        public List<TransportUnitGridDto>? GetAllTransportUnitsForGrid()
        {
            return transportUnitService.GetAllTransportUnitsForGrid();
        }

        public TransportUnitGridDto? GetTransportUnitForGridByTuId(string tuId) // Added
        {
            return transportUnitService.GetTransportUnitForGridByTuId(tuId);
        }

        public void DeleteTransportUnitByTuId(string tuId)
        {
            transportUnitService.DeleteTransportUnitByTuId(tuId);
        }

        public void CreateTransportUnit(TransportUnitDto dto)
        {
            transportUnitService.CreateTransportUnit(dto);
        }
        public int GetVehicleDbIdByRegNo(string regNo)
        {
            return transportUnitService.GetVehicleDbIdByRegNo(regNo);
        }

        public bool IsDriverInTransportUnit(int driverDbId)
        {
            return transportUnitService.IsDriverInTransportUnit(driverDbId);
        }

        public bool IsAssistantInTransportUnit(int assistantDbId)
        {
            return transportUnitService.IsAssistantInTransportUnit(assistantDbId);
        }

        public bool IsVehicleInTransportUnit(int vehicleDbId)
        {
            return transportUnitService.IsVehicleInTransportUnit(vehicleDbId);
        }

        public void UpdateTransportUnit(TransportUnitDto dto)
        {
            transportUnitService.UpdateTransportUnit(dto);
        }
    }
}