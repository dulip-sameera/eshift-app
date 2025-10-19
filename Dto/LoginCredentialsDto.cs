namespace eshift.Dto
{
    internal class LoginCredentialsDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public LoginCredentialsDto() { }

        public LoginCredentialsDto(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}