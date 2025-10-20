using eshift.Enums;


namespace eshift.Dto
{
    public class JobWithLoadsAndTransportUnitDto
    {
        public string JobId { get; set; } = string.Empty;
        public string CustomerId { get; set; } = string.Empty;
        private string CustomerName { get; set; } = string.Empty;
        public string PickupLocation { get; set; } = string.Empty;
        public string DeliveryLocation { get; set; } = string.Empty;
        public DateTime ScheduledDate { get; set; }
        public double? EstimatedCost { get; set; }
        public double? ActualCost { get; set; }
        public string? Description { get; set; }
        public JobStatusEnum? statusEnum { get; set; }
        public List<LoadDto> Loads { get; set; } = new List<LoadDto>();
        public List<TransportUnitDto> TransportUnits { get; set; } = new List<TransportUnitDto>();
        public List<LoadDto> RemvoedLoads { get; set; } = new List<LoadDto>();
        public List<TransportUnitDto> RemovedTransportUnits { get; set; } = new List<TransportUnitDto>();
        public List<LoadDto> NewLoads { get; set; } = new List<LoadDto>();
        public List<TransportUnitDto> NewTransportUnits { get; set; } = new List<TransportUnitDto>();

        public JobWithLoadsAndTransportUnitDto() { }

        public JobWithLoadsAndTransportUnitDto(
            string jobId,
            string customerId,
            string customerName,
            string pickupLocation,
            string deliveryLocation,
            DateTime scheduledDate,
            double? estimatedCost,
            double? actualCost,
            string? description,
            JobStatusEnum? statusEnum,
            List<LoadDto> loads,
            List<TransportUnitDto> transportUnits
            )
        {
            JobId = jobId;
            CustomerId = customerId;
            CustomerName = customerName;
            PickupLocation = pickupLocation;
            DeliveryLocation = deliveryLocation;
            ScheduledDate = scheduledDate;
            EstimatedCost = estimatedCost;
            ActualCost = actualCost;
            Description = description;
            this.statusEnum = statusEnum;
            Loads = loads;
            TransportUnits = transportUnits;
        }

        public JobWithLoadsAndTransportUnitDto(
            string jobId,
            string customerId,
            string customerName,
            string pickupLocation,
            string deliveryLocation,
            DateTime scheduledDate,
            double? estimatedCost,
            double? actualCost,
            string? description,
            JobStatusEnum? statusEnum,
            List<LoadDto> loads,
            List<TransportUnitDto> transportUnits,
            List<LoadDto> removedLoads,
            List<TransportUnitDto> removedTransportUnits,
            List<LoadDto> newLoads,
            List<TransportUnitDto> newTransportUnits
            ) : this(
                jobId,
                customerId,
                customerName,
                pickupLocation,
                deliveryLocation, 
                scheduledDate, 
                estimatedCost,
                actualCost, 
                description, 
                statusEnum,
                loads, 
                transportUnits
                )
        {
            RemvoedLoads = removedLoads;
            RemovedTransportUnits = removedTransportUnits;
            NewLoads = newLoads;
            NewTransportUnits = newTransportUnits;
        }
    }
}
