using System;

namespace ex_1_2_calculation_spheres
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double air;
            
            
            Console.WriteLine("Welcome to the sphere calculator.");
            radius = Program.GetDoubleFromUser("Please enter the radius of your circle :");
            air = Program.GetSphereAir(radius);
            Console.WriteLine($"The air of sphere is {air},");
            Console.WriteLine($"And the volume of sphere is {Program.GetSphereVolume(radius)}.");
            
            Console.WriteLine("Bye bye!");
        }

        private static double GetSphereAir(double radius)
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
        
        private static double GetSphereVolume(double radius)
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3D;
        }

        private static double GetDoubleFromUser(string message)
        {
            string userInput;
            
            do
            {
                Console.WriteLine(message);

                try
                {
                    userInput = Console.ReadLine();
                    if (userInput == null)
                    {
                        throw new ArgumentException();
                    }
                    return double.Parse(userInput);
                }
                catch (FormatException error)
                {
                    Console.WriteLine($"Error: please enter a correct number ({error.Message})");
                }
                catch (ArgumentNullException error)
                {
                    Console.WriteLine($"Error: please enter a number ({error.Message})");
                }
            } while (true);
        }
    }
}