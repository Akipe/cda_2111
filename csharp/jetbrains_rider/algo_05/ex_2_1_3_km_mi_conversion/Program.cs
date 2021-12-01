using System;

namespace ex_2_1_3_km_mi_conversion
{
    enum DistanceUnit
    {
        Miles,
        Kilometers
    }

    internal static class Program
    {
        private const string KilometersUnit = "km";
        private const double OneMilesToKilometers = 1.609;
        private const string MilesUnit = "mi";
        private const double OneKilometersToMiles = 1 / OneMilesToKilometers;
        private const string CommandConversion = "go";
        private const string CommandExit = "quit";
        private const DistanceUnit DefaultUnit = DistanceUnit.Kilometers;

        private static double[] distancesToConvert;
        private static DistanceUnit[] unitsDistancesToConvert;

        public static void Main(string[] args)
        {
            string userCommand;
            
            Console.WriteLine("Programs for convert kilometers <-> Miles.");
            ShowHelpCommandMessage();

            do
            {
                Console.Write("Command : ");
                userCommand = Console.ReadLine();

                try
                {
                    if (IsCommandIsDistance(userCommand))
                    {
                        SaveDistanceFromUserCommand(userCommand);
                    }
                    else if (IsCommandIsMakeConversion(userCommand))
                    {
                        Console.WriteLine("Make conversion...");
                        ConvertAllDistances();
                    }
                    else if (isCommandIsExist(userCommand))
                    {
                        Console.WriteLine("Bye bye !");
                        Environment.Exit(0);
                    }
                    else
                    {
                        throw new Exception("The command does not exist !");
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error: {error}");
                    ShowHelpCommandMessage();
                }
            } while (true);
        }

        private static void ShowHelpCommandMessage()
        {
            Console.WriteLine("Please enter your distance to convert with unit (\"km\" or \"mi\", if no units define it will be km)");
            Console.WriteLine("Or \"go\" to execute conversion");
            Console.WriteLine("Or \"quit\" to exit.");
        }

        private static bool IsCommandIsMakeConversion(string userCommand)
        {
            return userCommand == "go";
        }

        private static bool isCommandIsExist(string userCommand)
        {
            return userCommand == "quit";
        }

        private static bool IsCommandIsDistance(string userCommand)
        {
            string[] userCommandDecomposed;
            
            if (userCommand.Contains(' '))
            {
                userCommandDecomposed = userCommand.Split(" ");

                if (userCommandDecomposed.Length > 2)
                {
                    throw new Exception("There are too many words in your commande");
                }

                if (IsDistance(userCommandDecomposed[0]))
                {
                    return IsUnit(userCommandDecomposed[1]);
                }

                return false;
            }
            
            return IsDistance(userCommand);
        }

        private static bool IsDistance(string mayBeDistance)
        {
            double distance;

            if (double.TryParse(mayBeDistance, out distance))
            {
                return IsDistanceDoesNotExceedLimit(distance);
            }

            return false;
        }
        private static bool IsDistanceDoesNotExceedLimit(double distance)
        {
            return distance >= 0.01 & distance <= 1000000;
        }

        private static bool IsUnit(string unit)
        {
            if (unit != null)
            {
                return IsKilometerUnit(unit) || IsMileUnit(unit);
            }

            return false;
        }

        private static bool IsKilometerUnit(string unit)
        {
            return unit.Trim().ToLower() == KilometersUnit;
        }
        
        private static bool IsMileUnit(string unit)
        {
            return unit.Trim().ToLower() == MilesUnit;
        }

        private static void SaveDistanceFromUserCommand(string userCommand)
        {
            string[] userCommandDecomposed;
            
            if (userCommand.Contains(' '))
            {
                userCommandDecomposed = userCommand.Split(" ");
                
                SaveDistanceToConvert(double.Parse(userCommandDecomposed[0]), ConvertUnitFromString(userCommandDecomposed[1]));
            }
            else
            {
                SaveDistanceToConvert(double.Parse(userCommand), Program.DefaultUnit);       
            }
        }
        private static void SaveDistanceToConvert(double distance, DistanceUnit unit)
        {
            if (distancesToConvert == null)
            {
                distancesToConvert = new double[1];
                unitsDistancesToConvert = new DistanceUnit[1];
            }
            else
            {
                Array.Resize(ref distancesToConvert, distancesToConvert.Length + 1);
                Array.Resize(ref unitsDistancesToConvert, unitsDistancesToConvert.Length + 1);
            }
            distancesToConvert[^1] = distance;
            unitsDistancesToConvert[^1] = unit;
        }

        private static DistanceUnit ConvertUnitFromString(string unitInString)
        {
            if (IsUnit(unitInString))
            {
                if (IsKilometerUnit(unitInString)) // unit == "km" -> return DistanceUnit.Kilometers
                {
                    return DistanceUnit.Kilometers;
                }
                if (IsMileUnit(unitInString))
                {
                    return DistanceUnit.Miles;
                }
            }
            
            throw new Exception("This unit does not exist!");
        }

        private static string GetStringUnit(DistanceUnit unit, bool completeUnit = false)
        {
            if (completeUnit)
            {
                switch (unit)
                {
                    case DistanceUnit.Kilometers: return "Kilometers";
                    case DistanceUnit.Miles: return "Miles";
                    default: throw new Exception("This unit do not exist.");
                }
            }
            else
            {
                switch (unit)
                {
                    case DistanceUnit.Kilometers: return KilometersUnit;
                    case DistanceUnit.Miles: return MilesUnit;
                    default: throw new Exception("This unit do not exist.");
                }
            }
        }

        private static void ConvertAllDistances()
        {
            double distanceConverted;
            DistanceUnit unitDistanceToConvert;
            
            if (distancesToConvert.Length > 0)
            {
                for (int index = 0; index < distancesToConvert.Length; index++)
                {
                    unitDistanceToConvert = GetInvertUnit(unitsDistancesToConvert[index]);
                    distanceConverted = GetConvertedDistance(
                        distancesToConvert[index],
                        unitsDistancesToConvert[index],
                        unitDistanceToConvert);
                    
                    Console.Write(distancesToConvert[index]);
                    Console.Write(" ");
                    Console.Write(GetStringUnit(unitsDistancesToConvert[index], true));
                    Console.Write(" = ");
                    Console.Write(distanceConverted);
                    Console.Write(" ");
                    Console.WriteLine(unitDistanceToConvert);
                }

                ClearAllDistanceToConvert();
            }
            else
            {
                throw new Exception("You have not save distances to convert! Please enter at least one distance.");
            }
        }

        private static double GetConvertedDistance(double distance, DistanceUnit unitOfDistance,
            DistanceUnit unitToConvert)
        {
            if (unitOfDistance == DistanceUnit.Kilometers && unitToConvert == DistanceUnit.Miles)
            {
                return GetMilesFromKilometers(distance);
            }

            if (unitOfDistance == DistanceUnit.Miles && unitToConvert == DistanceUnit.Kilometers)
            {
                return GetKilometersFromMiles(distance);
            }

            throw new Exception("No conversion possible, unit is not supported!");
        }

        private static double GetMilesFromKilometers(double distance)
        {
            return distance * OneKilometersToMiles;
        }
        
        private static double GetKilometersFromMiles(double distance)
        {
            return distance * OneMilesToKilometers;
        }

        private static DistanceUnit GetInvertUnit(DistanceUnit unit)
        {
            return unit == DistanceUnit.Kilometers ? DistanceUnit.Miles : DistanceUnit.Kilometers;
        }

        private static void ClearAllDistanceToConvert()
        {
            distancesToConvert = Array.Empty<double>();
            unitsDistancesToConvert = Array.Empty<DistanceUnit>();
        }
    }
}