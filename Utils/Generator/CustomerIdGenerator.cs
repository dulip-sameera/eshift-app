using eshift.Dao;
using eshift.Dao.Impl;
using System;
using System.Text.RegularExpressions;

namespace eshift.Utils.Generator
{
    internal static class CustomerIdGenerator
    {
        public static string GenerateNextCustomerId()
        {
            ICustomerDao customerDao = new CustomerDaoImpl();
            string? lastCusId = customerDao.GetLastCustomerId();

            string year = DateTime.Now.Year.ToString();
            int nextNumber = 1;

            if (!string.IsNullOrWhiteSpace(lastCusId))
            {
                var match = Regex.Match(lastCusId, @"^CUS(\d{4})(\d{5})$");
                if (match.Success)
                {
                    string lastYear = match.Groups[1].Value;
                    string lastNumber = match.Groups[2].Value;

                    if (lastYear == year)
                    {
                        nextNumber = int.Parse(lastNumber) + 1;
                    }
                }
            }

            return $"CUS{year}{nextNumber.ToString("D5")}";
        }
    }
}