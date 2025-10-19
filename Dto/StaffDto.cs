using eshift.Enums;

namespace eshift.Dto
{
    internal class StaffDto
    {
        public int? Id { get; set; } // Database ID
        public string StaffId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? LicenseNumber { get; set; } // Nullable
        public StaffTypeDto Type { get; set; } = new StaffTypeDto();
        public int? UserAccount { get; set; } // Nullable
        public StaffStatusEnum Status { get; set; }

        public StaffDto() { }
        public StaffDto(int? id, string staffId, string firstName, string lastName, string phone, string email, string? licenseNumber, StaffTypeDto type, int? userAccount, StaffStatusEnum status)
        {
            Id = id;
            StaffId = staffId;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            LicenseNumber = licenseNumber;
            Type = type;
            UserAccount = userAccount;
            Status = status;
        }
    }
}