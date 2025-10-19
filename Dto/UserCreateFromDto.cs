using eshift.Enums;

namespace eshift.Dto
{
    internal class UserCreateFromDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRoleEnum Role { get; set; }
        public string ReferenceId { get; set; } = string.Empty;

        public UserCreateFromDto() { }

        public UserCreateFromDto(string username, string password, UserRoleEnum role, string referenceId)
        {
            Username = username;
            Password = password;
            Role = role;
            ReferenceId = referenceId;
        }
    }
}