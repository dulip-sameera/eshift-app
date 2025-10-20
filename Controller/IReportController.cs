using eshift.Dto;


namespace eshift.Controller
{
    internal interface IReportController
    {
        CustomrStatisticsReportDto GetCustomerStatisticsReport();
        TransportStatisticsReportDto GetTransportStatisticsReport();
        JobStatisticsReportDto GetJobStatisticsReportBetweenDates(DateTime startDate, DateTime endDate);
        LoadStatisticsReportDto GetLoadStatisticsReportBetweenDates(DateTime startDate, DateTime endDate);
        RevenueStatisticsReportDto GetRevenueStatisticsReportBetweenDates(DateTime startDate, DateTime endDate);

    }
}
