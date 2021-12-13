using System;

namespace ex_1_10_perfect_numbers
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int howManyPerfectNumbersShow;
            ulong[] perfectNumbersFound;
            bool userWantSearchPerfetNumbers;
            
            Console.WriteLine("Program for searching perfect numbers.");

            do
            {
                howManyPerfectNumbersShow = Helper.GetIntFromUser("How many perfect numbers do you want to see ?");
                perfectNumbersFound = GetPerfectNumbers(howManyPerfectNumbersShow);

                Console.WriteLine($"Showing the {howManyPerfectNumbersShow} first perfect numbers :");
                foreach (ulong perfectNumber in perfectNumbersFound)
                {
                    Console.WriteLine($"{perfectNumber} is a perfect number.");
                }

                Console.WriteLine("Do you want search more perfect numbers ? (yes/no)");
                userWantSearchPerfetNumbers = Console.ReadLine().Trim().ToLower() == "yes";
            } while (userWantSearchPerfetNumbers);
        }

        private static ulong[] GetPerfectNumbers(int howMany)
        {
            int counterNumberPerfectFound;
            ulong[] perfectNumbers;
            
            if (howMany < 1)
            {
                throw new Exception("You need to define a mininum of 1 perfect numbers to be show.");
            }

            perfectNumbers = new ulong[howMany];
            
            counterNumberPerfectFound = 0;
            for (ulong numberTestPerfectNumber = 1; counterNumberPerfectFound < howMany; numberTestPerfectNumber++)
            {
                if (IsPerfectNumber(numberTestPerfectNumber))
                {
                    perfectNumbers[counterNumberPerfectFound] = numberTestPerfectNumber;
                    counterNumberPerfectFound++;
                }
            }

            return perfectNumbers;
        }

        private static bool IsPerfectNumber(ulong number)
        {
            ulong additionDivisors;

            additionDivisors = 0;

            for (ulong iterator = 1; iterator <= (number / 2); iterator++)
            {
                if (number % iterator == 0)
                {
                    additionDivisors = additionDivisors + iterator;

                    if (additionDivisors > number)
                    {
                        return false;
                    }
                }
            }
            
            return additionDivisors == number;
        }
    }
}