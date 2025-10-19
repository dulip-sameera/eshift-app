using System.Text.RegularExpressions;

namespace eshift.Utils.Validation
{
    public static class VehicleValidator
    {
        // Validates vehicle fields and returns a dictionary of errors
        public static Dictionary<string, string> Validate(
            string brand,
            string model,
            string registrationNumber,
            double? containerVolume,
            double? maxWeight)
        {
            var errors = new Dictionary<string, string>();

            // Brand validation
            if (string.IsNullOrWhiteSpace(brand))
                errors["brand"] = "Brand name is required.";

            // Model validation
            if (string.IsNullOrWhiteSpace(model))
                errors["model"] = "Model is required.";

            // Registration number validation (Sri Lankan format)
            // Accepts formats like: "ABC-1234", "WP-1234", "123-4567", "CBA1234"
            var regPattern = @"^([A-Z]{2,3}-\d{4}|[A-Z]{2}-\d{4}|[A-Z]{3}\d{4}|\d{3}-\d{4})$";
            if (string.IsNullOrWhiteSpace(registrationNumber) ||
                !Regex.IsMatch(registrationNumber.Trim(), regPattern, RegexOptions.IgnoreCase))
            {
                errors["registrationNumber"] = "Invalid Sri Lankan vehicle registration number.";
            }

            // Container volume validation
            if (!containerVolume.HasValue || containerVolume.Value <= 0)
                errors["containerVolume"] = "Container volume must be greater than 0.";

            // Max weight validation
            if (!maxWeight.HasValue || maxWeight.Value <= 0)
                errors["maxWeight"] = "Max weight must be greater than 0.";

            return errors;
        }
    }
}