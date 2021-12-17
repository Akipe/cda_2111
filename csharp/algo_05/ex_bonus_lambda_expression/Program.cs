namespace ex_bonus_lambda_expression
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            int[] arrayForTest = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            // Multiple all items to himself
            var arrayMultiple= arrayForTest.Select(_x => _x * _x);
            ShowArrayToConsole(arrayMultiple);
            
            // Transform all unpair numbers to pair
            var arrayOnlyPair= arrayForTest.Select(_x => _x % 2 == 1 ? _x + 1 : _x);
            ShowArrayToConsole(arrayOnlyPair);
            
            // Transform pair numbers to unpair
            var arrayUnpair= arrayForTest.Where(_x => _x % 2 == 0).Select(_x => _x + 1);
            ShowArrayToConsole(arrayUnpair);
            
            
            // Return average bigger than 5
            var arrayBiggerThan5= arrayForTest.Where(_x => _x > 5);
            ShowArrayToConsole(arrayBiggerThan5);
            
        }
            

        private static void ShowArrayToConsole(IEnumerable<int> _array)
        {
            foreach (int item in _array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}