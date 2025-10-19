namespace eshift.Dto
{
    public class StaffGridDto
    {
        public string StaffId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty; // FirstName + LastName
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty; // StaffType
        public string? LicenseNumber { get; set; } // Nullable
        public string Username { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public StaffGridDto() { }
        public StaffGridDto(string staffId, string name, string phone, string email, string position, string? licenseNumber, string username, string status)
        {
            StaffId = staffId;
            Name = name;
            Phone = phone;
            Email = email;
            Position = position;
            LicenseNumber = licenseNumber;
            Username = username;
            Status = status;
        }
    }
}