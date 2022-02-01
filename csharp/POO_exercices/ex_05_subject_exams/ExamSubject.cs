using System.Text;
using ex_05_subject_exams.question;

namespace ex_05_subject_exams;

public class ExamSubject
{
    private Dictionary<Question,int> _questions;
    private int _maxPoints;

    private readonly char[] alphabetNumbering = new char[]
    {
        'a',
        'b',
        'c',
        'd',
        'e',
        'f',
        'g',
        'h'
    };

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

            this._maxPoints = value;
        }
        get => this._maxPoints;
    }

    public Dictionary<Question,int> Questions
    {
        init
        {
            if (value.Count < 1)
                throw new ApplicationException("You have to enter at least one question");

            this._questions = value;
        }
        get => this._questions;
    }

    public void Show()
    {
        StringBuilder outputExam = new StringBuilder();
        
        for (int numberQuestion = 0; numberQuestion < this.Questions.Count; numberQuestion++)
        {
            outputExam.Append(numberQuestion + 1);
            outputExam.Append(") ");
            outputExam.Append(this.Questions.Keys.ElementAt(numberQuestion).Statement);
            outputExam.Append(" (");
            outputExam.Append(this.Questions.Values.ElementAt(numberQuestion));
            outputExam.AppendLine(" points)");
            if (this.Questions.Keys.ElementAt(numberQuestion) is MultipleChoiceQuestion qcmQuestion)
            {
                this.PopulateOutputAllChoicesFrom(qcmQuestion, ref outputExam);
            }
        }
        
        Console.WriteLine(outputExam.ToString());
    }

    private void PopulateOutputAllChoicesFrom(MultipleChoiceQuestion question, ref StringBuilder outputExam)
    {
        for (int indexChoice = 0; indexChoice < question.Choices.Length; indexChoice++)
        {
            outputExam.Append('\t');
            outputExam.Append(alphabetNumbering[indexChoice]);
            outputExam.Append(") ");
            outputExam.AppendLine(question.Choices[indexChoice].Entitled);
        }
    }


    public int GetDifficulty()
    {
        int examDifficulty = 0;
        
        foreach (Question question in _questions.Keys)
        {
            examDifficulty += question.Difficulty;
        }

        return examDifficulty / _questions.Count;
    }
}