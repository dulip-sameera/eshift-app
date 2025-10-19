using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace eshift.Utils.Validation
{
    public static class CustomerValidator
    {
        public static Dictionary<string, string> Validate(
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string city,
            string zipCode)
        {
            var errors = new Dictionary<string, string>();

            // First name: required, English, at least 3 chars
            var namePattern = @"^[A-Za-z]{3,}$";
            if (string.IsNullOrWhiteSpace(firstName))
                errors["firstName"] = "First name is required.";
            else if (!Regex.IsMatch(firstName, namePattern))
                errors["firstName"] = "First name must be at least 3 English letters.";

            // Last name: required, English, at least 3 chars
            if (string.IsNullOrWhiteSpace(lastName))
                errors["lastName"] = "Last name is required.";
            else if (!Regex.IsMatch(lastName, namePattern))
                errors["lastName"] = "Last name must be at least 3 English letters.";

            // Email: required, valid format
            var emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            if (string.IsNullOrWhiteSpace(email))
                errors["email"] = "Email is required.";
            else if (!Regex.IsMatch(email, emailPattern))
                errors["email"] = "Invalid email address.";

            // Phone: valid Sri Lankan phone number
            var phonePattern = @"^(?:0(?:7\d{8}|11\d{7}|81\d{7}|21\d{7}|31\d{7}|33\d{7}|34\d{7}|35\d{7}|36\d{7}|37\d{7}|38\d{7}|41\d{7}|45\d{7}|51\d{7}|52\d{7}|54\d{7}|55\d{7}|57\d{7}|63\d{7}|65\d{7}|66\d{7}|67\d{7}|71\d{7}|72\d{7}|75\d{7}|76\d{7}|77\d{7}|78\d{7}|81\d{7}|91\d{7}|92\d{7}|93\d{7}|94\d{7}|95\d{7}|99\d{7}))$";
            if (string.IsNullOrWhiteSpace(phone))
                errors["phone"] = "Phone number is required.";
            else if (!Regex.IsMatch(phone, phonePattern))
                errors["phone"] = "Invalid Sri Lankan phone number.";

            // City: required, only English letters
            var cityPattern = @"^[A-Za-z\s]+$";
            if (string.IsNullOrWhiteSpace(city))
                errors["city"] = "City is required.";
            else if (!Regex.IsMatch(city, cityPattern))
                errors["city"] = "City must contain only English letters.";

            // Zip code: valid Sri Lankan zip code (5 digits)
            var zipPattern = @"^\d{5}$";
            if (string.IsNullOrWhiteSpace(zipCode))
                errors["zipCode"] = "Zip code is required.";
            else if (!Regex.IsMatch(zipCode, zipPattern))
                errors["zipCode"] = "Invalid Sri Lankan zip code.";

            // Address: no validation required

            return errors;
        }
    }
}