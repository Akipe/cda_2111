namespace ex_05_subject_exams.response;

public class OpenSolution : Response
{
    private readonly string[] _wordsNeededForCorrectAnswer;

    public OpenSolution(string[] wordsNeededForCorrectAnswer)
    {
        WordsNeededForCorrectAnswer = wordsNeededForCorrectAnswer;
        Answer = null;
    }

    public string[] WordsNeededForCorrectAnswer
    {
        init
        {
            if (value.Length < 1)
            {
                throw new ApplicationException("Please enter at least one word to allow a correct answer");
            }

            _wordsNeededForCorrectAnswer = value;
        }
        get => _wordsNeededForCorrectAnswer;
    }

    public string? Answer { set; get; }

    public override bool IsCorrect()
    {
        if (Answer is not null)
        {
            foreach (string wordNeededForCorrectAnswer in WordsNeededForCorrectAnswer)
            {
                if (!Answer.Contains(wordNeededForCorrectAnswer.ToLower().Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    // At least one word is not found
                    return false;
                }
            }

            // All words have been found
            return true;
        }

        // There is not answer
        return false;
    }
}