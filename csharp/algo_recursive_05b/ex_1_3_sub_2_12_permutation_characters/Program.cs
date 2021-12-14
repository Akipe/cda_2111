using System;

namespace ex_1_3_sub_2_12_permutation_characters
{
    internal static class Program
    {
        public static void Main(string[] _argv)
        {
            string wordToPermut = "abce";

            string beforeLetter;
            string afterLetter;
            string letter;
            string wordWithoutLetter;
            
            // beforeLetter = wordToPermut.Substring(0, 0);
            // letter = wordToPermut.Substring(0, 1);
            // afterLetter = wordToPermut.Substring(1, wordToPermut.Length - 1);
            // wordWithoutLetter = beforeLetter + afterLetter;
            // Console.WriteLine("Select "+ letter);
            // Console.WriteLine("(before)0,0 :" + beforeLetter);
            // Console.WriteLine("(letter)0,1 :" + letter);
            // Console.WriteLine("(after)1,length :" + afterLetter);
            // Console.WriteLine($"word to send : {wordWithoutLetter}");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // beforeLetter = wordToPermut.Substring(0, 0 + 1);
            // letter = wordToPermut.Substring(0 + 1, 1);
            // afterLetter = wordToPermut.Substring(1 + 1, wordToPermut.Length - 1 - 1);
            // wordWithoutLetter = beforeLetter + afterLetter;
            // Console.WriteLine("Select "+ letter);
            // Console.WriteLine("(before)0,0 :" + beforeLetter);
            // Console.WriteLine("(letter)0,1 :" + letter);
            // Console.WriteLine("(after)1,length :" + afterLetter);
            // Console.WriteLine($"word to send : {wordWithoutLetter}");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // beforeLetter = wordToPermut.Substring(0, 0 + 2);
            // letter = wordToPermut.Substring(0 + 2, 1);
            // afterLetter = wordToPermut.Substring(1 + 2, wordToPermut.Length - 1 - 2);
            // wordWithoutLetter = beforeLetter + afterLetter;
            // Console.WriteLine("Select "+ letter);
            // Console.WriteLine("(before)0,0 :" + beforeLetter);
            // Console.WriteLine("(letter)0,1 :" + letter);
            // Console.WriteLine("(after)1,length :" + afterLetter);
            // Console.WriteLine($"word to send : {wordWithoutLetter}");
            // Console.WriteLine("");
            // Console.WriteLine("");
            
            //Console.WriteLine(Permutation("abc", 1));
            Permutation("abcde", 1);
        }
        
        public static void Permutation(string _word, int _counter, string _beforeWord = "")
        //public static string Permutation(string _word, int _counter, string _beforeWord = "")
        {
            string tempWord;
            
            string beforeLetter;
            string afterLetter;
            string letter;
            string wordWithoutLetter;
            

            for (int indexLastChar =  0; indexLastChar < _word.Length; indexLastChar++)
            {
                beforeLetter = _word.Substring(0, 0 + indexLastChar);
                letter = _beforeWord + _word.Substring(0 + indexLastChar, 1);
                afterLetter = _word.Substring(1 + indexLastChar, _word.Length - 1 - indexLastChar);
                wordWithoutLetter = beforeLetter + afterLetter;
                
                if (letter.ToString().Length == (_word.Length + _beforeWord.Length))
                {
                    Console.WriteLine(letter.ToString());
                    if (_counter == 0)
                    {
                        Console.WriteLine(letter.ToString());
                        //return letter.ToString();
                    }
                    _counter--;
                }
                //return Permutation(wordWithoutLetter, _counter, letter);
                Permutation(wordWithoutLetter, _counter, letter);
            }
        }
    }
}