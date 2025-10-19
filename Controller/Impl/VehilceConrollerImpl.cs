using eshift.Dto;
using eshift.Service;
using eshift.Service.Impl;

namespace eshift.Controller.Impl
{
    internal class VehilceConrollerImpl : IVehicleController
    {
        private readonly IVehicleService vehicleService;
        public VehilceConrollerImpl()
        {
            this.vehicleService = new VehicleServiceImpl();
        }

        public List<VehicleDto>? getAllVehicles()
        {
            return this.vehicleService.GetVehicles();
        }

        public VehicleDto? getVehicleByRegNo(string regNo)
        {
            return this.vehicleService.GetVehicleByRegNo(regNo);
        }

        public VehicleDto? GetVehicleById(int id)
        {
            return this.vehicleService.GetVehicleById(id);
        }

        public void deleteVehicleByRegNo(string regNo)
        {
            this.vehicleService.DeleteVehicleByRegNo(regNo);
        }

        public void updateVehicle(string prevRegNo, VehicleDto vehicle)
        {
            this.vehicleService.UpdateVehicle(prevRegNo, vehicle);
        }

        public void createVehicle(VehicleDto vehicle)
        {
            this.vehicleService.CreateVehicle(vehicle);
        }
    }
}
