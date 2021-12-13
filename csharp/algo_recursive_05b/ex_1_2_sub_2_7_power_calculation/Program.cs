using System;

namespace ex_1_2_sub_2_7_power_calculation
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            ulong a = 3;
            ulong b = 20;
            
            Console.WriteLine($"The calculation of {a} power of {b} is equals to {PowerCalculation(a, b)}");
        }

        public static ulong PowerCalculation(ulong _number, ulong _power)
        {
            if (OperationAllowedIsEqualToZero(_power))
            {
                return 1;
            }

            return OperationAllowedMultiplication(_number, PowerCalculation(_number, OperationAllowedSubtractOne(_power)));
        }

        private static ulong OperationAllowedMultiplication(ulong _numberA, ulong _numberB)
        {
            return _numberA * _numberB;
        }

        private static ulong OperationAllowedSubtractOne(ulong _numberA)
        {
            return _numberA -  1;
        }

        private static bool OperationAllowedIsEqualToZero(ulong _numberA)
        {
            return _numberA == 0;
        }
    }
}