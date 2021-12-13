using System;

namespace ex_3_2_search_char_in_string
{
    public static class Helper
    {
        public static char GetCharFromUser(string _message)
        {
            string userInput;
            
            do
            {
                Console.WriteLine(_message);

                try
                {
                    userInput = Console.ReadLine();
                    if (userInput == null)
                    {
                        throw new ArgumentException("Please enter a character !");
                    }

                    if (userInput.Length > 1)
                    {
                        throw new ArgumentException("Please enter only one character !");
                    }
                    
                    return userInput[0];
                }
                catch (FormatException error)
                {
                    Console.WriteLine($"Error: please enter a correct character ({error.Message})");
                }
                catch (ArgumentNullException error)
                {
                    Console.WriteLine($"Error: please enter a character ({error.Message})");
                }
            } while (true);
        }
    }
}