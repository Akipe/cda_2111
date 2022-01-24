// See https://aka.ms/new-console-template for more information

using ex_05_subject_exams.question;

// QCM
OpenEndedQuestion firstQuestion = new OpenEndedQuestion(
    "Présentez vous :",
    0);

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
    120);

MultipleChoiceQuestion fourthQuestion = new MultipleChoiceQuestion(
    "Dans quel pays vivez vous ?",
    20,
    new Choice[]
    {
        new Choice("Allemagne", false),
        new Choice("Suisse", false),
        new Choice("France", true),
    });

// User response
Console.WriteLine(firstQuestion.Statement);
firstQuestion.Answer = Console.ReadLine();

Console.WriteLine(secondQuestion.Statement);
foreach (var choice in secondQuestion.Choices)
{
    Console.WriteLine(choice.Entitled);
    if (bool.Parse(Console.ReadLine()))
        choice.Check();
    else
        choice.Uncheck();
}

Console.WriteLine(thirdQuestion.Statement);
thirdQuestion.Answer = Console.ReadLine();

Console.WriteLine(fourthQuestion.Statement);
foreach (var choice in fourthQuestion.Choices)
{
    Console.WriteLine(choice.Entitled);
    if (bool.Parse(Console.ReadLine()))
        choice.Check();
    else
        choice.Uncheck();
}

// Correction
Console.WriteLine(" \"" + firstQuestion.Statement + "\" with response \""+ firstQuestion.Answer + "\" is correct ?");
firstQuestion.SetIsCorrect(bool.Parse(Console.ReadLine()));

Console.WriteLine(" \"" + thirdQuestion.Statement + "\" with response \""+ thirdQuestion.Answer + "\" is correct ?");
thirdQuestion.SetIsCorrect(bool.Parse(Console.ReadLine()));

// Result
Console.WriteLine(firstQuestion.GetIsCorrect());
Console.WriteLine(secondQuestion.GetIsCorrect());
Console.WriteLine(thirdQuestion.GetIsCorrect());
Console.WriteLine(fourthQuestion.GetIsCorrect());
