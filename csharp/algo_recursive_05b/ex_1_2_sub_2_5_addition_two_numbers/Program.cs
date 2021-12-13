using System;

namespace ex_1_2_sub_2_5_addition_two_numbers
{
    public class Program
    {
        public static void Main(string[] _args)
        {
            int a = 3;
            int b = 9;
            
            Console.WriteLine($"The addition of {a} and {b} is {AdditionRecursivePositiveNumbers(a, b)}");

            int c = 3;
            int d = -4;
            
            Console.WriteLine($"The addition of {c} and {d} is {AdditionRecursive(c, d)}");
        }

        public static int AdditionRecursivePositiveNumbers(int _fistNumber, int _secondNumber)
        {
            if (AllowCompareHigherThanZero(_fistNumber))
            {
                return AdditionRecursivePositiveNumbers(AllowSubtraction(_fistNumber), AllowAddition(_secondNumber));
            }
            
            return _secondNumber;
        }
        
        public static int AdditionRecursive(int _fistNumber, int _secondNumber)
        {
            if (AllowCompareLowThanZero(_fistNumber))
            {
                return AdditionRecursive(AllowAddition(_fistNumber), AllowSubtraction(_secondNumber));
            }
            
            if (AllowCompareHigherThanZero(_fistNumber))
            {
                return AdditionRecursivePositiveNumbers(AllowSubtraction(_fistNumber), AllowAddition(_secondNumber));
            }
            
            return _secondNumber;
        }


        private static int AllowAddition(int _a)
        {
            return _a + 1;
        }

        private static int AllowSubtraction(int _a)
        {
            return _a - 1;
        }

        private static bool AllowCompareEqualsToZero(int _a)
        {
            return _a == 0;
        }
        
        private static bool AllowCompareHigherThanZero(int _a)
        {
            return _a > 0;
        }

        private static bool AllowCompareLowThanZero(int _a)
        {
            return _a < 0;
        }
    }
}