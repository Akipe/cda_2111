// See https://aka.ms/new-console-template for more information

using ex_05_subject_exams;
using ex_05_subject_exams.question;
using ex_05_subject_exams.response;

// QCM
OpenEndedQuestion firstQuestion = new OpenEndedQuestion(
    "Présentez vous :",
    0,
    new OpenSolution(
        new string[]
        {
            "nom",
            "prenom"
        }));

MultipleChoiceQuestion secondQuestion = new MultipleChoiceQuestion(
    "Quel est la couleur du cheval blanc de Charlemagne ?",
    20,
    new Choice[]
    {
        new Choice("Noir", false),
        new Choice("Violet", false),
        new Choice("Blanc", true),
        new Choice("Yellow", false),
    });

OpenEndedQuestion thirdQuestion = new OpenEndedQuestion(
    "Qu'est ce que la philosophie ?",
    120,
    new OpenSolution(
        new string[]
        {
            "philosophie",
            "ouf"
        }));

MultipleChoiceQuestion fourthQuestion = new MultipleChoiceQuestion(
    "Dans quel pays vivez vous ?",
    20,
    new Choice[]
    {
        new Choice("Allemagne", false),
        new Choice("Suisse", false),
        new Choice("France", true),
    });

// // User response
// Console.WriteLine(firstQuestion.Statement);
// firstQuestion.OpenSolution.Answer = Console.ReadLine();
//
// Console.WriteLine(secondQuestion.Statement);
// foreach (var choice in secondQuestion.Choices)
// {
//     Console.WriteLine(choice.Entitled);
//     if (bool.Parse(Console.ReadLine()))
//         choice.Check();
//     else
//         choice.Uncheck();
// }
//
// Console.WriteLine(thirdQuestion.Statement);
// thirdQuestion.OpenSolution.Answer = Console.ReadLine();
//
// Console.WriteLine(fourthQuestion.Statement);
// foreach (var choice in fourthQuestion.Choices)
// {
//     Console.WriteLine(choice.Entitled);
//     if (bool.Parse(Console.ReadLine()))
//         choice.Check();
//     else
//         choice.Uncheck();
// }
//
// // Result
// Console.WriteLine(firstQuestion.GetIsCorrect());
// Console.WriteLine(secondQuestion.GetIsCorrect());
// Console.WriteLine(thirdQuestion.GetIsCorrect());
// Console.WriteLine(fourthQuestion.GetIsCorrect());

Dictionary<Question, int> allQuestionToQCM = new Dictionary<Question, int>();
allQuestionToQCM.Add(firstQuestion, 1);
allQuestionToQCM.Add(secondQuestion, 2);
allQuestionToQCM.Add(thirdQuestion, 3);
allQuestionToQCM.Add(fourthQuestion, 4);

ExamSubject e1 = new ExamSubject(allQuestionToQCM);
e1.Show();
Console.WriteLine("Difficulty of exam : " + e1.GetDifficulty());