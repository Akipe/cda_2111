using System;

namespace ex_3_7_search_dichotomy_array_classified
{
    internal static class Program
    {
        public static void Main(string[] _args)
        {
            string[] listNameSorted = new string[] {
                "agathe",
                "berthe",
                "chloé",
                "cunégonde",
                "olga",
                "raymonde",
                "sidonie"
            };

            listNameSorted[0].Split();
            string userNameToFind;
            int howManyPassToFind = 0;
            
            Console.WriteLine("Welcome to the array sort searcher.");
            
            Console.WriteLine("Current list name :");
            foreach (var name in listNameSorted)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Please enter a name to search :");
            userNameToFind = Console.ReadLine();

            if (IsElementInsideSortedArray(userNameToFind, listNameSorted, ref howManyPassToFind))
            {
                Console.WriteLine($"The name \"{userNameToFind}\" is inside the list name.");
            }
            else
            {
                Console.WriteLine($"The name \"{userNameToFind}\" is not inside the list name.");
            }
            Console.WriteLine($"This search has been terminate with {howManyPassToFind} pass.");
        }

        /// <summary>
        /// Search in an string array sorted if an element exist. It use the Dichotomy algorithm.
        /// </summary>
        /// <param name="_element">Element to search</param>
        /// <param name="_arraySort">Array sorted by alphabetic order</param>
        /// <param name="_howManyPassToFind">Variable in reference to know how many pass the algorithm do the search</param>
        /// <returns>If the element is inside the array</returns>
        public static bool IsElementInsideSortedArray(string _element, string[] _arraySort, ref int _howManyPassToFind)
        {
            _howManyPassToFind++;
            
            if (_arraySort.Length == 1)
            {
                if (CompareTwoWords(_element, _arraySort[0]) == 0)
                {
                    return true;
                }

                return false;
            }

            int indexMedian;

            indexMedian = GetMedianIndex(_arraySort);

            switch (CompareTwoWords(_element, _arraySort[indexMedian]))
            {
                case < 0:
                    return IsElementInsideSortedArray(
                        _element, GetPartOfArrayFromAnIndex(indexMedian - 1, _arraySort, false),
                        ref _howManyPassToFind
                        );
                case > 0:
                    return IsElementInsideSortedArray(
                        _element, GetPartOfArrayFromAnIndex(indexMedian + 1, _arraySort, true),
                        ref _howManyPassToFind
                        );
                case 0:
                    return true;
            }
        }

        /// <summary>
        /// Get a part of an array in relation to an index.
        /// </summary>
        /// <param name="_indexToSplit">Where to split the array, this index will be on the new array</param>
        /// <param name="_array">The array to split</param>
        /// <param name="_getToTheEnd">
        /// What to put in the new array,
        /// if yes the new array will begin from the _indexToSplit to the end of the array,
        /// if no the new array will begin from the begin of the array to the index _indexToSplit.
        /// </param>
        /// <returns>Return a new array who are the part of the _array</returns>
        private static string[] GetPartOfArrayFromAnIndex(int _indexToSplit, string[] _array, bool _getToTheEnd = true)
        {
            int indexToStart;
            int indexToStop;
            int indexOldArray;
            int sizeNewArrayFromSplit;
            string[] newArrayFromSplit;
            
            if (_getToTheEnd)
            {
                indexToStart = _indexToSplit;
                indexToStop = _array.Length - 1;
            }
            else
            {
                indexToStart = 0;
                indexToStop = _indexToSplit;
            }

            sizeNewArrayFromSplit = indexToStop - indexToStart + 1;
            newArrayFromSplit = new string[sizeNewArrayFromSplit];
            indexOldArray = indexToStart;

            for (int indexNewArray = 0; indexNewArray < sizeNewArrayFromSplit; indexNewArray++)
            {
                newArrayFromSplit[indexNewArray] = _array[indexOldArray];
                indexOldArray++;
            }

            return newArrayFromSplit;
        }

        /// <summary>
        /// Get the index of the half of the length of an array.
        /// If the number of indexes is an even number, we round up.
        /// </summary>
        /// <param name="_array">The array to get the median index</param>
        /// <returns>Get the median (middle) index, if the number of indexes is an even number, we round up.</returns>
        private static int GetMedianIndex(string[] _array)
        {
            return _array.Length / 2;
        }

        /// <summary>
        /// Compare if two words are same, or if one word is bigger or smaller than the other.
        /// The comparison is made in relation to the alphabet.
        /// </summary>
        /// <param name="_firstWord">The first word, the result will be related to him.</param>
        /// <param name="_secondWord">The second word to compare</param>
        /// <returns>
        /// "-1" if the first word is smaller than the second,
        /// "0" if they are same,
        /// "1" if the first word is bigger than the second.
        /// </returns>
        private static int CompareTwoWords(string _firstWord, string _secondWord)
        {
            const int FIRST_WORD_BIGGER = -1;
            const int WORDS_SAME_LENGTH = 0;
            const int SECOND_WORD_BIGGER = 1;

            int statusWordsLength;
            int howManyCharactersToCompare;
            
            // We check the length of two words in case they share sames characters
            if (_firstWord.Length > _secondWord.Length)
            {
                statusWordsLength = FIRST_WORD_BIGGER;
                howManyCharactersToCompare = _secondWord.Length;
            }
            else if (_firstWord.Length < _secondWord.Length)
            {
                statusWordsLength = SECOND_WORD_BIGGER;
                howManyCharactersToCompare = _firstWord.Length;
            }
            else
            {
                statusWordsLength = WORDS_SAME_LENGTH;
                howManyCharactersToCompare = _firstWord.Length;
            }

            for (int indexCharacter = 0; indexCharacter < howManyCharactersToCompare; indexCharacter++)
            {
                int resultCompareCharacter =
                    _firstWord.ToLower()[indexCharacter].CompareTo(_secondWord.ToLower()[indexCharacter]);
                
                switch (resultCompareCharacter)
                {
                    case < 0:
                        return -1;
                    case > 0:
                        return 1;
                }
            }

            switch (statusWordsLength)
            {
                case SECOND_WORD_BIGGER:
                    return -1;
                case FIRST_WORD_BIGGER:
                    return 1;
                case WORDS_SAME_LENGTH:
                    return 0;
                default:
                    return 0;
            }
        }
    }
}