using eshift.Dto;
using eshift.Enums;

namespace eshift.Service
{
    internal interface IStaffService
    {
        List<StaffGridDto> GetAllStaffForGrid();
        StaffGridDto? GetStaffForGridByStaffId(string staffId);
        StaffDto? GetStaffByStaffId(string staffId); // Added
        void DeleteStaffByStaffId(string staffId, StaffStatusEnum status);
        string CreateStaff(StaffDto staff);
        void UpdateStaff(string staffId, StaffDto staff);
    }
}