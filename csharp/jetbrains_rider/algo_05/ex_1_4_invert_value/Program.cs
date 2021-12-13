using System;

namespace ex_1_4_invert_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int tempStorage;
            
            Console.WriteLine("Welcome !");
            
            firstNumber = Helper.GetIntFromUser("Please enter the first number :");
            secondNumber = Helper.GetIntFromUser("Please enter the second number :");

            tempStorage = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempStorage;
            
            Console.WriteLine($"Now the first number is {firstNumber} and the second number is {secondNumber}");
            Console.WriteLine("Bye bye !");
        }
    }
}