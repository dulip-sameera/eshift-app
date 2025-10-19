using System;

namespace eshift.Dto
{
    internal class JobDto
    {
        public int? Id { get; set; }
        public string JobId { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime ScheduledDate { get; set; }
        public double? EstimatedCost { get; set; }
        public double? ActualCost { get; set; }
        public int StatusId { get; set; }
        public int CustomerId { get; set; }
        public string? Description { get; set; }

        public JobDto() { }

        public JobDto(string jobId, double estimatedCost, int status)
        {
            JobId = jobId;
            EstimatedCost = estimatedCost;
            StatusId = status;
        }

        public JobDto(int? id, string jobId, string pickupLocation, string deliveryLocation, DateTime scheduledDate,
            double? estimatedCost, double? actualCost, int statusId, int customerId, string? description)
        {
            Id = id;
            JobId = jobId;
            PickupLocation = pickupLocation;
            DeliveryLocation = deliveryLocation;
            ScheduledDate = scheduledDate;
            EstimatedCost = estimatedCost;
            ActualCost = actualCost;
            StatusId = statusId;
            CustomerId = customerId;
            Description = description;
        }
    }
}