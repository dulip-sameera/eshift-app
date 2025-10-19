using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Model
{
    internal class RoleModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public RoleModel() { }

        public RoleModel(int id)
        {
            Id = id;
        }

        public RoleModel(string name)
        {
            Name = name;
        }
        public RoleModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
