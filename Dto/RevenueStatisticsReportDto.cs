

namespace eshift.Dto
{
    public class RevenueStatisticsReportDto
    {
        public int TotalRevenue { get; set; }
        public int PendingRevenue { get; set; }
        public int InProgressRevenue { get; set; }
        public int CompletedRevenue { get; set; }
        public int CancelledRevenue { get; set; }
        public int RejectedRevenue { get; set; }

        public RevenueStatisticsReportDto(int totalRevenue, int pendingRevenue, int inProgressRevenue, int completedRevenue, int cancelledRevenue, int rejectedRevenue)
        {
            TotalRevenue = totalRevenue;
            PendingRevenue = pendingRevenue;
            InProgressRevenue = inProgressRevenue;
            CompletedRevenue = completedRevenue;
            CancelledRevenue = cancelledRevenue;
            RejectedRevenue = rejectedRevenue;
        }
    }
}
