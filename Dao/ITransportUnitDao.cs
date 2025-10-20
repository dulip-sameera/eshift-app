using eshift.Model;
using System.Collections.Generic;

namespace eshift.Dao
{
    internal interface ITransportUnitDao
    {
        List<TransportUnitModel> GetAllTransportUnits();
        TransportUnitModel? GetTransportUnitByTuId(string tuId);
        bool DeleteTransportUnitByTuId(string tuId);
        bool CreateTransportUnit(TransportUnitModel model);
        string? GetLastTransportUnitId();
        VehicleModel? GetVehicleByRegNo(string regNo);
        (string vehicleRegNo, string driverStaffId, string driverFirstName, string assistantStaffId, string assistantFirstName) GetGridInfoForTransportUnit(TransportUnitModel model);

        bool IsDriverInTransportUnit(int driverDbId);
        bool IsAssistantInTransportUnit(int assistantDbId);
        bool IsVehicleInTransportUnit(int vehicleDbId);
        bool UpdateTransportUnit(TransportUnitModel model); 
        int GetTotalTransportUnitCount();
        int GetTransportUnitCountrByAvailability(string availability);
    }
}