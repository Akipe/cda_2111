using System;

namespace ex_3_2_search_char_in_string
{
    /// <summary>
    /// A simple class to search how many characters are found in sentences.
    /// </summary>
    public class SimpleStringResearcher
    {
        public const int RETURN_ERROR_SENTENCE_NOT_TERMINATE_POINT = -1;
        
        private string sentence;
        
        /// <summary>
        /// Add the sentence to make some search inside it.
        /// If the sentence does not terminate with a point, it will return errors.
        /// </summary>
        /// <param name="_sentence">The sentence to make research</param>
        public SimpleStringResearcher(string _sentence)
        {
            this.sentence = _sentence;
        }

        /// <summary>
        /// Get how many time the sentence has a specific character.
        /// </summary>
        /// <param name="_charToSearch">The character to search</param>
        /// <returns>
        /// Return how many time the character has been found, or errors with negative numbers :
        /// * "SimpleStringResearcher.RETURN_ERROR_SENTENCE_NOT_TERMINATE_POINT" : the sentence does not terminate with point.
        /// </returns>
        public int GetHowMany(char _charToSearch)
        {
            int counterCharFound;

            if (!this.IsTerminateWithPoint())
            {
                return SimpleStringResearcher.RETURN_ERROR_SENTENCE_NOT_TERMINATE_POINT;
            }
            
            counterCharFound = 0;
            
            foreach (char sentenceChar in this.sentence)
            {
                if (sentenceChar == _charToSearch)
                {
                    counterCharFound++;
                }
            }

            return counterCharFound;
        }
       
        /// <summary>
        /// To know if a sentence terminate with a point (".").
        /// It check if the latest character is a point.
        /// </summary>
        /// <returns>Return if the sentence terminate with a point</returns>
        public bool IsTerminateWithPoint()
        {
            return this.sentence[^1] == '.';
        }
    }
}