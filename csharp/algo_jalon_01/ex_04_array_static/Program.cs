using System;

namespace ex_04_array_static
{
    internal static class Program
    {
        private const string YES = "vrai";
        private const string NO = "faux";

        private static string[] _userQuestions = new string[6]
        {
            "Avez-vous votre permis voiture ?",
            "Aimez-vous faire du ping-pong ?",
            "Avez-vous des enfants ?",
            "Avez vous passé un samedi surchargé ?",
            "Les carottes sont cuites ?",
            "Avez vous 42 ans ?"
        };
        private static bool[] _userResponses = new bool[6];
            
        static void Main(string[] _args)
        {
            Program.AskSixQuestionsToUser();
            Program.ShowSixUserResponses();
        }

        private static void AskSixQuestionsToUser()
        {
            Console.WriteLine($"Répondez aux questions suivantes par {Program.YES} ou {Program.NO} :");

            for (int indexQuestion = 0; indexQuestion < Program._userQuestions.Length; indexQuestion++)
            {
                Program._userResponses[indexQuestion] = AskUserYesNoQuestion(Program._userQuestions[indexQuestion]);
            }
        }

        private static void ShowSixUserResponses()
        {
            Console.WriteLine("Voici les réponses aux questions :");
            
            for (int indexQuestion = 0; indexQuestion < Program._userQuestions.Length; indexQuestion++)
            {
                Console.WriteLine(
                    $"{Program._userQuestions[indexQuestion]}" +
                    $" Vous avez répondu " +
                    $"\"{Program.ConvertBoolToString(Program._userResponses[indexQuestion])}\"");
            }
        }

        private static string ConvertBoolToString(bool _boolean)
        {
            return _boolean == true ? Program.YES : Program.NO;
        }
        
        private static bool AskUserYesNoQuestion(string _questionMessage)
        {
            string userResponse;

            do
            {
                try
                {

                    Console.WriteLine(_questionMessage + $" ({YES}/{NO})");
                    userResponse = Console.ReadLine().Trim().ToLower();

                    if (userResponse.Equals(Program.YES))
                    {
                        return true;
                    }
                    if (userResponse.Equals(Program.NO))
                    {
                        return false;
                    }
                    
                    throw new ApplicationException($"Veuillez entrer comme réponse uniquement \"{Program.YES}\" ou \"{Program.NO}\" !");
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine("Erreur : " + error.Message);
                }
                catch (Exception error)
                {
                    Console.WriteLine("Erreur : " + error.Message);
                }
            } while (true);
        }
    }
}