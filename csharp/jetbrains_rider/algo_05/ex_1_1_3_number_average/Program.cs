using System;

namespace ex_1_1_3_number_average
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string listNumber;
            int[] listNum;

            listNumber = "10 12 115 9 33 6748 45";

            listNum = Program.Split(listNumber, ' ');
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