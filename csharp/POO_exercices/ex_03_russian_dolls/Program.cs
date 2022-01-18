using System.Diagnostics;

namespace ex_03_russian_dolls;

internal static class Program
{
    public static void Main(string[] args)
    {
        RussianDoll p1 = new RussianDoll(1);
        RussianDoll p2 = new RussianDoll(2);
        RussianDoll p3 = new RussianDoll(3);

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
            
            p2.Close();
            p3.Open();
            p2.PutIn(p3);

            p2.GetOutOf(p3);
            p2.Open();
            p1.GetOutOf(p2);
            
            try
            {
                p1.Open();
                p1.PutIn(p2);
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test  : {error.Message}");
            }

            p2.Close();
            p3.Close();
            
            try
            {
                p3.PutIn(p1);
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
            
            try
            {
                p2.PutIn(p1);
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test  : {error.Message}");
            }
            
            p1.Close();
            p2.Open();
            p3.Open();
            
            try
            {
                p1.PutIn(p3);
                p1.PutIn(p2);
            }
            catch (ApplicationException error)
            {
                Console.Error.WriteLine($"Error test  : {error.Message}");
            }
            
            p2.Close();
            
            try
            {
                p2.PutIn(p3);
                p3.Open();
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
}