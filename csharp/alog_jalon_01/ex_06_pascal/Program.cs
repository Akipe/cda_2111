using System;
using System.Linq;

namespace ex_06_pascal
{
    internal static class Program
    {
        private const int MIN_PASCAL_LINE = 0;
        
        public static void Main(string[] _args)
        {
            Ex1();
            Ex2();
        }

        /// <summary>
        /// Exerice 1
        /// </summary>
        public static void Ex1()
        {
            ShowTenPascalLines();
        }

        /// <summary>
        /// Exercice 1
        /// </summary>
        public static void ShowTenPascalLines()
        {
            for (int pascalLine = MIN_PASCAL_LINE; pascalLine < 10; pascalLine++)
            {
                ShowTerminalPascalLine(pascalLine);
            }
        }

        /// <summary>
        /// Exercice 1
        /// </summary>
        /// <param name="_whichLine"></param>
        public static void ShowTerminalPascalLine(int _whichLine)
        {
            int[] pascalLine;

            pascalLine = GetPascalLine(_whichLine);
            foreach (int numberInLine in pascalLine)
            {
                Console.Write(numberInLine + " ");
            }

            Console.WriteLine();
        }

        public static void ShowTerminalPascalLineFromExistingArray(int[] _pascalLine)
        {
            foreach (int number in _pascalLine)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static void Ex2()
        {
            int[] pascalLineAskByUser;

            pascalLineAskByUser = AskUserWhichPascalLineToGet();
            
            ShowTerminalPascalLineFromExistingArray(pascalLineAskByUser);
        }

        /// <summary>
        /// Exercice 2 (& 1)
        /// </summary>
        /// <param name="_whichLine"></param>
        /// <returns></returns>
        public static int[] GetPascalLine(int _whichLine)
        {
            int[] resultPascalLineBeforeThis;
            int[] resultPascalLine;

            if (_whichLine < MIN_PASCAL_LINE)
            {
                throw new ApplicationException($"Veuillez enter au minimum \"{MIN_PASCAL_LINE}\" ligne à afficher.");
            }

            if (_whichLine == MIN_PASCAL_LINE)
            {
                return new int[] {1};
            }

            resultPascalLineBeforeThis = GetPascalLine(_whichLine - 1);

            resultPascalLine = new int[resultPascalLineBeforeThis.Length + 1];

            for (int numberIndex = 0; numberIndex < resultPascalLine.Length; numberIndex++)
            {
                int numberLastLineSameIndex;
                int numberLastLineIndexBefore;

                // If first number of line, can't get the number of index -1 of line before
                // --> x 1      (line 1)
                //       ?  2   (line 2)
                if (numberIndex == 0)
                {
                    numberLastLineIndexBefore = 0;
                }
                else
                {
                    numberLastLineIndexBefore = resultPascalLineBeforeThis[numberIndex - 1];
                }

                // If latest number of line, can't get the number of same index of line before
                // ... 1  x  <--
                // ... 4  ?
                if (numberIndex == resultPascalLine.Length - 1)
                {
                    numberLastLineSameIndex = 0;
                }
                else
                {
                    numberLastLineSameIndex = resultPascalLineBeforeThis[numberIndex];
                }

                resultPascalLine[numberIndex] =
                    numberLastLineIndexBefore + numberLastLineSameIndex;
            }

            return resultPascalLine;
        }

        public static int[] AskUserWhichPascalLineToGet()
        {
            int whichLineToGet;

            whichLineToGet = AskUserNumber("Entrer le numéro de ligne du triangle de pascal à afficher :",
                MIN_PASCAL_LINE);

            return GetPascalLine(whichLineToGet);
        }

        private static int AskUserNumber(
            string _message,
            int _minNumberAllow = Int32.MinValue,
            int _maxNumberAllow = Int32.MaxValue)
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
    }
}