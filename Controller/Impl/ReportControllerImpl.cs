using eshift.Dto;
using eshift.Service;
using eshift.Service.Impl;


namespace eshift.Controller.Impl
{
    internal class ReportControllerImpl : IReportController
    {
        private readonly IReportService reportService;
        public ReportControllerImpl() 
        {
            reportService = new ReportServiceImpl();        
        }

        public CustomrStatisticsReportDto GetCustomerStatisticsReport()
        {
            try
            {
                return reportService.GetCustomerStatisticsReport();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public JobStatisticsReportDto GetJobStatisticsReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                return reportService.GetJobStatisticsReportBetweenDates(startDate, endDate);
            } catch( Exception ex)
            {
                throw;
            }
        }

        public LoadStatisticsReportDto GetLoadStatisticsReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                return reportService.GetLoadStatisticsReportBetweenDates(startDate, endDate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public RevenueStatisticsReportDto GetRevenueStatisticsReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                return reportService.GetRevenueStatisticsReportBetweenDates(startDate, endDate);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TransportStatisticsReportDto GetTransportStatisticsReport()
        {
            try
            {
                return reportService.GetTransportStatisticsReport();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
