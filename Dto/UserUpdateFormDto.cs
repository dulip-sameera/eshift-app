using eshift.Enums;

namespace eshift.Dto
{
    internal class UserUpdateFormDto
    {
        public string OldUsername { get; set; } = string.Empty;
        public string NewUsername { get; set; } = string.Empty;
        public string? Password { get; set; }
        public UserRoleEnum Role { get; set; }
        public string ReferenceId { get; set; } = string.Empty;

        public UserUpdateFormDto() { }

        public UserUpdateFormDto(string oldUsername, string newUsername, string? password, UserRoleEnum role, string referenceId)
        {
            OldUsername = oldUsername;
            NewUsername = newUsername;
            Password = password;
            Role = role;
            ReferenceId = referenceId;
        }
    }
}