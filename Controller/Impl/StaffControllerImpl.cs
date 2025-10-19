using eshift.Dto;
using eshift.Enums;
using eshift.Service;
using eshift.Service.Impl;

namespace eshift.Controller.Impl
{
    internal class StaffControllerImpl : IStaffController
    {
        private readonly IStaffService staffService;

        public StaffControllerImpl()
        {
            staffService = new StaffServiceImpl();
        }

        public List<StaffGridDto>? GetAllStaffForGrid()
        {
            return staffService.GetAllStaffForGrid();
        }

        public StaffGridDto? GetStaffForGridByStaffId(string staffId)
        {
            return staffService.GetStaffForGridByStaffId(staffId);
        }

        public StaffDto? GetStaffByStaffId(string staffId) // Added
        {
            return staffService.GetStaffByStaffId(staffId);
        }

        public void DeleteStaffByStaffId(string staffId, StaffStatusEnum status)
        {
            staffService.DeleteStaffByStaffId(staffId, status);
        }

        public string CreateStaff(StaffDto staff)
        {
            return staffService.CreateStaff(staff);
        }

        public void UpdateStaff(string staffId, StaffDto staff)
        {
            staffService.UpdateStaff(staffId, staff);
        }
    }
}