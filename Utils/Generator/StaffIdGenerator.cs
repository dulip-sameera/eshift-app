using eshift.Dao.Impl;
using System;

namespace eshift.Utils.Generator
{
    internal static class StaffIdGenerator
    {
        public static string GenerateNextStaffId()
        {
            var staffDao = new StaffDaoImpl();
            string? lastStaffId = staffDao.GetLastStaffId();
            int year = DateTime.Now.Year;
            int nextSeq = 1;

            if (!string.IsNullOrWhiteSpace(lastStaffId) && lastStaffId.Length == 12 && lastStaffId.StartsWith("STF"))
            {
                string lastYearStr = lastStaffId.Substring(3, 4);
                string lastSeqStr = lastStaffId.Substring(7, 5);
                if (int.TryParse(lastYearStr, out int lastYear) && int.TryParse(lastSeqStr, out int lastSeq))
                {
                    if (lastYear == year)
                        nextSeq = lastSeq + 1;
                }
            }

            return $"STF{year}{nextSeq.ToString("D5")}";
        }
    }
}