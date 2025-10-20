using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dto
{
    public class CustomrStatisticsReportDto
    {
        public int TotalCustomers { get; set; }
        public int ActiveCustomers { get; set; }
        public int InactiveCustomers { get; set; }
        public CustomrStatisticsReportDto(int totalCustomers, int activeCustomers, int inactiveCustomers)
        {
            TotalCustomers = totalCustomers;
            ActiveCustomers = activeCustomers;
            InactiveCustomers = inactiveCustomers;
        }
    }
}
