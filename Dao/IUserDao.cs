using eshift.Model;
using System.Collections.Generic;

namespace eshift.Dao
{
    internal interface IUserDao
    {
        List<UserModel> GetAllUsers();
        UserModel? GetUserById(int id);
        UserModel? GetUserByUsername(string username);
        List<UserModel> FilterUsersByUsername(string searchString);
        UserModel CreateUser(UserModel userModel);
        UserModel UpdateUser(UserModel userModel);
        void DeleteUserByUsername(string username);
    }
}
