 using System;

namespace ex_03_saterday_day
{
    class Program
    {
        private static bool _hasBeenWithFriends;
        private static bool _hasTakeCarePlants;
        private static bool _hasPlayWithFriends;
        private static bool _hasMakeSkies;
        
        static void Main(string[] _args)
        {
            Program._hasBeenWithFriends = false;
            Program._hasTakeCarePlants = false;
            Program._hasPlayWithFriends = false;
            Program._hasMakeSkies = false;
            
            // La matinée
            Console.WriteLine("Le soleil se léve, les citoyens se révéille, la matiné du samedi commence...");
            Console.WriteLine("Je me prépare à organiser ma journée...");
            
            // Sacs vides
            Console.WriteLine("Je vais faire les courses.");
            if (!AskUserYesNoQuestion("Est ce que mes sacs de courses sont vides ?"))
            {
                Console.WriteLine("Je vide mes sacs rapidement.");
            }
            Console.WriteLine("Je prend mes sacs.");
            Console.WriteLine("Je pars au magasin.");
            
            // Courses
            Console.WriteLine("Je prend quelques articles au magasins");
            while (!AskUserYesNoQuestion("Ai-je pris tous les articles dont j'ai besoin ?"))
            {
                Console.WriteLine("Je prend l'article qui me manque...");
            }
            Console.WriteLine("Je passe à la caisse et régle mes courses.");
            Console.WriteLine("Je rentre chez moi et range mes courses.");
            
            // Activité extérieur matin
            // Temps beau
            if (AskUserYesNoQuestion("Est ce qu'il fait beau ?"))
            {
                Console.WriteLine("Je vais me promener le long de la rivière...");
                if (AskUserYesNoQuestion("Est ce que je me sens en forme pour faire du sport et me suis-je assez échauffé sur le chemin?"))
                {
                    Console.WriteLine("Je profite des installations sportives pour faire un peu de sport.");
                }
                else
                {
                    Console.WriteLine("Je me contente d'observer la faune encore présente");
                }
                Console.WriteLine("Je rentre chez moi");
                
                EatSomethingAtHome();
                ActivitiesAfternoon();
                ActivityDiner();
            }
            // Activité extérieur matin
            // Neige
            else if (AskUserYesNoQuestion("Est ce qu'il a neigé la veille et reste t'il assez de neige pour en profiter ?"))
            {
                Console.WriteLine("Cool, je vais pouvoir en profiter pour faire du ski");
                
                Console.WriteLine("Je prend mes gants, mon bonnet et mon écharpe.");
                
                if (!AskUserYesNoQuestion("Ma voiture était-elle au garage cette nuit ?"))
                {
                    Console.WriteLine("Je prend ma pelle à neige en plus et dégage ma voiture");
                }
                
                Console.WriteLine("Je parts en montagne faire du ski pour la journée, trop bien !");
                
                if (AskUserYesNoQuestion("Ai-je besoin de louer de l'équipement pour faire du ski ?"))
                {
                    Console.WriteLine("Je loue l'équipement qui me faut.");
                }
                
                Console.WriteLine("Je fais quelques descentes de skies...");
                
                // Midi, l'heure du repas au ski
                Console.WriteLine("Je recherche un restaurant pour manger...");
                while (!AskUserYesNoQuestion("Ai-je trouvé un restaurant pour manger ce midi ?"))
                {
                    Console.WriteLine("Je continue à chercher un restaurant, parce que j'ai très faim...");
                }
                Console.WriteLine("J'ai trouvé un restaurant!");
                while (!AskUserYesNoQuestion("Le restautant a t-il une place de libre ?"))
                {
                    Console.WriteLine("Je refais la même piste pour voir si une place se libére...");
                }
                Console.WriteLine("Je rentre dans le restaurant et mange un repas.");
                Console.WriteLine("C'était très bon!");
                
                // ski jusqu'à la fermeture
                Console.WriteLine("Je retourne skier sur les pistes...");
                while (!AskUserYesNoQuestion("Est ce que j'ai dépassé l'heure de fermeture des pistes de ski ?"))
                {
                    Console.WriteLine("Cool, je refais une descente.");
                }
                Console.WriteLine("C'était une bonne journée! je rentre chez moi.");

                Program._hasMakeSkies = true;
                ActivityDiner();
            }
            // Activité extérieur matin
            // Temps nuageux
            else
            {
                Console.WriteLine("Le temps est alors nuageux, pluvieux, ou il ne reste pas assez de neige pour en profiter.");
                Console.WriteLine("Je vais rester chez moi, bien au chaud.");
                // Avoir chaux
                if (AskUserYesNoQuestion("Ai-je envie de préparer un feu de cheminé ?"))
                {
                    Console.WriteLine("J'allume le feu de cheminé.");
                }
                else if (AskUserYesNoQuestion("Ai-je envie d'un café ?"))
                {
                    Console.WriteLine("Je prend un café, ça fait du bien et ça reveil.");
                }
                else
                {
                    Console.WriteLine("Je prend un thé, ça me permet de me reposer un peu.");
                }
                
                // Activité au chaud
                Console.WriteLine("Tien, ça serait bien de regarder une petite serie...");
                if (AskUserYesNoQuestion("Est ce que ma connexion internet fonctionne correctement ?"))
                {
                    Console.WriteLine("Je continue de regarder ma serie préféré.");
                }
                else
                {
                    Console.WriteLine("Je me pose tranquille pour lire le livre de mon auteur préféré.");
                }
                
                EatSomethingAtHome();
                ActivitiesAfternoon();
                ActivityDiner();
            }
            
            Console.WriteLine("C'était une belle journée , bonne nuit!");
        }

        static void ActivityDiner()
        {
            if (Program._hasBeenWithFriends)
            {
                Console.WriteLine("On se fait un super resto, trop bien !");
            }

            if (Program._hasTakeCarePlants)
            {
                Console.WriteLine("Je me suis préparer un festin de roi!");
                Console.WriteLine("Je vais même proposer à ma famille de venir manger chez moi ce soir");
                if (AskUserYesNoQuestion("Est-ce qu'ils peuvent venir ?"))
                {
                    Console.WriteLine("Cool, on mange tous ensemble en famille :)");
                }
                else
                {
                    Console.WriteLine("C'est pas grave, comme ça je mange tranquillement tout seul");
                }
            }

            if (Program._hasPlayWithFriends)
            {
                Console.WriteLine("Mince, on est déjà le soir ?");
                Console.WriteLine("Je me prépare un casse croute rapide.");
            }

            if (Program._hasMakeSkies)
            {
                Console.WriteLine("Je suis très fatigué du ski.");
                Console.WriteLine("Je me fait un repas rapidement avant de me reposer.");
            }
        }
        static void ActivitiesAfternoon()
        {
            if (AskUserYesNoQuestion("Est-ce que mes amis sont disponibles ?"))
            {
                if (AskUserYesNoQuestion("Est ce qu'ils peuvent sortir avec moi ?"))
                {
                    Console.WriteLine("Cool, on passe l'après midi ensemble.");
                    Program._hasBeenWithFriends = true;
                }
                else
                {
                    Console.WriteLine("C'est pas grave, on va se faire une partie de LOL en ligne ;)");
                    Program._hasPlayWithFriends = true;
                }
            }
            else
            {
                Console.WriteLine("Tanpis, je vais m'occuper de mes plantes, je dois me débarrasser de ces cochenilles !!!");
                Program._hasTakeCarePlants = true;
            }
        }
        

        /// <summary>
        /// Midi, l'heure du repas à la maison
        /// </summary>
        static void EatSomethingAtHome()
        {
            Console.WriteLine("Je suis chez moi, je vais me faire un truc à manger...");

            if (AskUserYesNoQuestion("Suis-je motiver pour faire un super bon repas ?"))
            {
                Console.WriteLine("Je me prépare un repas avec des : petits pois, purée de carottes et un steak. Miam");
            }
            else
            {
                Console.WriteLine(
                    "C'est le weekend, tranquille :\n" +
                    "je prépare un sandwitch rapidement avec salade, tomate, cornichon, oeufs durs, jambon et beurre"
                    );
            }
        }

        static bool AskUserYesNoQuestion(string _questionMessage)
        {
            const string YES = "oui";
            const string NO = "non";
            string userResponse;

            do
            {
                try
                {

                    Console.WriteLine(_questionMessage + $" ({YES}/{NO}, seulement)");
                    userResponse = Console.ReadLine().Trim().ToLower();

                    if (userResponse.Equals(YES))
                    {
                        return true;
                    }
                    if (userResponse.Equals(NO))
                    {
                        return false;
                    }

                    throw new ApplicationException($"Veuillez entrer comme réponse uniquement \"{YES}\" ou \"{NO}\" !");
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