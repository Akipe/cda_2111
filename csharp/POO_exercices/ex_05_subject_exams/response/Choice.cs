namespace ex_05_subject_exams.response;

public class Choice : Response
{
    private bool _isCheck;
    
    public Choice(string entitled, bool solution)
    {
        Entitled = entitled;
        Solution = solution;
        Uncheck();
    }

    public string Entitled { get; init; }

    public bool Solution { get; init; }

    public bool GetIsCheck()
    {
        return _isCheck;
    }

    public void Check()
    {
        _isCheck = true;
    }

    public void Uncheck()
    {
        _isCheck = false;
    }

    /// <summary>
    /// Return if the user has been well answered, for example :
    /// If this choice is incorrect and has not been checked, it is correct.
    /// </summary>
    /// <returns>If user has answered correctly</returns>
    public override bool IsCorrect()
    {
        return GetIsCheck() == Solution;
    }
}