// See https://aka.ms/new-console-template for more information

namespace ex_bonus_recursive_bigger_number_array
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            int[] tabToSearch =
            {
                156,
                4,
                78,
                4,
                62,
                4,
                78,
                20,
                45,
                1,
                45,
                20
            };
            
            Console.WriteLine($"The biggest number is {FindBiggerNumber(tabToSearch)}");
        }

        private static int FindBiggerNumber(int[] _arrayToSearch, int _indexArrayToSearch = 0)
        {
            int lastBiggestNumber;
            int nextIndexToSearch = _indexArrayToSearch + 1;
            
            if (_indexArrayToSearch >= _arrayToSearch.Length - 1)
            {
                return _arrayToSearch[^1];
            }
            
            lastBiggestNumber = FindBiggerNumber(_arrayToSearch, nextIndexToSearch);
            
            return lastBiggestNumber > _arrayToSearch[_indexArrayToSearch] ?
                lastBiggestNumber : _arrayToSearch[_indexArrayToSearch];
        }
    }
}