namespace eshift.Dto
{
    public class TransportUnitGridDto
    {
        public string TransportUnitId { get; set; } = string.Empty;
        public string Vehicle { get; set; } = string.Empty; // Registration number
        public string Driver { get; set; } = string.Empty;  // StaffId + FirstName
        public string Assistant { get; set; } = string.Empty; // StaffId + FirstName
        public string Available { get; set; } = string.Empty; // "Yes" / "No"

        public TransportUnitGridDto() { }

        public TransportUnitGridDto(string transportUnitId, string vehicle, string driver, string assistant, string available)
        {
            TransportUnitId = transportUnitId;
            Vehicle = vehicle;
            Driver = driver;
            Assistant = assistant;
            Available = available;
        }
    }
}