using System;

namespace ex_2_1_3_km_mi_conversion
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            string userCommand;
            
            Console.WriteLine("Programs for convert kilometers <-> Miles.");
            
            Console.WriteLine("Please enter your distance to convert with unit (\"km\" or \"mi\", if no units define it will be km)");
            Console.WriteLine("Or \"go\" to execute conversion");
            Console.WriteLine("Or \"qui\" to exit.");

            userCommand = Console.ReadLine();
            int.TryParse(userCommand, out number);

            if (HasUserEnterDistance(userCommand, out distance, out unit))
            {
            }
        }

        private static bool HasUserEnterDistance(string userCommand, out double distance, out string unit)
        {
            bool asSpaceInUserCommand;
            string maybeDistance;
            string maybeUnit;
            double distance;

            asSpaceInUserCommand = false;
            try
            {
                for (int index = 0; index < userCommand.Length; index++)
                {
                    if (userCommand[index] == ' ')
                    {
                        maybeDistance = userCommand.Substring(0, index - 1);
                        distance = GetDistanceIfIsCorrect(maybeDistance);
                        
                        // Try to guest unit right of index
                        maybeUnit = userCommand.Substring(index + 1, userCommand.Length);

                        asSpaceInUserCommand = true;
                    }
                }

                if (!asSpaceInUserCommand)
                {
                    // Try to cast all usercommand
                }
            }
        }
        private static double GetDistanceIfIsCorrect(string maybeDistance)
        {
            double distance;
            
            distance = double.Parse(maybeDistance);

            if (DistanceExceedLimit(distance))
            {
                throw new Exception(
                    "Error : the distance exceed the limit (smaller than 0.01 or bigger than 1 000 000.");
            }

            return distance;
        }

        private static bool DistanceExceedLimit(double distance)
        {
            return distance < 0.01 | distance > 1000000;
        }
    }
    

}