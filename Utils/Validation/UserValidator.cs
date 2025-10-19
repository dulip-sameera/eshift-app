using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace eshift.Utils.Validation
{
    internal static class UserValidator
    {
        public static Dictionary<string, string> Validate(string username, string password)
        {
            var errors = new Dictionary<string, string>();

            // Username validation
            if (string.IsNullOrWhiteSpace(username))
                errors["username"] = "Username is required.";
            else if (username.Length <= 3)
                errors["username"] = "Username must be greater than 3 characters.";
            else if (!Regex.IsMatch(username, @"^[A-Za-z0-9_]+$"))
                errors["username"] = "Username can only contain letters, numbers, and underscore.";

            // Password validation
            if (string.IsNullOrWhiteSpace(password))
                errors["password"] = "Password is required.";
            else if (password.Length <= 8)
                errors["password"] = "Password must be greater than 8 characters.";
            else if (!Regex.IsMatch(password, @"^[A-Za-z0-9_*#&^$~!]+$"))
                errors["password"] = "Password can only contain letters, numbers, and special characters (_*#&^$~!).";

            return errors;
        }

        public static Dictionary<string, string> ValidateForUpdate(string username, string password)
        {
            var errors = new Dictionary<string, string>();

            // Username validation (always required)
            if (string.IsNullOrWhiteSpace(username))
                errors["username"] = "Username is required.";
            else if (username.Length <= 3)
                errors["username"] = "Username must be greater than 3 characters.";
            else if (!Regex.IsMatch(username, @"^[A-Za-z0-9_]+$"))
                errors["username"] = "Username can only contain letters, numbers, and underscore.";

            // Password validation (only if not empty)
            if (!string.IsNullOrWhiteSpace(password))
            {
                if (password.Length <= 8)
                    errors["password"] = "Password must be greater than 8 characters.";
                else if (!Regex.IsMatch(password, @"^[A-Za-z0-9_*#&^$~!]+$"))
                    errors["password"] = "Password can only contain letters, numbers, and special characters (_*#&^$~!).";
            }

            return errors;
        }
    }
}