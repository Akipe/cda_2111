

using ex_05_subject_exams.response;

namespace ex_05_subject_exams.question;

public class MultipleChoiceQuestion : Question
{
    private Choice[] _choices;

    public MultipleChoiceQuestion(string statement, int difficulty, Choice[] choices) : base(statement, difficulty)
    {
        Choices = choices;
    }
    
    public Choice[] Choices
    {
        get => _choices;
        init
        {
            if (value is null && value.Length < 2)
            {
                throw new ApplicationException("You need to defined at least two choices");
            }

            _choices = value;
        }
    }

    public override bool GetIsCorrect()
    {
        return Choices.All(choice => choice.IsCorrect());
    }
}