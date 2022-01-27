using ex_05_subject_exams.response;

namespace ex_05_subject_exams.question;

public class OpenEndedQuestion : Question
{
    public OpenEndedQuestion(string statement, int difficulty, OpenSolution openSolution) : base(statement, difficulty)
    {
        OpenSolution = openSolution;
    }

    public OpenSolution OpenSolution
    {
        init;
        get;
    }

    public override bool GetIsCorrect()
    {
        return OpenSolution.IsCorrect();
    }
}