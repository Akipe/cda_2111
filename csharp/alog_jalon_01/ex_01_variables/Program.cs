using System;

namespace ex_01_variables
{
    class Program
    {
        static void Main(string[] _args)
        {
            const string MY_LAST_NAME = "MILLETRE";
            const string MY_FIRST_NAME = "Julien";
            const int MY_AGE = 29;
            const int YEAR_TO_CHECK = 2000;

            int? userAge;
            bool userHasNotCorrectAge = true;
            
            Console.WriteLine($"Hello World! I am Mister {MY_FIRST_NAME} {MY_LAST_NAME}, and I am {MY_AGE}.");

            do
            {
                try
                {
                    Console.WriteLine("What is your age ?");

                    userAge = int.Parse(Console.ReadLine());

                    if (userAge < 1)
                    {
                        throw new Exception("Please enter a correct age (>0)");
                    }

                    if (userAge > 120)
                    {
                        Console.WriteLine("You are a super hero!");
                    }

                    if (DateTime.Today.Year - userAge >= YEAR_TO_CHECK)
                    {
                        Console.WriteLine($"You are born after {YEAR_TO_CHECK}.");
                    }
                    else
                    {
                        Console.WriteLine($"You are born before {YEAR_TO_CHECK}.");
                    }

                    userHasNotCorrectAge = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error : Please enter a correct number : {error.Message}");
                }
            } while (userHasNotCorrectAge);
        }
    }
}