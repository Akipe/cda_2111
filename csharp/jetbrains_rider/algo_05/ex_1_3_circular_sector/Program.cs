using System;

namespace ex_1_3_circular_sector
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double angle;
            double surface;
            
            Console.WriteLine("Welcome to the circular sector calculator.");
            radius = Helper.GetDoubleFromUser("Please enter the radius of the circular sector :");
            angle = Helper.GetDoubleFromUser("Please enter the angle of the circular sector :");

            surface = GetSurfaceFromCircularSector(radius, angle);
            
            Console.WriteLine($"The surface of the circular sector is {surface} .");
        }

        private static double GetSurfaceFromCircularSector(double radius, double angle)
        {
            return (Math.PI * Math.Pow(radius, 2) * angle) / 360;
        }
    }
}