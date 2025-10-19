using System;

namespace eshift.Dto
{
    public class JobGridDto
    {
        public string JobID { get; set; }
        public string Customer { get; set; }
        public string Pickup { get; set; }
        public string Delivery { get; set; }
        public string Description { get; set; }
        public DateTime ScheduledDate { get; set; }
        public double? EstimatedCost { get; set; }
        public double? ActualCost { get; set; }
        public string Status { get; set; }

        public JobGridDto() { }

        public JobGridDto(string jobID, string customer, string pickup, string delivery, string description,
            DateTime scheduledDate, double? estimatedCost, double? actualCost, string status)
        {
            JobID = jobID;
            Customer = customer;
            Pickup = pickup;
            Delivery = delivery;
            Description = description;
            ScheduledDate = scheduledDate;
            EstimatedCost = estimatedCost;
            ActualCost = actualCost;
            Status = status;
        }
    }
}