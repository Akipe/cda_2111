using System;

namespace ex_1_3_sub_2_12_permutation_characters
{
    internal static class Program
    {
        public static void Main(string[] _argv)
        {
            string wordToPermut = "abcde";
            int counter = 100;
            
            Console.WriteLine($"The permutation of {wordToPermut} at number {counter} is :");
            Permutation(wordToPermut, ref counter);
        }
        
        public static void Permutation(string _word, ref int _counter, string _beforeWord = "")
        {
            string beforeLetter;
            string afterLetter;
            string wordSelected;
            string wordWithoutLetter;

            for (int indexChar =  0; indexChar < _word.Length; indexChar++)
            {
                beforeLetter = _word.Substring(0, 0 + indexChar);
                wordSelected = _beforeWord + _word.Substring(0 + indexChar, 1);
                afterLetter = _word.Substring(1 + indexChar, _word.Length - 1 - indexChar);
                wordWithoutLetter = beforeLetter + afterLetter;
            
                if (wordSelected.Length == (_word.Length + _beforeWord.Length))
                {
                    if (_counter == 0)
                    {
                        Console.WriteLine($"{wordSelected}");
                    }
                    _counter--;
                }
                Permutation(wordWithoutLetter, ref _counter, wordSelected);
            }
        }
    }
}