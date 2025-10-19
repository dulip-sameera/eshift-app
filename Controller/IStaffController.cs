using eshift.Dto;
using eshift.Enums;

namespace eshift.Controller
{
    internal interface IStaffController
    {
        List<StaffGridDto>? GetAllStaffForGrid();
        StaffGridDto? GetStaffForGridByStaffId(string staffId);
        StaffDto? GetStaffByStaffId(string staffId);
        void DeleteStaffByStaffId(string staffId, StaffStatusEnum status);
        string CreateStaff(StaffDto staff);
        void UpdateStaff(string staffId, StaffDto staff);
    }
}