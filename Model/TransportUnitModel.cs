using eshift.Enums;

namespace eshift.Model
{
    internal class TransportUnitModel
    {
        public int? Id { get; set; }
        public string TuId { get; set; } = string.Empty;
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public int AssistantId { get; set; }
        public TransportUnitAvailableEnum Available { get; set; }

        public TransportUnitModel() { }

        public TransportUnitModel(int? id, string tuId, int vehicleId, int driverId, int assistantId, TransportUnitAvailableEnum available)
        {
            Id = id;
            TuId = tuId;
            VehicleId = vehicleId;
            DriverId = driverId;
            AssistantId = assistantId;
            Available = available;
        }
    }
}