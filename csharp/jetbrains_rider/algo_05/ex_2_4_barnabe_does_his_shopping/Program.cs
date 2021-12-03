using System;

namespace ex_2_4_barnabe_does_his_shopping
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            float currentBarnabeMoney;
            int howManyStoreBarnabeDoesShopping;
            
            Console.WriteLine("Welcome to Barnabé Shopping Simulator!");
            currentBarnabeMoney = Helper.GetFloatFromUser("Enter the current money of Barnabé :");
            howManyStoreBarnabeDoesShopping = BarnabeeAlgorithm(currentBarnabeMoney);

            Console.WriteLine($"Barnabe does shopping to {howManyStoreBarnabeDoesShopping} stores !");
            Console.WriteLine("Bye bye!");
        }

        /// <summary>
        /// Get the numbers of store where Barnabé does his shopping.
        /// Following this statement (in french) :
        /// "Dans chacun, il a dépensé 1 euro de plus que la moitié de ce qu’il avait en entrant. Dans le dernier magasin, il dépense le solde."
        /// </summary>
        /// <param name="money">The initial money of Barnabé, has to be bigger than 1</param>
        /// <returns>How many stores Barnabé does his shopping</returns>
        private static int BarnabeeAlgorithm(float money)
        {
            int howManyStores;

            if (money <= 1)
            {
                throw new ArgumentException("The initial money of Barnabé has to be bigger than 1 euro");
            }
            
            howManyStores = 0;

            while (true)
            {
                if (money > (money / 2 + 1))
                {
                    money = money - (money / 2 + 1);
                    howManyStores++;
                }
                else
                {
                    // The last store, because his no more money
                    howManyStores++;
                    return howManyStores;
                }    
            }
        }
    }
}