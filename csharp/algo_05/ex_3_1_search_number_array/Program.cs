using System;

namespace ex_3_1_search_number_array
{
    internal static class Program
    {
        private static readonly int[] ARRAY_TO_SEARCH = {
            4, 6, 16, 40, 41, 42, 59, 100, 184
        }; 
        
        
        public static void Main(string[] _args)
        {
            int numberToSearch;
            int indexOfNumber;
            
            Console.WriteLine("Welcome to number finder !");
            numberToSearch = Helper.GetIntFromUser("Please enter a number to search :");

            indexOfNumber = Program.GetIndexNumberFind(numberToSearch, Program.ARRAY_TO_SEARCH);

            if (indexOfNumber < 0)
            {
                Console.WriteLine("The number is not found in the array !");
            }
            else
            {
                Console.WriteLine($"The number is in index {indexOfNumber} of the array.");
            }
        }
        
        /// <summary>
        /// Return the index of the number search inside an array.
        /// Return a negative number if not found.
        /// </summary>
        /// <param name="_numberToFind">Number to search inside _array</param>
        /// <param name="_array">Where to search the number</param>
        /// <returns>Return the index where the number is, or a negative number if not found.</returns>
        private static int GetIndexNumberFind(int _numberToFind, int[] _array)
        {
            const int NUMBER_NOT_FOUND = -1;
            
            for (int numberIndex = 0; numberIndex < _array.Length; numberIndex++)
            {
                if (_numberToFind == _array[numberIndex])
                {
                    return numberIndex;
                }

                if (_numberToFind < _array[numberIndex])
                {
                    return NUMBER_NOT_FOUND;
                }
            }

            return NUMBER_NOT_FOUND;
        }
    }
}