using System;

namespace ex_1_3_sub_2_10_palindromes
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            string wordToTest = "elle";
            
            Console.WriteLine($"Is the word \"{wordToTest}\" is a palindrome ? {IsPalindrome(wordToTest)}");
        }

        public static bool IsPalindrome(string _word)
        {
            if (_word.Length > 1)
            {
                if (_word[0] == _word[^1])
                {
                    // "_word.Length - 2" because we remove the first letter and the last letter.
                    return IsPalindrome(_word.Substring(1, _word.Length - 2));
                }
                return false;
            }

            return true;
        }
    }
}