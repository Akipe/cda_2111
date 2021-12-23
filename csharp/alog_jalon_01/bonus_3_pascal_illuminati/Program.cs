using System;

namespace bonus_3_pascal_illuminati
{
    class Program
    {
        public static void Main(string[] _args)
        {
            //DrawIlluminatiPascal(2);
            DrawIlluminatiPascal(100);
        }

        public static void DrawIlluminatiPascal(int _howManyLines)
        {
            //int[][] illuminatiPascal2D = new int[_howManyLines + 1][];
            // int[] currentHorizontalLineDraw = new int[maxSizeHorizontalLine];
            int maxSizeHorizontalLine = GetSizeHorizontalLine(_howManyLines);
            ulong[] currentPascalLine;
            int indexToBeginDraw;
            
            // Horizontal lines begin to top
            for (int indexLineHorizontal = 0; indexLineHorizontal <= _howManyLines; indexLineHorizontal++)
            {
                currentPascalLine = GetPascalLine(indexLineHorizontal);
                indexToBeginDraw = GetIndexToBeginDrawNumbers(maxSizeHorizontalLine, currentPascalLine.Length);
                
                DrawOneLinePascal(currentPascalLine, maxSizeHorizontalLine, indexToBeginDraw);
            }
        }

        public static char GetFirstDigitNumbersOrEvenOddLetter(ulong _numberToConvert)
        {
            // Error when negative numbers
            if (_numberToConvert < 0)
            {
                throw new ArgumentException("Please enter only positive numbers");
            }

            // Return all digit numbers
            if (_numberToConvert <= 9)
            {
                return (char) (_numberToConvert + 48);
            }

            return _numberToConvert % 2 == 0 ? 'P' : 'I';
        }

        public static int GetMiddleHorizontalLine(int _lineSize)
        {
            return (int) _lineSize / 2 + 1;
        }
        
        /*
         *      0 1 2 3 4 5 6
         *    0       x
         *    1   x   x   x
         *    2
         *  Calculate : index middle of all horizontal line - how many pascal numbers
         *          = index to begin draw
         */
        public static int GetIndexToBeginDrawNumbers(int _allLineSize, int _howManyPascalNumbersInCurrentLine)
        {
            return GetMiddleHorizontalLine(_allLineSize) - _howManyPascalNumbersInCurrentLine;
        }
        public static int GetSizeHorizontalLine(int _howManyLines)
        {
            return _howManyLines + (_howManyLines - 2);
        }

        public static void DrawOneLinePascal(ulong[] _pascalNumbers, int _sizeHorizontalLine, int _indexToBeginDraw)
        {
            WriteBlankSpaces(_indexToBeginDraw);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            for (int indexPixelPascal = 0; indexPixelPascal < _pascalNumbers.Length; indexPixelPascal++)
            {
                SetTerminalOutputColorFromNumbers(_pascalNumbers[indexPixelPascal]);
                
                Console.Write(GetFirstDigitNumbersOrEvenOddLetter(_pascalNumbers[indexPixelPascal]));
                
                ResetTerminalOutputColor();
                
                if (indexPixelPascal != _pascalNumbers.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            
            WriteBlankSpaces(_indexToBeginDraw);
            
            Console.Write("\n");
        }

        public static void SetTerminalOutputColorFromNumbers(ulong _number)
        {
            if (_number % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                ResetTerminalOutputColor();
            }
        }

        public static void ResetTerminalOutputColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteBlankSpaces(int _indexToBeginDraw)
        {
            for (int indexPixelBlankBefore = 0; indexPixelBlankBefore < _indexToBeginDraw; indexPixelBlankBefore++)
            {
                Console.Write(" ");
            }
        }

        public static ulong[] GetPascalLine(int _whichLine)
        {
            const int MIN_PASCAL_LINE = 0;

            ulong[] resultPascalLineBeforeThis;
            ulong[] resultPascalLine;

            if (_whichLine < MIN_PASCAL_LINE)
            {
                throw new ApplicationException($"Veuillez enter au minimum \"{MIN_PASCAL_LINE}\" ligne à afficher.");
            }

            if (_whichLine == MIN_PASCAL_LINE)
            {
                return new ulong[] {1};
            }

            resultPascalLineBeforeThis = GetPascalLine(_whichLine - 1);

            resultPascalLine = new ulong[resultPascalLineBeforeThis.Length + 1];

            for (int numberIndex = 0; numberIndex < resultPascalLine.Length; numberIndex++)
            {
                ulong numberLastLineSameIndex;
                ulong numberLastLineIndexBefore;

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
    }
}