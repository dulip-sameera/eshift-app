using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dto
{
    internal class JobWithLoadsDto
    {
        public string JobId { get; set; } = string.Empty;
        public string Customer { get; set; } = string.Empty;
        public string PickupLocation { get; set; } = string.Empty;
        public string DeliveryLocation { get; set; } = string.Empty;
        public DateTime ScheduledDate { get; set; }
        public double? EstimatedCost { get; set; }
        public double? ActualCost { get; set; }
        public string? Description { get; set; }
        public List<LoadDto> Loads { get; set; } = new List<LoadDto>();
    }
}
