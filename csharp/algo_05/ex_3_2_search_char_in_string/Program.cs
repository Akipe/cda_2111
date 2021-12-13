using System;

namespace ex_3_2_search_char_in_string
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            string userSentence;
            char userCharToSearch;
            SimpleStringResearcher simpleStringResearcher;
            int howManyOccurence;
            
            Console.WriteLine("Welcome to char searcher !");
            
            Console.WriteLine("Please enter a sentence terminate with a point :");
            userSentence = Console.ReadLine();

            userCharToSearch = Helper.GetCharFromUser("Please enter a character to search :");
            
            Console.WriteLine();

            simpleStringResearcher = new SimpleStringResearcher(userSentence);
            howManyOccurence = simpleStringResearcher.GetHowMany(userCharToSearch);

            switch (howManyOccurence)
            {
                case -1:
                    Console.WriteLine("The string is empty.");
                    break;
                case 0:
                    Console.WriteLine("This character is not found on this sentence.");
                    break;
                default:
                    Console.WriteLine($"This character has been found {howManyOccurence} times.");
                    break;
            }
        }
    }
}