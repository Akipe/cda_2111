using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowCore.Validation
{
    public static class GeneralValidation
    {
        public static string GetRandomString(int length = 10)
        {
            if (length < 1)
                throw new ArgumentException("You must define a minimum size to 1");

            const string randomChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random randomGenerator = new Random();

            return new string(
                Enumerable.Repeat(randomChars, length)
                .Select(s => s[randomGenerator.Next(s.Length)]).ToArray()
            );
        }
    }
}
