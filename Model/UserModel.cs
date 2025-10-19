using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Model
{
    internal class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public RoleModel Role { get; set; }

        public UserModel(int id, string username, string password, RoleModel role)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        public UserModel(int id): this(id, string.Empty, string.Empty, null)  
        {
        }

        public UserModel(string username) : this(0, username, string.Empty, null)
        {
        }

        public UserModel() { }
    }
}
