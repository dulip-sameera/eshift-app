using eshift.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Service
{
    internal interface IReportService
    {
        CustomrStatisticsReportDto GetCustomerStatisticsReport();
        TransportStatisticsReportDto GetTransportStatisticsReport();
        JobStatisticsReportDto GetJobStatisticsReportBetweenDates(DateTime startDate, DateTime endDate);
        LoadStatisticsReportDto GetLoadStatisticsReportBetweenDates(DateTime startDate, DateTime endDate);
        RevenueStatisticsReportDto GetRevenueStatisticsReportBetweenDates(DateTime startDate, DateTime endDate);
    }
}
