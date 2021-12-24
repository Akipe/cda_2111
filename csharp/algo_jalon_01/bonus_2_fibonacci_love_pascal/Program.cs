using System;

namespace bonus_2_fibonacci_love_pascal
{
    class Program
    {
        static void Main(string[] _args)
        {
            int userFibonacciNumberWanted = AskUserNumber("Veuillez entrer le nombre de Fibonacci voulu :", 0);
            
            Console.WriteLine($"Pour le nombre numéro {userFibonacciNumberWanted} : {GetFibonnaciNumber(userFibonacciNumberWanted)}");
        }

        public static int GetFibonnaciNumber(int _whichFibonacciNumber)
        {
            int[][] pascalLinesNeedForCalculate;
            int howManyPascalLinesNeeded;

            howManyPascalLinesNeeded = GetHowManyPascalLinesNeedForCalculateFibonacci(_whichFibonacciNumber);
            pascalLinesNeedForCalculate = GetPascalLinesNeededForCalculateFibonacci(_whichFibonacciNumber, howManyPascalLinesNeeded);
            return GetFibonacciAdditionFromPascalLines(pascalLinesNeedForCalculate);
        }

        private static int GetHowManyPascalLinesNeedForCalculateFibonacci(int _whichFibonacciNumber)
        {
            /*
             * X fibo number | how many lines pascal
             *          0           1
             *          1           1
             *          2           2
             *          3           2
             *          4           3
             *          5           2
             *          6           4
             *              ....
             *  So we can :
             *  for "pair" numbers :
             *      x / 2 + 1 = lines pascal
             *      4 / 2 + 1 = 3
             *  for "impair" numbers :
             *      remove 1 to number and do same as "pair"
             */
            if (_whichFibonacciNumber < 0)
            {
                throw new ApplicationException("You need to define 0 or more fibonacci numbers");
            }

            if (_whichFibonacciNumber < 2)
            {
                return 1;
            }

            if (_whichFibonacciNumber % 2 == 1)
            {
                _whichFibonacciNumber--;
            }

            return _whichFibonacciNumber / 2 + 1;
        }

        private static int[][] GetPascalLinesNeededForCalculateFibonacci(int _whichFibonacciNumber, int _howManyLines)
        {
            int[][] pascalLinesNeedForCalculate;

            pascalLinesNeedForCalculate = new int[_howManyLines][];

            for (int indexLine = 0; indexLine < _howManyLines; indexLine++)
            {
                pascalLinesNeedForCalculate[indexLine] = GetPascalLine(_whichFibonacciNumber - indexLine);
            }

            return pascalLinesNeedForCalculate;
        }

        private static int GetFibonacciAdditionFromPascalLines(int[][] _pascalLines)
        {
            int fibonacciAddition = 0;
            
            for (int pascalLineIndex = 0; pascalLineIndex < _pascalLines.Length; pascalLineIndex++)
            {
                fibonacciAddition += _pascalLines[pascalLineIndex][pascalLineIndex];
            }

            return fibonacciAddition;
        }

        public static int[] GetPascalLine(int _whichLine)
        {
            const int MIN_PASCAL_LINE = 0;

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