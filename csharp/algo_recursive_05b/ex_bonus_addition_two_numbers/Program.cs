using System;

namespace ex_bonus_addition_two_numbers
{
    internal static class Program
    {
        public static void Main(string[] _argv)
        {
            int a = 12;
            int b = 8;
            
            Console.WriteLine($"The addition of {a} and {b} is {AdditionTwoNumbers(a, b)}");
        }

        public static int AdditionTwoNumbers(int _firstNumber, int _secondNumber)
        {
            if (_secondNumber == 0)
            {
                return _firstNumber;
            }
            
            return 1 + AdditionTwoNumbers(_firstNumber, _secondNumber - 1);
        }
    }
}