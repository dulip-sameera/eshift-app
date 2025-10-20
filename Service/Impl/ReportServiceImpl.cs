using eshift.Dao;
using eshift.Dao.Impl;
using eshift.Dto;
using eshift.Enums;

namespace eshift.Service.Impl
{
    public class ReportServiceImpl : IReportService
    {
        private readonly ICustomerDao customerDao = new CustomerDaoImpl();
        private readonly ITransportUnitDao transportUnitDao = new TransportUnitDaoImpl();
        private readonly IJobDao jobDao = new JobDaoImpl();

        public CustomrStatisticsReportDto GetCustomerStatisticsReport()
        {
            try
            {
                int totalCustomers = customerDao.GetTotalCustomersCount();
                int activeCustomers = customerDao.GetTotalCustomersCountByStatus((int)CustomerStatusEnum.ACTIVE);
                int inactiveCustomers = customerDao.GetTotalCustomersCountByStatus((int)CustomerStatusEnum.DELETED);
                
                return new CustomrStatisticsReportDto(totalCustomers, activeCustomers, inactiveCustomers);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetCustomerStatisticsReport: {ex.Message}");
                throw new Exception("Failed to generate customer statistics report", ex);
            }
        }

        public JobStatisticsReportDto GetJobStatisticsReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                var jobs = jobDao.GetJobsBetweenCreatedAt(startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
                
                int totalJobs = jobs.Count;
                int pendingJobs = jobs.Count(j => j.StatusId == (int)JobStatusEnum.PENDING);
                int inProgressJobs = jobs.Count(j => j.StatusId == (int)JobStatusEnum.IN_PROGRESS);
                int completedJobs = jobs.Count(j => j.StatusId == (int)JobStatusEnum.COMPLETED);
                int cancelledJobs = jobs.Count(j => j.StatusId == (int)JobStatusEnum.CANCELED);
                int rejectedJobs = jobs.Count(j => j.StatusId == (int)JobStatusEnum.REJECTED);
                
                return new JobStatisticsReportDto(totalJobs, pendingJobs, inProgressJobs, completedJobs, cancelledJobs, rejectedJobs);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetJobStatisticsReportBetweenDates: {ex.Message}");
                throw new Exception($"Failed to generate job statistics report between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}", ex);
            }
        }

        public LoadStatisticsReportDto GetLoadStatisticsReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                var jobs = jobDao.GetJobsBetweenCreatedAt(startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
                
                int totalLoads = 0;
                int totalWeight = 0;
                int totalVolume = 0;
                
                foreach (var job in jobs)
                {
                    var jobWithLoads = jobDao.GetJobWithLoadsByJobId(job.JobId);
                    if (jobWithLoads?.Loads != null)
                    {
                        totalLoads += jobWithLoads.Loads.Count;
                        totalWeight += (int)jobWithLoads.Loads.Sum(l => l.Weight);
                        totalVolume += (int)jobWithLoads.Loads.Sum(l => l.Volume);
                    }
                }
                
                return new LoadStatisticsReportDto(totalLoads, totalWeight, totalVolume);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetLoadStatisticsReportBetweenDates: {ex.Message}");
                throw new Exception($"Failed to generate load statistics report between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}", ex);
            }
        }

        public RevenueStatisticsReportDto GetRevenueStatisticsReportBetweenDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                var jobs = jobDao.GetJobsBetweenCreatedAt(startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
                
                // Calculate total revenue (sum of all job revenues)
                int totalRevenue = (int)jobs.Sum(j => 
                    j.StatusId == (int)JobStatusEnum.COMPLETED ? (j.ActualCost ?? 0) : (j.EstimatedCost ?? 0));
                
                // Calculate revenue by status (use estimated cost except for completed jobs)
                int pendingRevenue = (int)jobs
                    .Where(j => j.StatusId == (int)JobStatusEnum.PENDING)
                    .Sum(j => j.EstimatedCost ?? 0);
                    
                int inProgressRevenue = (int)jobs
                    .Where(j => j.StatusId == (int)JobStatusEnum.IN_PROGRESS)
                    .Sum(j => j.EstimatedCost ?? 0);
                    
                int completedRevenue = (int)jobs
                    .Where(j => j.StatusId == (int)JobStatusEnum.COMPLETED)
                    .Sum(j => j.ActualCost ?? 0);
                    
                int cancelledRevenue = (int)jobs
                    .Where(j => j.StatusId == (int)JobStatusEnum.CANCELED)
                    .Sum(j => j.EstimatedCost ?? 0);
                    
                int rejectedRevenue = (int)jobs
                    .Where(j => j.StatusId == (int)JobStatusEnum.REJECTED)
                    .Sum(j => j.EstimatedCost ?? 0);
                
                return new RevenueStatisticsReportDto(totalRevenue, pendingRevenue, inProgressRevenue, completedRevenue, cancelledRevenue, rejectedRevenue);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetRevenueStatisticsReportBetweenDates: {ex.Message}");
                throw new Exception($"Failed to generate revenue statistics report between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}", ex);
            }
        }

        public TransportStatisticsReportDto GetTransportStatisticsReport()
        {
            try
            {
                int totalTransportUnits = transportUnitDao.GetTotalTransportUnitCount();
                int availableTransportUnits = transportUnitDao.GetTransportUnitCountrByAvailability(TransportUnitAvailableEnum.YES.ToString());
                int unavailableTransportUnits = transportUnitDao.GetTransportUnitCountrByAvailability(TransportUnitAvailableEnum.NO.ToString());
                
                return new TransportStatisticsReportDto(totalTransportUnits, availableTransportUnits, unavailableTransportUnits);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTransportStatisticsReport: {ex.Message}");
                throw new Exception("Failed to generate transport statistics report", ex);
            }
        }
    }
}
