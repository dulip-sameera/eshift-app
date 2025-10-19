using eshift.Model;
using System.Collections.Generic;

namespace eshift.Dao
{
    internal interface IRoleDao
    {
        List<RoleModel> GetAllRoles();
        RoleModel? GetRoleById(int id);
    }
}
