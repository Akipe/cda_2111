using System;

namespace ex_3_3_count_all_alphabetic_letters
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            string? text;
            CharCounter charCounter;
            string[,] resultCharsCounter;

            try
            {
                Console.WriteLine("Welcome to Character calculator.");
                do
                {
                    Console.WriteLine("Please enter a sentence :");
                    text = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(text))
                    {
                        Console.WriteLine("You sentence is empty !");
                    }
                } while (string.IsNullOrWhiteSpace(text));

                charCounter = new CharCounter();
        
                charCounter.SetSentence(text);
                resultCharsCounter = charCounter.GetCharCounter();

                for (int indexChar = 0; indexChar < charCounter.GetHowManyCharactersAlphabet(); indexChar++)
                {
                    Console.Write(resultCharsCounter[indexChar, charCounter.GetCharacterIndex()]);
                    Console.Write(" > ");
                    Console.WriteLine(resultCharsCounter[indexChar, charCounter.GetCounterIndex()]);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error : {error}");
            }

            Console.WriteLine("Bye bye !");
        }
    }
}