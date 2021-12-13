using System;

namespace ex_1_6_prime_number
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            int numberToCheck;
            
            Console.WriteLine("Welcome to prime number finder!");
            numberToCheck = Helper.GetIntFromUser("Please enter a number to check if it is a prime number :");

            Console.Write($"The number {numberToCheck} is ");
            Console.WriteLine(isPrimeNumber(numberToCheck) ? "prime number." : "not prime number.");
            
            Console.WriteLine("Bye bye !");
        }

        private static bool isPrimeNumber(int number)
        {
            int divider;

            for (divider = 2; divider < number; divider++)
            {
                if (number % divider == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}