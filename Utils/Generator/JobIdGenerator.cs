using System;

namespace eshift.Utils.Generator
{
    public static class JobIdGenerator
    {
        public static string GenerateNextJobId()
        {
            // Example: JBYYYYNNNNN
            var year = DateTime.Now.Year;
            var random = new Random();
            var number = random.Next(10000, 99999);
            return $"JB{year}{number:D5}";
        }
    }
}
