using System.Text;

namespace ex_05_subject_exams;

public class ExamSubject
{
    private Dictionary<Question,int> _questions;

    public ExamSubject(Dictionary<Question,int> questions)
    {
        Questions = questions;
    }

    public int MaxPoint
    {
        init
        {
            if (value < 1)
                throw new ApplicationException("The score has to be positive and bigger than zero");

            _maxPoints = value;
        }
        get => _maxPoints;
    }

    public Dictionary<Question,int> Questions
    {
        init
        {
            if (value.Length < 1)
                throw new ApplicationException("You have to enter at least one question");

            _questions = value;
        }
        get => _questions;
    }

    public void Show()
    {
        StringBuilder outputExam = new StringBuilder();
        
        for (int numberQuestion = 1; numberQuestion <= Questions.Length; numberQuestion++)
        {
            outputExam.Append("Question number ");
            outputExam.Append(numberQuestion);
            outputExam.Append(" :");
            outputExam.AppendLine(Questions[numberQuestion].Statement);
            if (Questions[numberQuestion] is )
        }
    }

    public void Perform()
    {
        
    }

    public int GetDifficulty()
    {
        
    }
}