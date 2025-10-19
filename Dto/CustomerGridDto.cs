namespace eshift.Dto
{
    public class CustomerGridDto
    {
        public string CusId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty; // Combined first and last name
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Status as string
        public string Username { get; set; } = string.Empty; // Username from user account

        public CustomerGridDto() { }

        public CustomerGridDto(string cusId, string name, string email, string phone, string address, string city, string zipCode, string status, string username)
        {
            CusId = cusId;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            City = city;
            ZipCode = zipCode;
            Status = status;
            Username = username;
        }
    }
}