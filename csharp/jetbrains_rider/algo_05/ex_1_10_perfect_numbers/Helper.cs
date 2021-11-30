using System;

namespace ex_1_10_perfect_numbers
{
    public class Helper
    {
        public static int GetIntFromUser(string message)
        {
            string userInput;
            
            do
            {
                Console.WriteLine(message);

                try
                {
                    userInput = Console.ReadLine();
                    if (userInput == null)
                    {
                        throw new ArgumentException();
                    }
                    return int.Parse(userInput);
                }
                catch (FormatException error)
                {
                    Console.WriteLine($"Error: please enter a correct number ({error.Message})");
                }
                catch (ArgumentNullException error)
                {
                    Console.WriteLine($"Error: please enter a number ({error.Message})");
                }
            } while (true);
        }
    }
}