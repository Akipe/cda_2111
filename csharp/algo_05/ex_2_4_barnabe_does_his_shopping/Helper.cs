using System;

namespace ex_2_4_barnabe_does_his_shopping
{
    public static class Helper
    {
        public static float GetFloatFromUser(string message)
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
                    return float.Parse(userInput);
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