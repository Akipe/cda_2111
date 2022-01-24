namespace ex_05_subject_exams.question;

public class OpenEndedQuestion : Question
{
    private bool? _isCorrect;
    
    public OpenEndedQuestion(string statement, int difficulty) : base(statement, difficulty)
    {
        _isCorrect = null;
    }

    public string? Answer { get; set; }

    public void SetIsCorrect(bool? isCorrect)
    {
        _isCorrect = isCorrect;
    }

    public override bool GetIsCorrect()
    {
        if (_isCorrect is null)
            throw new ApplicationException("The answer has not been received a correction");

        return (bool) _isCorrect;
    }
}