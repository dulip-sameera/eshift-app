using eshift.Enums;

namespace eshift.Model
{
    internal class StaffModel
    {
        public int Id { get; set; }
        public string StaffId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? LicenseNumber { get; set; } // Nullable
        public StaffTypeModel Type { get; set; } = new StaffTypeModel();
        public int? UserAccount { get; set; } // Nullable
        public StaffStatusEnum Status { get; set; }

        public StaffModel() { }
        public StaffModel(int id, string staffId, string firstName, string lastName, string phone, string email, string? licenseNumber, StaffTypeModel type, int? userAccount, StaffStatusEnum status)
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