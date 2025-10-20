using eshift.Dto;
using eshift.Dao;
using eshift.Dao.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshift.Enums;
using eshift.Model;
using eshift.Utils;

namespace eshift.Service.Impl
{
    internal class UserServiceImpl : IUserService
    {
        private readonly IUserDao userDao;
        private readonly ICustomerDao customerDao;
        private readonly IStaffDao staffDao;
        private readonly IRoleDao roleDao;

        public UserServiceImpl()
        {
            roleDao = new RoleDaoImpl();
            userDao = new UserDaoImpl(roleDao);
            customerDao = new CustomerDaoImpl();
            staffDao = new StaffDaoImpl();
        }

        public bool CreateUser(UserCreateFromDto userCreateFromDto)
        {
            try
            {
                // Check if user with same username exists
                var existingUser = userDao.GetUserByUsername(userCreateFromDto.Username);
                if (existingUser != null)
                {
                    throw new Exception("A user account with this username already exists.");
                }

                // Get role model from database
                var roleModel = roleDao.GetRoleById((int)userCreateFromDto.Role);
                if (roleModel == null)
                {
                    throw new Exception($"Role '{userCreateFromDto.Role}' not found in the system.");
                }

                // Hash the password
                string hashedPassword = PasswordUtil.HashPassword(userCreateFromDto.Password);

                // Create user model
                var userModel = new UserModel
                {
                    Username = userCreateFromDto.Username,
                    Password = hashedPassword,
                    Role = roleModel
                };

                // Persist user model
                var createdUser = userDao.CreateUser(userModel);
                if (createdUser == null)
                {
                    throw new Exception("Failed to create user account.");
                }

                // Update customer or staff record with user account reference
                if (userCreateFromDto.Role == UserRoleEnum.CUSTOMER)
                {
                    var customer = customerDao.GetCustomerByCusId(userCreateFromDto.ReferenceId);
                    if (customer != null)
                    {
                        customer.UserAccount = createdUser.Id;
                        customerDao.UpdateCustomer(customer.CusId, customer);
                    }
                }
                else if (userCreateFromDto.Role == UserRoleEnum.ADMIN)
                {
                    var staff = staffDao.GetStaffByStaffId(userCreateFromDto.ReferenceId);
                    if (staff != null)
                    {
                        staff.UserAccount = createdUser.Id;
                        staffDao.UpdateStaff(staff.StaffId, staff);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateUser: {ex.Message}");
                throw;
            }
        }

        public void DeleteUserAccount(UserGridDto userGridDto)
        {
            try
            {
                // check if the user account exists
                var user = userDao.GetUserByUsername(userGridDto.Username);
                if (user == null)
                {
                    throw new Exception("User account not found.");
                }

                // remove the user account reference from the corresponding customer or staff record
                var userRole = userGridDto.Role == UserRoleEnum.CUSTOMER.ToString() ? UserRoleEnum.CUSTOMER : UserRoleEnum.ADMIN;
                if (userRole == UserRoleEnum.CUSTOMER)
                {
                    var customer = customerDao.GetCustomerByCusId(userGridDto.Id);
                    if (customer == null)
                    {
                        throw new Exception("Customer not found.");
                    }
                    customer.UserAccount = null;
                    customerDao.UpdateCustomer(customer.CusId, customer);

                }
                else if (userRole == UserRoleEnum.ADMIN)
                {
                    var staff = staffDao.GetStaffByStaffId(userGridDto.Id);
                    if (staff == null)
                    {
                        throw new Exception("Staff not found.");
                    }
                    staff.UserAccount = null;
                    staffDao.UpdateStaff(staff.StaffId, staff);

                }
                // delete the user account
                userDao.DeleteUserByUsername(user.Username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteUserAccount: {ex.Message}");
                throw new Exception(ex.Message, ex);
            }
        }

        public List<UserGridDto> FilterUsersForGridByUsername(string username)
        {
            try
            {
                var users = userDao.FilterUsersByUsername(username);
                var userGridList = new List<UserGridDto>();
                foreach (var user in users)
                {
                    userGridList.Add(convertToUserGridDto(user));
                }
                return userGridList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in FilterUsersForGridByUsername: {ex.Message}");
                throw new Exception("Failed to filter user accounts by username for grid display.", ex);
            }
        }

        public List<UserGridDto> GetAllUsersForGrid()
        {
            try
            {
                var users = userDao.GetAllUsers();
                var userGridList = new List<UserGridDto>();

                foreach (var user in users)
                {
                    userGridList.Add(convertToUserGridDto(user));
                }

                return userGridList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllUsersForGrid: {ex.Message}");
                throw new Exception("Failed to retrieve user accounts for grid display.", ex);
            }
        }

        private UserGridDto convertToUserGridDto(UserModel user)
        {
            string userRole = user.Role?.Id == (int)UserRoleEnum.CUSTOMER ? UserRoleEnum.CUSTOMER.ToString() : UserRoleEnum.ADMIN.ToString();
            var userGrid = new UserGridDto
            {
                Username = user.Username,
                Role = userRole,
            };

            if (userRole == UserRoleEnum.CUSTOMER.ToString())
            {
                var customer = customerDao.GetCustomerByUseraccount(user.Id);
                if (customer != null)
                {
                    userGrid.Id = customer.CusId;
                    userGrid.FullName = $"{customer.FirstName} {customer.LastName}";
                }
            } else if (userRole == UserRoleEnum.ADMIN.ToString())
            {
                var staff = staffDao.GetStaffByUseraccount(user.Id);
                if (staff != null)
                {
                    userGrid.Id = staff.StaffId;
                    userGrid.FullName = $"{staff.FirstName} {staff.LastName}";
                }
            }

            return userGrid;
        }

        public bool UpdateUser(UserUpdateFormDto userUpdateFormDto)
        {
            try
            {
                // Get existing user by old username
                var existingUser = userDao.GetUserByUsername(userUpdateFormDto.OldUsername);
                if (existingUser == null)
                {
                    throw new Exception("User account not found with the provided username.");
                }

                // Check if new username already exists (only if username is changing)
                if (userUpdateFormDto.OldUsername != userUpdateFormDto.NewUsername)
                {
                    var userWithNewUsername = userDao.GetUserByUsername(userUpdateFormDto.NewUsername);
                    if (userWithNewUsername != null)
                    {
                        throw new Exception("A user account with the new username already exists.");
                    }
                }

                // Update existing user model
                existingUser.Username = userUpdateFormDto.NewUsername;
                
                // Only update password if provided
                if (!string.IsNullOrWhiteSpace(userUpdateFormDto.Password))
                {
                    string hashedPassword = PasswordUtil.HashPassword(userUpdateFormDto.Password);
                    existingUser.Password = hashedPassword;
                }

                // Update user through DAO
                UserModel updatedUser = userDao.UpdateUser(existingUser);
                bool success = updatedUser != null;
                if (!success)
                {
                    throw new Exception("Failed to update user account.");
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateUser: {ex.Message}");
                throw;
            }
        }

        public bool Login(LoginCredentialsDto loginCredentials)
        {
            try
            {
                // Get existing user by username
                var user = userDao.GetUserByUsername(loginCredentials.Username);
                if (user == null)
                {
                    throw new Exception("Invalid username or password.");
                }

                // Validate password
                if (!PasswordUtil.ValidatePassword(loginCredentials.Password, user.Password))
                {
                    throw new Exception("Invalid username or password.");
                }

                // Check user status based on role
                string specialId;
                string FullName;
                int? dbId = 0;
                if (user.Role?.Id == (int)UserRoleEnum.CUSTOMER)
                {
                    var customer = customerDao.GetCustomerByUseraccount(user.Id);
                    if (customer == null || customer.Status.Id == (int)CustomerStatusEnum.DELETED)
                    {
                        throw new Exception("No active account found for this user.");
                    }
                    specialId = customer.CusId;
                    FullName = $"{customer.FirstName} {customer.LastName}";
                    dbId = customer.Id;
                }
                else if (user.Role?.Id == (int)UserRoleEnum.ADMIN)
                {
                    var staff = staffDao.GetStaffByUseraccount(user.Id);
                    if (staff == null || staff.Status == StaffStatusEnum.DELETED)
                    {
                        throw new Exception("No active account found for this user.");
                    }
                    specialId = staff.StaffId;
                    FullName = $"{staff.FirstName} {staff.LastName}";
                    dbId = staff.Id;
                }
                else
                {
                    throw new Exception("Invalid user role.");
                }

                // Set user session
                var userRole = user.Role.Id == (int)UserRoleEnum.CUSTOMER ? UserRoleEnum.CUSTOMER : UserRoleEnum.ADMIN;
                UserSession.SetUserSession(user.Id, specialId, user.Username, userRole, FullName, dbId);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Login: {ex.Message}");
                throw;
            }
        }
    }
}
