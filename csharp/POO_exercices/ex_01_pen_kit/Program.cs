// See https://aka.ms/new-console-template for more information

using ex_01_pen_kit.kit;
using ex_01_pen_kit.tool.writeTool;
using ex_01_pen_kit.tool.writeTool.pencil;

SchoolKit mySchoolKit = new SchoolKit(4);
SchoolKit schoolKitFriend = new SchoolKit(3);
SchoolKit schoolKitTeacher = new SchoolKit(8);

BallPointPen myBasicPen = new BallPointPen(ConsoleColor.Blue);
BallPointPen myTitlePen = new BallPointPen(ConsoleColor.Red);
BallPointPen myCorrectorPen = new BallPointPen(ConsoleColor.Green);
BallPointPen myNotePen = new BallPointPen(ConsoleColor.Black);
BallPointPen friendBallPointPen = new BallPointPen(ConsoleColor.Blue);

Pencil myDrawPen = new PaperPencil();
Pencil myColorYellowPen = new ColoredPencil(ConsoleColor.Yellow);
Pencil myColorWhitePen = new ColoredPencil(ConsoleColor.White);
Pencil myColorMagentaPen = new ColoredPencil(ConsoleColor.Magenta);
Pencil myColorCyanPen = new ColoredPencil(ConsoleColor.Cyan);

FountainPen professorPen = new FountainPen(ConsoleColor.DarkBlue);


mySchoolKit.Open();
mySchoolKit.AddStuff(myBasicPen);
mySchoolKit.AddStuff(myTitlePen);
mySchoolKit.AddStuff(myCorrectorPen);
mySchoolKit.AddStuff(myNotePen);
mySchoolKit.RemoveStuff(myTitlePen);
mySchoolKit.AddStuff(friendBallPointPen);
try
{
    mySchoolKit.AddStuff(myTitlePen);
}
catch (ApplicationException error)
{
    Console.WriteLine(error.Message);
}

if (mySchoolKit.HasStuff(myTitlePen))
{
    Console.WriteLine("J'ai dans ma trousse mon stylo pour les titres.");
}
else
{
    Console.WriteLine("Je n'ai pas dans ma trousse le stylo pour les titres.");
}

if (mySchoolKit.HasStuff(myCorrectorPen))
{
    Console.WriteLine("J'ai dans ma trousse mon stylo pour les corrections.");
}
else
{
    Console.WriteLine("Je n'ai pas dans ma trousse le stylo pour les corrections.");
}

if (mySchoolKit.IsFull())
{
    Console.WriteLine("Ma trousse est pleine, je ne peux plus rien ranger dedans");
}

try
{
    mySchoolKit.RemoveStuff(myCorrectorPen);
    mySchoolKit.Close();
    mySchoolKit.AddStuff(myCorrectorPen);
}
catch (ApplicationException error)
{
    Console.WriteLine(error.Message);
}
