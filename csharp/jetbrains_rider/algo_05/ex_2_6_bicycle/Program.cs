using System;

namespace ex_2_6_bicycle
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // If the weather is good
            if (AskUser("Is the weather is good ?"))
            {
                Console.WriteLine("I try my bike...");
                
                // If the bicycle is in good shape
                if (AskUser("If the bibcyle is in good shape ?"))
                {
                    // I will ride my bike
                    Console.WriteLine("I will ride my bike.");
                }
                // But if bicycle is not in good shape
                else
                {
                    Console.WriteLine("The bicycle needs to be repair.");
                    
                    // If repairs are fast
                    if (AskUser("Is repairs are fast ?"))
                    {
                        // I will ride my bike
                        Console.WriteLine("I will ride the bike after the repairs.");
                    }
                    else
                    {
                        // I will walk
                        Console.WriteLine("I will walk.");
                    }
                }
            }
            // Else if the weather is not good, i will read the book Game of Thrones
            else
            {
                Console.WriteLine("I will read a book.");
                
                // If I have the book
                if (AskUser("Do I have the book Game of Thrones ?"))
                {
                    // I take the book GOT
                    Console.WriteLine("I take the book.");
                }
                // Else I haven't the book
                else
                {
                    // If the library owns the book
                    if (AskUser("Does the library has the book Game of Thrones ?"))
                    {
                        // I borrow GOT
                        Console.WriteLine("I borrow the book Game of Thrones.");
                    }
                    // Else the library doesn't owns the book
                    else
                    {
                        // I borrow a detective story book
                        Console.WriteLine("I borrow a detective story book.");
                    }
                    // I go back home
                    Console.WriteLine("I go back home with the book...");
                }
                
                // I will sit and read the book
                Console.WriteLine("I will sit and read the book...");
            }
            
            Console.WriteLine("I spent a beautiful day !");
            Console.WriteLine("Bye bye!");
        }

        private static bool AskUser(string askMessage)
        {
            string userResponse;

            do
            {
                try
                {
                    Console.WriteLine(askMessage + " (\"yes\" or \"no\")");
                    userResponse = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(userResponse))
                    {
                        throw new ApplicationException("You must enter a response.");
                    }
                
                    switch (userResponse.Trim().ToLower())
                    {
                        case "yes": return true;
                        case "no": return false;
                        default: throw new ApplicationException("Your response is invalid.");
                    }
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine($"Error : {error.Message}\n Please enter \"yes\" or \"no\"");
                }
                
            } while (true);
        }
    }
}