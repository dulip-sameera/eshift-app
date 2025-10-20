using System;

namespace eshift.Model
{
    internal class JobModel
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

        public DateTime CreatedAt { get; set; }

        public JobModel() { }

        public JobModel(int? id, string jobId, string pickupLocation, string deliveryLocation, DateTime scheduledDate,
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
            CreatedAt = DateTime.Now;
        }

        public JobModel(int? id, string jobId, string pickupLocation, string deliveryLocation, DateTime scheduledDate,
            double? estimatedCost, double? actualCost, int statusId, int customerId, string? description, DateTime createdAt)
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
            CreatedAt = createdAt;
        }
    }
}