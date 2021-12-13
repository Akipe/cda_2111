using System;

namespace ex_2_5_game_0_1_2
{

    enum GameChoice: int
    {
        GiveUp = -1,
        Zero = 0,
        One = 1,
        Two = 2
    }

    enum Player
    {
        Nobody,
        User,
        Computer
    }
    
    internal static class Program
    {
        private const int MinimalNumber = (int) GameChoice.Zero;
        private const int MaximalNumber = (int) GameChoice.Two;
        private const int HowManyPointToWin = 10;
        
        public static void Main(string[] args)
        {
            GameChoice userChoice;
            GameChoice computerChoise;
            GameChoice resultRound;
            Player user;
            Player computer;
            Player winTheRound;
            Player playerBiggerNumber;
            Player playerLowerNumber;
            int userPoint;
            int computerPoint;
            
            Console.WriteLine("Welcome to the 0 - 2 Game.");
            Console.WriteLine($"You have to choose a number : {GameChoice.Zero}, {GameChoice.One} or {GameChoice.Two}.");
            Console.WriteLine("The computer will choose a random number.");
            Console.WriteLine("If the difference between your choice and the computer is :");
            Console.WriteLine("- 2 : the player who has choice the bigger number win a point.");
            Console.WriteLine("- 1 : the player who has choice the lower number win a point.");
            Console.WriteLine("- 0 : nobody win a point.");
            Console.WriteLine($"The game ends when a player has {HowManyPointToWin} points or when the human player stop to play by entering a negative number.");

            userPoint = 0;
            computerPoint = 0;
            user = Player.User;
            computer = Player.Computer;
            
            do
            {
                userChoice = GetUserNumber();

                if (userChoice == GameChoice.GiveUp)
                {
                    Console.WriteLine("You choose to give up, the computer win !");
                    ExitApplication();
                }
                
                computerChoise = GetComputerNumber();
                Console.WriteLine($"\nThe computer has enter : {(int) computerChoise}");
                
                playerBiggerNumber = WhichPlayerHasBiggerNumber(user, userChoice, computer, computerChoise);
                playerLowerNumber = WhichPlayerHasLowerNumber(user, userChoice, computer, computerChoise);
                
                resultRound = GetResultRound(userChoice, computerChoise);
                winTheRound = WhoWinsTheRound(resultRound, playerBiggerNumber, playerLowerNumber);

                Console.WriteLine($"The result is {(int) resultRound}.\n");
                
                if (winTheRound == user)
                {
                    Console.WriteLine("The user win the round !");
                    userPoint++;
                }
                else if (winTheRound == computer)
                {
                    Console.WriteLine("The computer win the round !");
                    computerPoint++;
                }
                else
                {
                    Console.WriteLine("Nobody win the round !");
                }

                Console.WriteLine($"\nThe user has {userPoint} points.");
                Console.WriteLine($"The computer has {computerPoint} points.");

            } while (userPoint < HowManyPointToWin & computerPoint < HowManyPointToWin);

            if (userPoint == HowManyPointToWin)
            {
                Console.WriteLine("Congratulation ! You win the game !");
            }
            else
            {
                Console.WriteLine("Oh dear, the computer wins :s");
            }
            
            ExitApplication();
        }
        
        private static GameChoice GetUserNumber()
        {
            int userNumber;

            do
            {
                try
                {
                    userNumber = Helper.GetIntFromUser("\nPlease enter a number (0, 1 or 2) : ");

                    if (IsUserChoiceGivesUp(userNumber))
                    {
                        return GameChoice.GiveUp;
                    }

                    if (userNumber > Program.MaximalNumber)
                    {
                        throw new ArgumentException(
                            "Please enter a number between 0 and 3, or negative if you want to stop");
                    }

                    return (GameChoice) userNumber;
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine($"Error : {error.Message}");
                    Console.WriteLine($"Please retry to enter a number.");
                }
            } while (true);
        }

        private static GameChoice GetComputerNumber()
        {
            return  (GameChoice) new Random().Next(
                MinimalNumber,
                MaximalNumber + 1);
        }

        private static GameChoice GetResultRound(GameChoice firstPlayerChoice, GameChoice secondPlayerChoice)
        {
            return (GameChoice) Math.Abs((int) firstPlayerChoice - (int) secondPlayerChoice);
        }

        private static bool IsUserChoiceGivesUp(int userChoice)
        {
            return userChoice < Program.MinimalNumber;
        }

        private static void ExitApplication()
        {
            Console.WriteLine("Bye bye !");
            Environment.Exit(0);
        }

        private static Player WhichPlayerHasBiggerNumber(Player player1, GameChoice player1Choice, Player player2, GameChoice player2Choice)
        {
            if (player1Choice > player2Choice)
            {
                return player1;
            }

            return player2;
        }
        
        private static Player WhichPlayerHasLowerNumber(Player player1, GameChoice player1Choice, Player player2, GameChoice player2Choice)
        {
            if (player1Choice < player2Choice)
            {
                return player1;
            }

            return player2;
        }

        private static Player WhoWinsTheRound(GameChoice result, Player playerBiggerNumber, Player playerLowerNumber)
        {
            if (result == GameChoice.Two)
            {
                return playerBiggerNumber;
            }

            if (result == GameChoice.One)
            {
                return playerLowerNumber;
            }

            return Player.Nobody;
        }
    }
}