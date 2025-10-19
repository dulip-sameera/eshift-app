using System;

namespace eshift.Utils.Generator
{
    public static class LoadIdGenerator
    {
        public static string GenerateNextLoadId()
        {
            // Example: LDYYYYNNNNNN
            var year = DateTime.Now.Year;
            var random = new Random();
            var number = random.Next(100000, 999999);
            return $"LD{year}{number:D6}";
        }
    }
}
