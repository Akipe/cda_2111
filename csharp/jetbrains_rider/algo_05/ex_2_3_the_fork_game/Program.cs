using System;

namespace ex_2_3_the_fork_game
{
    internal static class Program
    {
        private const int MinimalRandomNumber = 0;
        private const int MaximalRandomNumber = 100;

        private static int _numberToFind;
        private static int _minimalRangeNumber;
        private static int _maximalRangeNumber;
        
        public static void Main(string[] args)
        {
            int userNumber;
            int howManyTry;
            
            Console.WriteLine("Welcome to The Fork Game!");
            Console.WriteLine("Try to guest a number ...");

            Program._numberToFind = GetRandomNumberForForkGame();
            Program._minimalRangeNumber = Program.MinimalRandomNumber;
            Program._maximalRangeNumber = Program.MaximalRandomNumber;
            howManyTry = 0;

            do
            {
                userNumber =
                    Helper.GetIntFromUser(
                        $"Please enter a number between {Program._minimalRangeNumber} and {Program._maximalRangeNumber} (included)");

                howManyTry++;
                
                if (userNumber == Program._numberToFind)
                {
                    Console.WriteLine($"You have found the number in {howManyTry} moves ! Congratulation!");
                }
                else if (IsLowerAndNotExceedRange(userNumber))
                {
                    Console.WriteLine("The number is bigger.");
                    Program._minimalRangeNumber = userNumber;
                }
                else if (IsLowerAndExceedRange(userNumber))
                {
                    Console.WriteLine($"You enter a too small number (range is between {Program._minimalRangeNumber} & {Program._maximalRangeNumber}) !");
                }
                else if (IsBiggerAndNotExceedRange(userNumber))
                {
                    Console.WriteLine("The number is lower.");
                    Program._maximalRangeNumber = userNumber;
                }
                else if (IsBiggerAndExceedRange(userNumber))
                {
                    Console.WriteLine($"You enter a too big number (range is between {Program._minimalRangeNumber} & {Program._maximalRangeNumber}) !");
                }

            } while (userNumber != Program._numberToFind);
            
            Console.WriteLine("Bye bye!");
        }

        private static int GetRandomNumberForForkGame()
        {
            return new Random().Next(
                Program.MinimalRandomNumber,
                Program.MaximalRandomNumber + 1);
        }

        private static bool IsLowerAndNotExceedRange(int number)
        {
            return number < Program._numberToFind & number > Program._minimalRangeNumber;
        }

        private static bool IsLowerAndExceedRange(int number)
        {
            return number < Program._numberToFind & number < Program._minimalRangeNumber;
        }
        
        private static bool IsBiggerAndNotExceedRange(int number)
        {
            return number > Program._numberToFind & number < Program._maximalRangeNumber;
        }

        private static bool IsBiggerAndExceedRange(int number)
        {
            return number > Program._numberToFind & number > Program._maximalRangeNumber;
        }
    }
}