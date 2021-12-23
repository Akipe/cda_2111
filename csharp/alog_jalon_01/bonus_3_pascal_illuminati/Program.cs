using System;
using System.Collections;
using System.Text;

namespace bonus_3_pascal_illuminati
{
    class Program
    {
        public static void Main(string[] _args)
        {
            DrawIlluminatiPascal(200);
        }

        public static void DrawIlluminatiPascal(int _howManyLines)
        {
            int maxSizeHorizontalLine = GetSizeHorizontalLine(_howManyLines);
            bool[] currentPascalLine;
            int indexToBeginDraw;
            
            // Horizontal lines begin to top
            for (int indexLineHorizontal = 0; indexLineHorizontal <= _howManyLines; indexLineHorizontal++)
            {
                currentPascalLine = GetPascalLineEvenOdd(indexLineHorizontal);
                indexToBeginDraw = GetIndexToBeginDrawNumbers(maxSizeHorizontalLine, currentPascalLine.Length);
                
                DrawOneLinePascal(currentPascalLine, indexToBeginDraw);
            }
        }

        public static char GetCharacterFromEvenOddNumber(bool _numberEvenOdd)
        {
            return _numberEvenOdd ? 'I' : 'P';
        }

        public static int GetMiddleHorizontalLine(int _lineSize)
        {
            return (int) _lineSize / 2 + 1 + 1; // last "+1" for fix last line not align
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

        public static void DrawOneLinePascal(bool[] _pascalNumbers, int _indexToBeginDraw)
        {
            WriteBlankSpaces(_indexToBeginDraw);

            for (int indexPixelPascal = 0; indexPixelPascal < _pascalNumbers.Length; indexPixelPascal++)
            {
                SetTerminalOutputColorFromNumbers(_pascalNumbers[indexPixelPascal]);
                
                Console.Write(GetCharacterFromEvenOddNumber(_pascalNumbers[indexPixelPascal]));
                
                ResetTerminalOutputColor();
                
                if (indexPixelPascal != _pascalNumbers.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            
            Console.Write("\n");
        }

        public static void SetTerminalOutputColorFromNumbers(bool _numberEven)
        {
            if (!_numberEven)
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
        
        /// <summary>
        /// Return only even or odd even for a Pascal line.
        /// - even number : false
        /// - odd number : true
        /// </summary>
        /// <param name="_whichLine"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        public static bool[] GetPascalLineEvenOdd(int _whichLine)
        {
            const int MIN_PASCAL_LINE = 0;

            bool[] resultPascalLineBeforeThis;
            bool[] resultPascalLine;
            // int mediaIndexListNumbers;

            if (_whichLine < MIN_PASCAL_LINE)
            {
                throw new ApplicationException($"Veuillez enter au minimum \"{MIN_PASCAL_LINE}\" ligne à afficher.");
            }

            if (_whichLine == MIN_PASCAL_LINE)
            {
                return new bool[] {true};
            }

            resultPascalLineBeforeThis = GetPascalLineEvenOdd(_whichLine - 1);

            // Todo : calculate the middle of line and don't remake cal
            // mediaIndexListNumbers = _whichLine / 2 + 1;
            
            resultPascalLine = new bool[resultPascalLineBeforeThis.Length + 1];

            for (int numberIndex = 0; numberIndex < resultPascalLine.Length; numberIndex++)
            {
                if (numberIndex == 0 || numberIndex == resultPascalLine.Length - 1)
                {
                    resultPascalLine[numberIndex] = true;
                }
                else
                {
                    resultPascalLine[numberIndex] = 
                        resultPascalLineBeforeThis[numberIndex - 1] ^ resultPascalLineBeforeThis[numberIndex];
                }
            }

            return resultPascalLine;
        }
    }
}