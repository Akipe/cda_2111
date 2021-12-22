using System;

namespace ex_02_month_birthday
{
    class Program
    {
        static void Main(string[] _args)
        {
            string[] monthsName = new string[]
            {
                "Janvier",
                "Février",
                "Mars",
                "Avril",
                "Mai",
                "Juin",
                "Juillet",
                "Aout",
                "Septembre",
                "Octobre",
                "Novembre",
                "Decembre"
            };
            int userMonthBirthday = 0;
            bool askAgainUser;
            
            do
            {
                askAgainUser = false;
                
                try
                {
                    Console.WriteLine("Please enter the number of you month birthday  :");
                    userMonthBirthday = int.Parse(Console.ReadLine());

                    if (userMonthBirthday < 1 | userMonthBirthday > 12)
                    {
                        throw new ApplicationException(
                            $"{userMonthBirthday} is not a correct month." +
                            $"\nPlease enter a correct month number (between 1 and 12)");
                    }
                }
                catch (FormatException error)
                {
                    Console.WriteLine($"Error : please enter a correct number ({error.Message})");
                    askAgainUser = true;
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine($"Error : {error.Message}");
                    askAgainUser = true;
                }
            } while (askAgainUser);

            for (int numberMonth = 1; numberMonth <= monthsName.Length; numberMonth++)
            {
                if (numberMonth == userMonthBirthday)
                {
                    Console.WriteLine($"\"{monthsName[numberMonth - 1]}\" (in french sorry) is the {numberMonth} month of the year !");
                }
            }
        }
    }
}