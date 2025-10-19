using eshift.Model;
using eshift.Enums;
using System.Collections.Generic;

namespace eshift.Dao
{
    internal interface IStaffDao
    {
        List<(StaffModel, string)> GetAllStaffWithUsernames();
        (StaffModel, string)? GetStaffWithUsernameByStaffId(string staffId);
        StaffModel? GetStaffByStaffId(string staffId);
        bool UpdateStaffStatusByStaffId(string staffId, StaffStatusEnum status);
        bool CreateStaff(StaffModel staff);
        string? GetLastStaffId();
        bool UpdateStaff(string staffId, StaffModel staff);
        StaffModel? GetStaffByUseraccount(int userAccount); 
    }
}