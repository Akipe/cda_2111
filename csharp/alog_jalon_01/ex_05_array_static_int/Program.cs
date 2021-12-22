using System;

namespace ex_05_array_static_int
{
    internal static class Program
    {
        private const int MIN_INT_ARRAY_SIZE = 1;
        private const int MAX_INT_ARRAY_SIZE = 20;
        private const int MIN_NUMBER_IN_ARRAY = -50;
        private const int MAX_NUMBER_IN_ARRAY = 50;

        public static void Main(string[] _args)
        {
            // Uncomment for checking all exercices

            // Ex1();
            // Ex2();
            // Ex3();
            // Ex4();
            Ex5();
        }

        /// <summary>
        /// Exercice 1
        /// </summary>
        public static void Ex1()
        {
            int[] randomArrayGenerate;

            Console.WriteLine("\nExercice 1:\n");

            randomArrayGenerate = GenerateRandomIntsArray();

            Console.WriteLine($"Le tableau aléatoire a été généré avec une taille de {randomArrayGenerate.Length} :");
            foreach (int randomNumber in randomArrayGenerate)
            {
                Console.WriteLine(randomNumber);
            }
        }

        /// <summary>
        /// Exercice 1
        /// </summary>
        /// <returns></returns>
        public static int[] GenerateRandomIntsArray()
        {
            Random randomGenerator = new Random();
            int randomSizeArray;
            int[] randomArray;

            randomSizeArray = randomGenerator.Next(MIN_INT_ARRAY_SIZE, MAX_INT_ARRAY_SIZE + 1);
            randomArray = new int[randomSizeArray];

            for (int indexArray = 0; indexArray < randomSizeArray; indexArray++)
            {
                randomArray[indexArray] = randomGenerator.Next(MIN_NUMBER_IN_ARRAY, MAX_NUMBER_IN_ARRAY + 1);
            }

            return randomArray;
        }

        /// <summary>
        /// Exercice 2
        /// </summary>
        public static void Ex2()
        {
            int[] listNumbersUser;

            Console.WriteLine("\nExercice 2:\n");

            listNumbersUser = GenerateIntArrayFromUserInput();

            Console.WriteLine($"L'utilisateur a généré un tableau de {listNumbersUser.Length} nombres :");
            foreach (int number in listNumbersUser)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Exercice 2
        /// </summary>
        /// <returns></returns>
        public static int[] GenerateIntArrayFromUserInput()
        {
            const char NUMBER_SPLIT = '_';
            int userSizeArray;

            userSizeArray = AskUserOneNumber(
                "Veuillez enter la taille de votre tableau d'entier :",
                1,
                20);

            return AskUserMultipleNumbers(userSizeArray, NUMBER_SPLIT);
        }

        /// <summary>
        /// Exercice 2
        /// </summary>
        /// <param name="_message"></param>
        /// <param name="_minNumberAllow"></param>
        /// <param name="_maxNumberAllow"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private static int AskUserOneNumber(
            string _message,
            int _minNumberAllow = Int32.MinValue,
            int _maxNumberAllow = Int32.MinValue)
        {
            int userResonse;

            do
            {
                try
                {
                    Console.WriteLine(_message);
                    userResonse = int.Parse(Console.ReadLine());

                    if (userResonse < _minNumberAllow | userResonse > _maxNumberAllow)
                    {
                        throw new ApplicationException(
                            $"Veuillez enter un nombre entre {_minNumberAllow} et {_maxNumberAllow} compris.");
                    }

                    return userResonse;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Erreur : Veuillez entrer un nombre entier.");
                    Console.WriteLine(error.Message);
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine($"Erreur : {error.Message}");
                }
            } while (true);
        }

        /// <summary>
        /// Exercice 2
        /// </summary>
        /// <param name="_howManyNumbers"></param>
        /// <param name="_characterSplitNumbers"></param>
        /// <returns></returns>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="ApplicationException"></exception>
        private static int[] AskUserMultipleNumbers(int _howManyNumbers, char _characterSplitNumbers)
        {
            string userResponse;
            string[] listUserNumbersNotParse;
            int[] listUserNumbers = new int[_howManyNumbers];

            do
            {
                try
                {
                    Console.WriteLine(
                        $"Veuillez enter une liste de {_howManyNumbers} nombres, séparé par \"{_characterSplitNumbers}\":");
                    userResponse = Console.ReadLine().Trim();

                    if (string.IsNullOrWhiteSpace(userResponse))
                    {
                        throw new FormatException("Veuillez entrer des nombres");
                    }

                    listUserNumbersNotParse = userResponse.Split(_characterSplitNumbers);

                    if (listUserNumbersNotParse.Length < _howManyNumbers)
                    {
                        throw new ApplicationException($"Veuillez entrer au minimum {_howManyNumbers} nombres");
                    }

                    for (int indexNumber = 0; indexNumber < _howManyNumbers; indexNumber++)
                    {
                        listUserNumbers[indexNumber] = int.Parse(listUserNumbersNotParse[indexNumber]);
                    }

                    return listUserNumbers;
                }
                catch (FormatException error)
                {
                    Console.WriteLine($"Erreur : Veuillez enter des nombres, séparé par un {_characterSplitNumbers}.");
                    Console.WriteLine(error.Message);
                }
                catch (ApplicationException error)
                {
                    Console.WriteLine("Erreur : " + error.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Erreur : Veuillez enter des nombres, séparé par un {_characterSplitNumbers}.");
                }
            } while (true);
        }

        public static void Ex3()
        {
            Console.WriteLine("\nExercice 3:\n");

            ShowAllInformationOneLineAboutIntArray(GenerateRandomIntsArray());
        }

        /// <summary>
        /// Exerice 3
        /// </summary>
        /// <param name="_array"></param>
        public static void ShowAllInformationOneLineAboutIntArray(int[] _array)
        {
            Console.Write($"Vous avez saisi :");

            for (int indexNumber = 0; indexNumber < _array.Length; indexNumber++)
            {
                Console.Write($" {_array[indexNumber]}");
            }

            Console.Write($", ce qui fait un total de {_array.Length} valeurs \n");
        }

        /// <summary>
        /// exercice 4
        /// </summary>
        public static void Ex4()
        {
            int[] testArray;

            testArray = GenerateRandomIntsArray();
            // testArray = AskUserMultipleNumbers(2, '_');
            ShowAllInformationOneLineAboutIntArray(testArray);

            ShowInformationsAboutNumbersInArray(testArray);
        }

        /// <summary>
        /// exercice 4
        /// </summary>
        /// <param name="_array"></param>
        public static void ShowInformationsAboutNumbersInArray(int[] _array)
        {
            Console.Write(
                "La moyenne de votre tableau est : " +
                GetAverageNumbersFromArray(_array) +
                "\n");

            Console.Write(
                "Le minimum est : " +
                GetSmallestNumberInArray(_array) +
                "\n");

            Console.Write(
                "Le maximum est : " +
                GetBiggestNumberInArray(_array) +
                "\n");

            Console.Write(
                "L'écart entre le minimum et le maximum est : " +
                GetDifferenceFromMinAndMaxNumberInArray(_array) +
                "\n");
        }

        /// <summary>
        /// exercice 4
        /// </summary>
        /// <param name="_array"></param>
        /// <returns></returns>
        public static float GetAverageNumbersFromArray(int[] _array)
        {
            int additionAllNumbers = 0;

            foreach (int number in _array)
            {
                additionAllNumbers += number;
            }

            return (float) additionAllNumbers / (float) _array.Length;
        }

        /// <summary>
        /// exercice 4
        /// </summary>
        /// <param name="_array"></param>
        /// <returns></returns>
        public static int GetSmallestNumberInArray(int[] _array)
        {
            int currentSmallestNumber;

            currentSmallestNumber = _array[0];

            for (int indexNumber = 1; indexNumber < _array.Length; indexNumber++)
            {
                if (_array[indexNumber] < currentSmallestNumber)
                {
                    currentSmallestNumber = _array[indexNumber];
                }
            }

            return currentSmallestNumber;
        }

        /// <summary>
        /// exercice 4
        /// </summary>
        /// <param name="_array"></param>
        /// <returns></returns>
        public static int GetBiggestNumberInArray(int[] _array)
        {
            int currentSmallestNumber;

            currentSmallestNumber = _array[0];

            for (int indexNumber = 1; indexNumber < _array.Length; indexNumber++)
            {
                if (_array[indexNumber] > currentSmallestNumber)
                {
                    currentSmallestNumber = _array[indexNumber];
                }
            }

            return currentSmallestNumber;
        }

        /// <summary>
        /// exercice 4
        /// </summary>
        /// <param name="_array"></param>
        /// <returns></returns>
        public static int GetDifferenceFromMinAndMaxNumberInArray(int[] _array)
        {
            return GetBiggestNumberInArray(_array) - GetSmallestNumberInArray(_array);
        }

        /// <summary>
        /// Exercice 5
        /// </summary>
        public static void Ex5()
        {
            const char SPLIT_NUMBER = '_';
            int[] listNumbers;

            if (AskUserYesNoQuestion("Souhaitez-vous entrer jusqu'à 20 entiers séparés par le caractère \"" +
                                     SPLIT_NUMBER + "\" ?"))
            {
                listNumbers = AskUserListNumbersWithChoiceHowMany(
                    1,
                    20,
                    SPLIT_NUMBER);
            }
            else
            {
                listNumbers = GenerateRandomIntsArray();
            }

            ShowAllInformationOneLineAboutIntArray(listNumbers);
            ShowInformationsAboutNumbersInArray(listNumbers);
        }

        /// <summary>
        /// Exercice 5
        /// </summary>
        /// <param name="_minHowManyNumbers"></param>
        /// <param name="_maxHowManyNumbers"></param>
        /// <param name="_splitNumbers"></param>
        /// <returns></returns>
        private static int[] AskUserListNumbersWithChoiceHowMany(
            int _minHowManyNumbers,
            int _maxHowManyNumbers,
            char _splitNumbers)
        {
            return AskUserMultipleNumbers(
                AskUserOneNumber(
                    "Combien de nombres souhaitez-vous entrer ?",
                    _minHowManyNumbers,
                    _maxHowManyNumbers),
                _splitNumbers);
        }

        /// <summary>
        /// Exerice 5
        /// </summary>
        /// <param name="_questionMessage"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private static bool AskUserYesNoQuestion(string _questionMessage)
        {
            const string YES = "oui";
            const string NO = "non";
            string userResponse;

            do
            {
                try
                {
                    Console.WriteLine(_questionMessage + $" ({YES}/{NO})");
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