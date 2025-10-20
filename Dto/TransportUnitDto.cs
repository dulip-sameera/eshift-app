using eshift.Enums;

namespace eshift.Dto
{
    public class TransportUnitDto
    {
        public int? Id { get; set; } // Database ID
        public string TuId { get; set; } = string.Empty;
        public int VehicleId { get; set; }
        public string VehicleRegistrationNumber { get; set; } = string.Empty;
        public int DriverId { get; set; }
        public int AssistantId { get; set; }
        public TransportUnitAvailableEnum Available { get; set; }

        public TransportUnitDto() { }

        public TransportUnitDto(
            int? id,
            string tuId,
            int vehicleId,
            int driverId,
            int assistantId,
            TransportUnitAvailableEnum available
            ): this(id, tuId, vehicleId, string.Empty, driverId, assistantId, available)
        {
            
        }
        public TransportUnitDto(int? id, string tuId, int vehicleId, string vehicleRegistrationNumber, int driverId, int assistantId, TransportUnitAvailableEnum available)
        {
            Id = id;
            TuId = tuId;
            VehicleId = vehicleId;
            VehicleRegistrationNumber = vehicleRegistrationNumber;
            DriverId = driverId;
            AssistantId = assistantId;
            Available = available;
        }
    }
}