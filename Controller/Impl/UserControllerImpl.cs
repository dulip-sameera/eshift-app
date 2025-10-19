using eshift.Dto;
using eshift.Service;
using eshift.Service.Impl;

namespace eshift.Controller.Impl
{
    internal class UserControllerImpl : IUserController
    {
        private readonly IUserService userService;

        public UserControllerImpl() 
        {
            userService = new UserServiceImpl();
        }

        public bool CreateUser(UserCreateFromDto userCreateFromDto)
        {
            try
            {
               return userService.CreateUser(userCreateFromDto);
            } 
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteUserAccount(UserGridDto userGridDto)
        {
            try
            {
                userService.DeleteUserAccount(userGridDto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<UserGridDto> FilterUsersForGridByUsername(string username)
        {
            try
            {
                return userService.FilterUsersForGridByUsername(username);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<UserGridDto> GetAllUsersForGrid()
        {
            try
            {
                return userService.GetAllUsersForGrid();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool UpdateUser(UserUpdateFormDto userUpdateFormDto)
        {
            try
            {
                return userService.UpdateUser(userUpdateFormDto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Login(LoginCredentialsDto loginCredentials)
        {
            try
            {
                return userService.Login(loginCredentials);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
