using System;

namespace ex_1_3_sub_2_12_permutation_characters
{
    internal static class Program
    {
        public static void Main(string[] _argv)
        {
            string wordToPermut = "abc";

            string beforeLetter;
            string afterLetter;
            string letter;
            string wordWithoutLetter;
            
            beforeLetter = wordToPermut.Substring(0, 0);
            letter = wordToPermut.Substring(0, 1);
            afterLetter = wordToPermut.Substring(1, wordToPermut.Length - 1);
            wordWithoutLetter = beforeLetter + afterLetter;
            Console.WriteLine("Select "+ letter);
            Console.WriteLine("(before)0,0 :" + beforeLetter);
            Console.WriteLine("(letter)0,1 :" + letter);
            Console.WriteLine("(after)1,length :" + afterLetter);
            Console.WriteLine($"word to send : {wordWithoutLetter}");
            Console.WriteLine("");
            Console.WriteLine("");
            
            beforeLetter = wordToPermut.Substring(0, 0 + 1);
            letter = wordToPermut.Substring(0 + 1, 1);
            afterLetter = wordToPermut.Substring(1 + 1, wordToPermut.Length - 1 - 1);
            wordWithoutLetter = beforeLetter + afterLetter;
            Console.WriteLine("Select "+ letter);
            Console.WriteLine("(before)0,0 :" + beforeLetter);
            Console.WriteLine("(letter)0,1 :" + letter);
            Console.WriteLine("(after)1,length :" + afterLetter);
            Console.WriteLine($"word to send : {wordWithoutLetter}");
            Console.WriteLine("");
            Console.WriteLine("");
            
            beforeLetter = wordToPermut.Substring(0, 0 + 2);
            letter = wordToPermut.Substring(0 + 2, 1);
            afterLetter = wordToPermut.Substring(1 + 2, wordToPermut.Length - 1 - 2);
            wordWithoutLetter = beforeLetter + afterLetter;
            Console.WriteLine("Select "+ letter);
            Console.WriteLine("(before)0,0 :" + beforeLetter);
            Console.WriteLine("(letter)0,1 :" + letter);
            Console.WriteLine("(after)1,length :" + afterLetter);
            Console.WriteLine($"word to send : {wordWithoutLetter}");
            Console.WriteLine("");
            Console.WriteLine("");
            
            Permutation("abcde");
        }
        
        public static void Permutation(string _word)
        {
            string tempWord;
            
            string beforeLetter;
            string afterLetter;
            string letter;
            string wordWithoutLetter;
            
            if (_word.Length <= 2)
            {
                for (int indexLastChar =  0; indexLastChar < _word.Length; indexLastChar++)
                {
                    if (indexLastChar == 0)
                    {
                        Console.Write("(bottom)" + _word[indexLastChar].ToString() + _word[indexLastChar + 1].ToString());
                    }
                    else
                    {
                        Console.Write("(bottom)" + _word[indexLastChar].ToString() + _word[indexLastChar - 1].ToString());
                    }
                }
            }
            else
            {
                for (int indexLastChar =  0; indexLastChar < _word.Length; indexLastChar++)
                {
                    beforeLetter = _word.Substring(0, 0 + indexLastChar);
                    letter = _word.Substring(0 + indexLastChar, 1);
                    afterLetter = _word.Substring(1 + indexLastChar, _word.Length - 1 - indexLastChar);
                    wordWithoutLetter = beforeLetter + afterLetter;
                    
                    Console.WriteLine("(head)" + letter.ToString());
                    Permutation(wordWithoutLetter);
                }
            }
        }
    }
}