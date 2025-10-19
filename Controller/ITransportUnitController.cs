using eshift.Dto;
using System.Collections.Generic;

namespace eshift.Controller
{
    internal interface ITransportUnitController
    {
        List<TransportUnitGridDto>? GetAllTransportUnitsForGrid();
        TransportUnitGridDto? GetTransportUnitForGridByTuId(string tuId);
        void DeleteTransportUnitByTuId(string tuId);
        void CreateTransportUnit(TransportUnitDto dto);
        void UpdateTransportUnit(TransportUnitDto dto); // Add this to the interface
        int GetVehicleDbIdByRegNo(string regNo);

        // New methods for existence checks
        bool IsDriverInTransportUnit(int driverDbId);
        bool IsAssistantInTransportUnit(int assistantDbId);
        bool IsVehicleInTransportUnit(int vehicleDbId);
    }
}