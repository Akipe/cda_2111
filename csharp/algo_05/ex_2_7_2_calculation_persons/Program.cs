using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ex_2_7_2_calculation_persons
{
    internal static class Program
    {
        private const int HOW_MANY_AGES_NEEDED = 20;
        public static void Main(string[] args)
        {
            CounterAgePerson personCounter = new CounterAgePerson();;
            
            Console.WriteLine("Welcome to the age people calculation.");

            AddPeopleAgesFromUser(personCounter);
            
            if (personCounter.AreAllYoung())
            {
                Console.WriteLine("ALL PEOPLE ARE LESS THAN TWENTY YEARS OLD.");
            }
            else if (personCounter.AreAllTwentyYearsOldOrMore())
            {
                Console.WriteLine("ALL PEOPLE ARE MORE THAN TWENTY YEARS OLD.");
            }
            else
            {
                Console.WriteLine("Numbers of people with :");
                Console.WriteLine($"- 20 : {personCounter.GetHowManyYoungPeople()}");
                Console.WriteLine($"= 20 : {personCounter.GetHowManyTwentyYearsOldPeople()}");
                Console.WriteLine($"+ 20 : {personCounter.GetHowManyAdults()}");
            }
        }

        private static void AddPeopleAgesFromUser(CounterAgePerson counterPerson)
        {
            string userResponse;
            string[] entriesUserResponse;
            bool askAgain;
            
            do
            {
                askAgain = false;
                
                Console.WriteLine($"Please enter {HOW_MANY_AGES_NEEDED} ages of persons, separate with space :");
                Console.WriteLine("(Example : \"20 14 12 26 23 24 10 14...\")");

                try
                {
                    userResponse = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(userResponse))
                    {
                        askAgain = true;
                        throw new Exception($"Please enter a list of {HOW_MANY_AGES_NEEDED} ages.");
                    }
                    
                    entriesUserResponse = Program.GetEntriesFromUserDistanceAndOptionalUnit(userResponse);

                    if (entriesUserResponse.Length != HOW_MANY_AGES_NEEDED)
                    {
                        askAgain = true;
                        throw new Exception($"Please enter a list of {HOW_MANY_AGES_NEEDED} ages.");
                    }

                    for (int nbEntryAgePerson = 0; nbEntryAgePerson < HOW_MANY_AGES_NEEDED; nbEntryAgePerson++)
                    {
                        counterPerson.AddPerson(int.Parse(entriesUserResponse[nbEntryAgePerson]));
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error : {error.Message}");
                }
            } while (askAgain);
        }

        private static string[] GetEntriesFromUserDistanceAndOptionalUnit(string userResponse)
        {
            return userResponse.Trim().Split(" ");
        }
    }
}