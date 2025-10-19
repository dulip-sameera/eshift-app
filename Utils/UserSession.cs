using eshift.Enums;

namespace eshift.Utils
{
    internal static class UserSession
    {
        public static int? UserId { get; private set; }
        public static string? SpecialId { get; private set; }
        public static string? Username { get; private set; }
        public static UserRoleEnum? Role { get; private set; }
        public static string? FullName { get; private set; }

        public static void SetUserSession(int userId, string specialId, string username, UserRoleEnum role, string fullName)
        {
            UserId = userId;
            SpecialId = specialId;
            Username = username;
            Role = role;
            FullName = fullName;
        }

        public static void Clear()
        {
            UserId = null;
            SpecialId = null;
            Username = null;
            Role = null;
            FullName = null;
        }

        public static bool IsLoggedIn()
        {
            return UserId.HasValue;
        }
    }
}