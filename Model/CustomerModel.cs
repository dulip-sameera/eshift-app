namespace eshift.Model
{
    internal class CustomerModel
    {
        public int? Id { get; set; }
        public string CusId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public CustomerStatusModel Status { get; set; } = new CustomerStatusModel();
        public int? UserAccount { get; set; }

        public CustomerModel() { }

        public CustomerModel(
            int? id,
            string cusId,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string city,
            string zipCode,
            CustomerStatusModel status,
            int? userAccount)
        {
            Id = id;
            CusId = cusId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            City = city;
            ZipCode = zipCode;
            Status = status;
            UserAccount = userAccount;
        }
    }
}