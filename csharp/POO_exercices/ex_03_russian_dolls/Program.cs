using System.Diagnostics;

namespace ex_03_russian_dolls;

internal class Program
{
    static void Main(string[] args)
    {
        RussianDolls p1 = new RussianDolls(1);
        RussianDolls p2 = new RussianDolls(2);
        RussianDolls p3 = new RussianDolls(3);

        try
        {
            p1.Open();

            try
            {
                p2.Close();
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test : {error.Message}");
            }

            try
            {
                p2.Open();
                p2.Open();
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test  : {error.Message}");
            }
            
            try
            {
                p1.PutIn(p2);
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test  : {error.Message}");
            }
            
            p2.Close();
            p1.Close();
            
            p2.Open();
            p1.PutIn(p2);
            Console.WriteLine("Test");
            p2.Close();
            p3.Open();
            p2.PutIn(p3);

            p2.GetOutOf(p3);
            p1.GetOutOf(p2);

            try
            {
                p2.PutIn(p1);
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test  : {error.Message}");
            }

            try
            {
                p2.PutIn(p1);
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test  : {error.Message}");
            }
        }
        catch (ApplicationException error)
        {
            Console.Error.WriteLine($"ERROR : {error.Message}");
        }

    }

    public static void ShowStatusOpenRussianDoll(RussianDolls russianDoll)
    {
        Console.WriteLine(
            $"This Russian doll is {(russianDoll.IsOpen ? "open" : "close")}.");
    }
}