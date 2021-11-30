using System;

namespace ex_1_7_number_sorting
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to number sorting !");
            
            Console.WriteLine("Begin to sort two numbers...");
            Program.SortTwoNumbersExercice();
            
            // Console.WriteLine("Begin to sort three numbers...");
            // Program.SortThreeNumbersExercice();
        }

        private static void SortTwoNumbersExercice()
        {
            int numberA;
            int numberB;
            int tempStorage;
            
            numberA = Helper.GetIntFromUser("Please enter the first number :");
            numberB = Helper.GetIntFromUser("Please enter the second number :");

            if (numberA == numberB)
            {
                Console.WriteLine($"Numbers {numberA} and {numberB} are equals.");
            }
            else
            {
                if (numberA > numberB)
                {
                    tempStorage = numberA;
                    numberA = numberB;
                    numberB = tempStorage;
                }

                Console.WriteLine($"Numbers sort : {numberA} < {numberB}");
            }
        }
        
        // private static void SortThreeNumbersExercice()
        // {
        //     Console.WriteLine("Hello");
        // }

    }
}