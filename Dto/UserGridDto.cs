using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dto
{
    public class UserGridDto
    {
        // If the user's role is CUSTOMER, Id will be CussId
        // If the user's role is ADMIN, Id will be StaffId
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        public UserGridDto() { }

        public UserGridDto(string username): this(string.Empty, string.Empty, username, string.Empty)
        {
        }

        public UserGridDto(string id, string fullName, string username, string role)
        {
            Id = id;
            FullName = fullName;
            Username = username;
            Role = role;
        }

    }
}
