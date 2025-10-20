using System;
using System.Collections.Generic;

namespace eshift.Utils.Validation
{
    public static class JobFormValidator
    {
        public static Dictionary<string, string> Validate(string pickup, string delivery, DateTime scheduledDate, string estimatedCost)
        {
            var errors = new Dictionary<string, string>();
            if (string.IsNullOrWhiteSpace(pickup))
                errors["pickup"] = "Pickup location is required.";
            if (string.IsNullOrWhiteSpace(delivery))
                errors["delivery"] = "Delivery location is required.";
            if (scheduledDate <= DateTime.Now)
                errors["scheduledDate"] = "Scheduled date must be in the future.";
            if (string.IsNullOrWhiteSpace(estimatedCost))
                errors["estimatedCost"] = "Estimated cost is required.";
            else if (!double.TryParse(estimatedCost, out double cost))
                errors["estimatedCost"] = "Estimated cost must be a numeric value.";
            return errors;
        }
    }
}
