using System;

namespace ex_1_2_sub_2_6_multiplication_two_numbers
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            int a = -7;
            int b = 8;

            Console.WriteLine($"The multiplication of {a} * {b} is {MultiplicationRecursive(a, b)}");
        }

        public static int MultiplicationRecursive(int _numberA, int _numberB)
        {
            if (OperationAllowedIsEqualToZero(_numberB))
            {
                return 0;
            }
            
            return OperationAllowedAddition(
                _numberA , MultiplicationRecursive(_numberA, --_numberB));
        }

        private static int OperationAllowedAddition(int _firstNumber, int _secondNumber)
        {
            return _firstNumber + _secondNumber;
        }

        private static int OperationAllowedSubtractOne(int _number)
        {
            return _number - 1;
        }

        private static bool OperationAllowedIsEqualToZero(int _number)
        {
            return _number == 0;
        }
    }
}