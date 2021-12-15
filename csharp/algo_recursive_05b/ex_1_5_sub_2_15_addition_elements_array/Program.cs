using System;

namespace ex_1_5_sub_2_15_addition_elements_array
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            int[] array =
            {
                156, 10, 7, 41, 8, 95, 42, 1, 62
            };
            
            Console.WriteLine($"The result of addition of the array is {Addition(array)}");
        }

        public static int Addition(int[] _array)
        {
            if (_array.Length > 1)
            {
                int[] arrayWithLastNumberRemoved = new int[_array.Length - 1];
                
                for (int index = 1; index < _array.Length; index++)
                {
                    arrayWithLastNumberRemoved[index - 1] = _array[index];
                }
                return _array[0] + Addition(arrayWithLastNumberRemoved);
            }
            else
            {
                return _array[0];
            }
            
        }
    }
}