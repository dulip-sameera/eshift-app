namespace eshift.Dto
{
    internal class VehicleDbIdDto
    {
        public int DbId { get; set; }
        public string RegistrationNumber { get; set; } = string.Empty;
        public VehicleDbIdDto() { }
        public VehicleDbIdDto(int dbId, string registrationNumber)
        {
            DbId = dbId;
            RegistrationNumber = registrationNumber;
        }
    }
}