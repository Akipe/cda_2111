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
            
            Console.WriteLine("Begin to sort three numbers...");
            Program.SortThreeNumbersLoopExercice();
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
        
        private static void SortThreeNumbersLoopExercice()
        {
            int numberA;
            int numberB;
            int numberC;
            int[] numbersSort;

            numberA = Helper.GetIntFromUser("Please enter the first number :");
            numberB = Helper.GetIntFromUser("Please enter the second number :");
            numberC = Helper.GetIntFromUser("Please enter the third number :");

            numbersSort = SortThreeNumbers(numberA, numberB, numberC);
            Console.WriteLine($"Numbers sort : {numbersSort[0]} < {numbersSort[1]} < {numbersSort[2]}");
        }

        private static int[] SortThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int[] twoNumbersSort;

            while (!(firstNumber < secondNumber & secondNumber < thirdNumber))
            {
                twoNumbersSort = Program.SortTwoNumbers(firstNumber, secondNumber);
                firstNumber = twoNumbersSort[0];
                secondNumber = twoNumbersSort[1];

                twoNumbersSort = Program.SortTwoNumbers(secondNumber, thirdNumber);
                secondNumber = twoNumbersSort[0];
                thirdNumber = twoNumbersSort[1];
            }

            return new int[] {firstNumber, secondNumber, thirdNumber};
        }

        private static int[] SortTwoNumbers(int firstNumber, int secondNumber)
        {
            int tempStorage;
            
            if (firstNumber > secondNumber)
            {
                tempStorage = firstNumber;
                firstNumber = secondNumber;
                secondNumber = tempStorage;
            }

            return new int[] {firstNumber, secondNumber};
            
        }
    }
}