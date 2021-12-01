using System;
using System.Text;

namespace ex_1_1_3_number_average
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string userInputNumbers;
            int howManyNumbers;
            int sumNumbers;
            float averageNumber;
            int[] listNumbers;

            Console.WriteLine("Welcome to number average calculator.");
            Console.WriteLine("Please enter numbers to calculate average (ex: \"15 12 200 4\"");
            userInputNumbers = Console.ReadLine();
            listNumbers = Program.SplitV2(userInputNumbers, ' ');
            howManyNumbers = listNumbers.Length;
            sumNumbers = 0;

            foreach (int number in listNumbers)
            {
                sumNumbers = sumNumbers + number;
            }
            averageNumber = (float) sumNumbers / (float) howManyNumbers;
            
            Console.WriteLine($"The average is {averageNumber}");
        }

        /// <summary>
        /// Split a string to a static array with numbers separate by a char.
        /// First version without optimizations (addition of strings).
        /// </summary>
        /// <param name="sentence">The string to split</param>
        /// <param name="charWhichSplit">The char who separates numbers</param>
        /// <returns>Return a static array with numbers inside the string.</returns>
        private static int[] SplitV1(string sentence, char charWhichSplit)
        {
            int howManyNumbers;
            
            howManyNumbers = Program.SplitGetHowManyNumbers(sentence, charWhichSplit);
            return Program.SplitGetNumbersListNotOptimizeString(sentence, howManyNumbers, charWhichSplit);
        }
        
        /// <summary>
        /// Split a string to a static array with numbers separate by a char.
        /// Second version with optimizations (use StringBuilder).
        /// </summary>
        /// <param name="sentence">The string to split</param>
        /// <param name="charWhichSplit">The char who separates numbers</param>
        /// <returns>Return a static array with numbers inside the string.</returns>
        private static int[] SplitV2(string sentence, char charWhichSplit)
        {
            int howManyNumbers;
            
            howManyNumbers = Program.SplitGetHowManyNumbers(sentence, charWhichSplit);
            return Program.SplitGetNumbersListOptimizeString(sentence, howManyNumbers, charWhichSplit);
        }

        private static int SplitGetHowManyNumbers(string sentence, char charWhichSplit)
        {
            int howManyNumbers;

            howManyNumbers = 0;
            for (int charCounter = 0; charCounter < sentence.Length; charCounter++)
            {
                if (sentence[charCounter] == charWhichSplit)
                {
                    howManyNumbers++;
                }
            }

            howManyNumbers++;

            return howManyNumbers;
        }

        private static int[] SplitGetNumbersListNotOptimizeString(string sentence, int howManyNumbers, char charWhichSplit)
        {
            int[] numberslist;
            int numbersCounter;
            string numberBeforeCast;
            
            numbersCounter = 0;
            numberBeforeCast = "";
            numberslist = new int[howManyNumbers];

            for (int charCounter = 0; charCounter < sentence.Length; charCounter++)
            {
                if (sentence[charCounter] != charWhichSplit)
                {
                    numberBeforeCast = numberBeforeCast + sentence[charCounter];
                }

                if (sentence[charCounter] == charWhichSplit | charCounter == (sentence.Length - 1))
                {
                    numberslist[numbersCounter] = int.Parse(numberBeforeCast);
                    numbersCounter++;
                    numberBeforeCast = "";
                }
            }

            return numberslist;
        }
        
        private static int[] SplitGetNumbersListOptimizeString(string sentence, int howManyNumbers, char charWhichSplit)
        {
            int[] numberslist;
            int numbersCounter;
            StringBuilder numberBeforeCast;
            
            numbersCounter = 0;
            numberBeforeCast = new StringBuilder("");
            numberslist = new int[howManyNumbers];

            for (int charCounter = 0; charCounter < sentence.Length; charCounter++)
            {
                if (sentence[charCounter] != charWhichSplit)
                {
                    // numberBeforeCast = numberBeforeCast + sentence[charCounter];
                    numberBeforeCast.Append(sentence[charCounter]);
                }

                if (sentence[charCounter] == charWhichSplit | charCounter == (sentence.Length - 1))
                {
                    numberslist[numbersCounter] = int.Parse(numberBeforeCast.ToString());
                    numbersCounter++;
                    numberBeforeCast.Clear();
                }
            }

            return numberslist;
        }
    }
}