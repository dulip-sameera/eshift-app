using eshift.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Controller
{
    internal interface IUserController
    {
        List<UserGridDto> GetAllUsersForGrid();
        List<UserGridDto> FilterUsersForGridByUsername(string username);
        void DeleteUserAccount(UserGridDto userGridDto);
        bool CreateUser(UserCreateFromDto userCreateFromDto);
        bool UpdateUser(UserUpdateFormDto userUpdateFormDto);
    }
}
