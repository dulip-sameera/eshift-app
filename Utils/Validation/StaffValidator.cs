using System.Text.RegularExpressions;
using System.Collections.Generic;
using eshift.Enums;

namespace eshift.Utils.Validation
{
    internal static class StaffValidator
    {
        public static Dictionary<string, string> Validate(string firstName, string lastName, string email, string phone, string? licenseNumber, string position)
        {
            var errors = new Dictionary<string, string>();

            // First Name
            if (string.IsNullOrWhiteSpace(firstName))
                errors["firstName"] = "First name is required.";
            else if (!Regex.IsMatch(firstName, @"^[A-Za-z]+$"))
                errors["firstName"] = "First name must contain only English letters.";

            // Last Name
            if (string.IsNullOrWhiteSpace(lastName))
                errors["lastName"] = "Last name is required.";
            else if (!Regex.IsMatch(lastName, @"^[A-Za-z]+$"))
                errors["lastName"] = "Last name must contain only English letters.";

            // Email
            if (string.IsNullOrWhiteSpace(email))
                errors["email"] = "Email is required.";
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errors["email"] = "Please enter a valid email address.";

            // Phone
            if (string.IsNullOrWhiteSpace(phone))
                errors["phone"] = "Phone number is required.";
            else if (!Regex.IsMatch(phone, @"^(?:0|\+94)?[1-9]\d{8}$"))
                errors["phone"] = "Please enter a valid Sri Lankan phone number.";

            // Position
            if (string.IsNullOrWhiteSpace(position))
                errors["position"] = "Position is required.";

            // License Number
            if (position == StaffTypeEnum.DRIVER.ToString() || position == StaffTypeEnum.ASSISTANT.ToString())
            {
                if (string.IsNullOrWhiteSpace(licenseNumber))
                    errors["licenseNumber"] = "License number is required for drivers and assistants.";
                else if (!Regex.IsMatch(licenseNumber, @"^[A-Za-z0-9/-]{6,15}$"))
                    errors["licenseNumber"] = "Please enter a valid Sri Lankan license number.";
            }

            return errors;
        }
    }
}