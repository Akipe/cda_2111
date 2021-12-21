using System;
using System.Text;

namespace ex_1_3_sub_2_12_v2_permutation_characters
{
    public static class Program
    {
        public static void Main(string[] _args)
        {
            string wordToPermut;
            int howManyPermutation;
            bool userWantReDo;
            
            Console.WriteLine("Welcome to permutation word simulator.");

            do
            {
                Console.WriteLine("Enter a word to make characters permutation :");
                wordToPermut = Console.ReadLine();
            
                Console.WriteLine("Enter which permutation number you want :");
                howManyPermutation = int.Parse(Console.ReadLine());
            
                Console.WriteLine($"Permutation of {wordToPermut} at n°{howManyPermutation} :");
                Console.WriteLine(GetPermutationCharacters(wordToPermut, ref howManyPermutation));
                
                Console.WriteLine("Do you want to redo an other permutation ? (\"yes\", \"no\")");
                userWantReDo = Console.ReadLine().Equals("yes");
            } while (userWantReDo);
        }

        /// <summary>
        /// Permute characters of _wordToPermute at _howManyPermutation permutation, in relation to the alphabetic order.
        /// </summary>
        /// <param name="_wordToPermute">The word to permute characters</param>
        /// <param name="_howManyPermutation">The number of permutation to get</param>
        /// <param name="_prefixPermutedWip">DON'T USE IT!</param>
        /// <returns>The permutation of the _wordToPermute at _howManyPermutation number</returns>
        public static string? GetPermutationCharacters(
            string _wordToPermute,
            ref int _howManyPermutation,
            string _prefixPermutedWip = "")
        {
            string maybePermutation = "";
            
            // Optimize algorithm with removing latest loop because there will be only one character left
            // So We add the last character of the _word manually. 
            if (_wordToPermute.Length == 1)
            {
                if (_howManyPermutation == 0)
                {
                    return _prefixPermutedWip + _wordToPermute[0];
                }
                _howManyPermutation--;

                return maybePermutation;
            }
            
            // When the word has letters to permute (length bigger than 1)
            for (int indexCharacterToPermute = 0; indexCharacterToPermute < _wordToPermute.Length; indexCharacterToPermute++)
            {
                string maybePermutationInLoop;
                
                maybePermutationInLoop = GetPermutationCharacters(
                    RemoveCharacterInIndexInWord(indexCharacterToPermute, _wordToPermute),
                    ref _howManyPermutation,
                    _prefixPermutedWip + GetCharacterAtIndexInWord(indexCharacterToPermute, _wordToPermute)
                );

                if (!String.IsNullOrEmpty(maybePermutationInLoop) && _howManyPermutation == 0)
                {
                    return maybePermutationInLoop;
                }
            }

            return maybePermutation;
        }

        /// <summary>
        /// Return the character at an define index
        /// </summary>
        /// <param name="_indexCharacterToGet">Index where to get the character</param>
        /// <param name="_word">Word to get character</param>
        /// <returns>The character at the index</returns>
        private static char GetCharacterAtIndexInWord(int _indexCharacterToGet, string _word)
        {
            return _word[_indexCharacterToGet];
        }

        /// <summary>
        /// Remote a character in a define index of a word.
        /// </summary>
        /// <param name="_indexCharacterToRemove">Where to remove the character</param>
        /// <param name="_word">Word to remove the character</param>
        /// <returns>The word without the character in the index define</returns>
        private static string RemoveCharacterInIndexInWord(int _indexCharacterToRemove, string _word)
        {
            StringBuilder buildWordWithoutCharacter = new StringBuilder();
            
            for (int indexCharacter = 0; indexCharacter < _word.Length; indexCharacter++)
            {
                if (indexCharacter != _indexCharacterToRemove)
                {
                    buildWordWithoutCharacter.Append(_word[indexCharacter]);
                }
            }

            return buildWordWithoutCharacter.ToString();
        }
    }
}