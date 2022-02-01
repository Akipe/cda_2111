namespace ex_05_subject_exams;

public abstract class Question
{
    private int _difficulty;

    public Question(string statement, int difficulty = 50)
    {
        Statement = statement;
        Difficulty = difficulty;
    }

    public string Statement { get; init; }

    public int Difficulty
    {
        get => _difficulty;
        set => _difficulty = value > 100 ? 100 : value < 0 ? 0 : value;
    }

    public abstract bool GetIsCorrect();
}