using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dto
{
    public class JobStatisticsReportDto
    {
        public int TotalJobs { get; set; }
        public int PendingJobs { get; set; }
        public int InProgressJobs { get; set; }
        public int CompletedJobs { get; set; }
        public int CancelledJobs { get; set; }
        public int RejectedJobs { get; set; }

        public JobStatisticsReportDto(int totalJobs, int pendingJobs, int inProgressJobs, int completedJobs, int cancelledJobs, int rejectedJobs)
        {
            TotalJobs = totalJobs;
            PendingJobs = pendingJobs;
            InProgressJobs = inProgressJobs;
            CompletedJobs = completedJobs;
            CancelledJobs = cancelledJobs;
            RejectedJobs = rejectedJobs;
        }
    }
}
