using eshift.Dto;

namespace eshift.Controller
{
    internal interface IVehicleController
    {
        List<VehicleDto>? getAllVehicles();
        VehicleDto? getVehicleByRegNo(string regNo);
        VehicleDto? GetVehicleById(int id);
        void deleteVehicleByRegNo(string regNo);
        void updateVehicle(string prevRegNo, VehicleDto vehicle);
        void createVehicle(VehicleDto vehicle);
    }
}
