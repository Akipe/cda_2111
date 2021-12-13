namespace ex_3_3_count_all_alphabetic_letters;

public class CharCounter
{
    private const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
    private const int INDEX_CHARACTER = 0;
    private const int INDEX_COUNTER = 1;

    private char[] alphabetCharacters;
    private int[] counterAlphabetCharacters;
    private string _textToHandle;
    
    public CharCounter()
    {
        this.alphabetCharacters = ALPHABET.ToCharArray();
        this.counterAlphabetCharacters = new int[this.alphabetCharacters.Length];
        this._textToHandle = "";
        for (int indexCharacter = 0; indexCharacter < this.counterAlphabetCharacters.Length; indexCharacter++)
        {
            this.counterAlphabetCharacters[indexCharacter] = 0;
        }
    }

    public void SetSentence(string _text)
    {
        this._textToHandle = _text.ToLower();
    }

    public string[,] GetCharCounter()
    {
        string[,] resultCharCounter;

        if (string.IsNullOrWhiteSpace(this._textToHandle))
        {
            throw new Exception("The text is not defined ! So it can't count characters");
        }
        
        this.CountCharInText();
        resultCharCounter = PrepareCharCounterResult();

        return resultCharCounter;
    }

    public int GetCharacterIndex()
    {
        return INDEX_CHARACTER;
    }

    public int GetCounterIndex()
    {
        return INDEX_COUNTER;
    }

    public int GetHowManyCharactersAlphabet()
    {
        return this.alphabetCharacters.Length;
    }

    private string[,] PrepareCharCounterResult()
    {
        string[,] resultCharCounter = new string[alphabetCharacters.Length, 2];
        
        for (int indexCharacter = 0; indexCharacter < alphabetCharacters.Length; indexCharacter++)
        {
            resultCharCounter[indexCharacter, INDEX_CHARACTER] = alphabetCharacters[indexCharacter].ToString();
            resultCharCounter[indexCharacter, INDEX_COUNTER] = counterAlphabetCharacters[indexCharacter].ToString();
        }

        return resultCharCounter;
    }

    private void CountCharInText()
    {
        foreach (char characterInText in this._textToHandle)
        {
            this.IncrementCounterCorrespondingCharacter(characterInText);
        }
    }

    private void IncrementCounterCorrespondingCharacter(char _character)
    {
        
        bool continueCheckCharacter = true;
        int indexAlphabeticCharacter = 0;
        
        while(continueCheckCharacter)
        {
            if (indexAlphabeticCharacter < this.alphabetCharacters.Length)
            {
                if (_character.Equals(this.alphabetCharacters[indexAlphabeticCharacter]))
                {
                    this.counterAlphabetCharacters[indexAlphabeticCharacter]++;
                    continueCheckCharacter = false;
                }
            }
            else
            {
                continueCheckCharacter = false;
            }
            
            indexAlphabeticCharacter++;
        }
    }
}