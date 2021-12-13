using System;

namespace ex_1_5_interest_calculation
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            float currentMoneyOnAccount;
            int interestBankInPercent;
            int howManyYearsPlacement;
            float simpleInterestAcquired;
            float complexInterestAcquired;
            
            Console.WriteLine("Welcome to the interest calculator.");
            currentMoneyOnAccount = Helper.GetFloatFromUser("Please enter your current money on your account :");
            interestBankInPercent =
                Helper.GetIntFromUser(
                    "Please enter the interest of the bank (value in percent, for example enter \"5\" for 5 percent.) :");
            howManyYearsPlacement =
                Helper.GetIntFromUser("Please enter how many years you leave your money in your account :");

            simpleInterestAcquired =
                GetSimpleInterest(currentMoneyOnAccount, interestBankInPercent, howManyYearsPlacement);
            
            Console.WriteLine($"You will earn with simple interest {simpleInterestAcquired} $");
            
            complexInterestAcquired =
                GetComplexInterest(currentMoneyOnAccount, interestBankInPercent, howManyYearsPlacement);
            
            Console.WriteLine($"You will earn with complex interest {complexInterestAcquired} $");

        }

        private static float GetSimpleInterest(float currentMoneyAccount, int interestInPercent, int howManyYearsPlacement)
        {
            return (currentMoneyAccount * ( 1 + (float) howManyYearsPlacement * ((float) interestInPercent / 100))) - currentMoneyAccount;
        }

        private static float GetComplexInterest(float currentMoneyAccount, int interestInPercent, int howManyYearsPlacement)
        {
            return (currentMoneyAccount * MathF.Pow((1 + ((float) interestInPercent / 100)), (float) howManyYearsPlacement)) - currentMoneyAccount;
        }
    }
}