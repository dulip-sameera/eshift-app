using System.Collections.Generic;

namespace eshift.Utils.Validation
{
    public static class LoadValidator
    {
        public static Dictionary<string, string> Validate(double volume, double weight)
        {
            var errors = new Dictionary<string, string>();
            if (volume < 5)
                errors["volume"] = "Volume must be at least 5.";
            if (weight < 5)
                errors["weight"] = "Weight must be at least 5kg.";
            return errors;
        }
    }
}
