using System;

namespace ex_1_1_3_number_average
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string userInputNumbers;
            int howManyNumbers;
            int sumNumbers;
            int countNumbers;
            float averageNumber;
            int[] listNumbers;

            Console.WriteLine("Welcome to number average calculator.");
            Console.WriteLine("Please enter numbers to calculate average (ex: \"15 12 200 4\"");
            userInputNumbers = Console.ReadLine();
            listNumbers = Program.Split(userInputNumbers, ' ');
            howManyNumbers = listNumbers.Length;
            sumNumbers = 0;

            foreach (int number in listNumbers)
            {
                sumNumbers = sumNumbers + number;
            }
            averageNumber = (float) sumNumbers / (float) howManyNumbers;
            
            Console.WriteLine($"The average is {averageNumber}");
        }

        private static int[] Split(string _sentence, char _charWhichSplit)
        {
            int howManyNumbers;
            int numbersCounter;
            int[] listNumbers;
            string numberBeforeCast;

            howManyNumbers = 0;
            for (int charCounter = 0; charCounter < _sentence.Length; charCounter++)
            {
                if (_sentence[charCounter] == _charWhichSplit)
                {
                    howManyNumbers++;
                }
            }

            howManyNumbers++;

            numbersCounter = 0;
            numberBeforeCast = "";
            listNumbers = new int[howManyNumbers];

            for (int charCounter = 0; charCounter < _sentence.Length; charCounter++)
            {
                if (_sentence[charCounter] != _charWhichSplit)
                {
                    numberBeforeCast = numberBeforeCast + _sentence[charCounter];
                }

                if (_sentence[charCounter] == _charWhichSplit | charCounter == (_sentence.Length - 1))
                {
                    listNumbers[numbersCounter] = int.Parse(numberBeforeCast);
                    numbersCounter++;
                    numberBeforeCast = "";
                }
            }

            return listNumbers;
        }
    }
}