using System;

namespace ex_2_2_2_degrees_fahrenheit
{
    enum TemperatureUnit
    {
        Celsius,
        Fahrenheit
    }
    
    internal static class Program
    {
        private const string CommandConversion = "convert";
        private const string CommandExit = "quit";
        private const string TemperatureUnitCelsiusShort = "C";
        private const string TemperatureUnitCelsiusLong = "Celsius";
        private const string TemperatureUnitFahrenheitShort = "F";
        private const string TemperatureUnitFahrenheitLong = "Fahrenheit";
        private const char TemperatureUnitSpecialChar = '°';
        private const int TemperatureCelsiusMin = -273;
        private const int TemperatureCelsiusMax = 5000000;
        private const int TemperatureFahrenheitMin = -459;
        private const int TemperatureFahrenheitMax = 5000000;

        public static void Main(string[] args)
        {
            string userCommand;
            
            Console.WriteLine("Program for convert Celsius <-> Fahrenheit.");
            Program.ShowHelpMessage();

            do
            {
                try
                {
                
                    userCommand = Program.GetValidUserCommand();

                    if (Program.IsUserWantExit(userCommand))
                    {
                        Program.ExitProgram();
                    }
                    else if (Program.IsUserWantConvert(userCommand))
                    {
                        Program.MakeRangeTemperatureUserConversion();        
                    }
                    else
                    {
                        throw new Exception("The command does not exist !");
                    }
                
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error : {error.Message}");
                    Program.ShowHelpMessage();
                }
            } while (true);
        }

        private static void ShowHelpMessage()
        {
            Console.WriteLine($"\"{Program.CommandConversion}\" to ask temperature conversion.");
            Console.WriteLine($"\"{Program.CommandExit}\" to quit the application.");
        }

        /// <summary>
        /// Ask a command to user with showing prompt
        /// </summary>
        /// <returns>The user command but without checking</returns>
        private static string GetUserCommand()
        {
            Console.Write("Command : ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Ask a command to user and checking if the command exist and is valid
        /// </summary>
        /// <returns>The user command which is valid</returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        private static string GetValidUserCommand()
        {
            string userCommand = Program.GetUserCommand();
            
            if (String.IsNullOrWhiteSpace(userCommand))
            {
                throw new NullReferenceException("You need to enter a command.");
            }

            if (!(
                userCommand == CommandConversion |
                userCommand == CommandExit))
            {
                throw new NotImplementedException("The command does not exist.");
            }

            return userCommand;
        }

        /// <summary>
        /// Check if user want to exit program
        /// </summary>
        /// <param name="userCommand">The user command</param>
        /// <returns></returns>
        private static bool IsUserWantExit(string userCommand)
        {
            return userCommand == Program.CommandExit;
        }

        /// <summary>
        /// Exit normally the program.
        /// </summary>
        private static void ExitProgram()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Check if user want convert a temperature
        /// </summary>
        /// <param name="userCommand">The user command to check</param>
        /// <returns></returns>
        private static bool IsUserWantConvert(string userCommand)
        {
            return userCommand == Program.CommandConversion;
        }

        /// <summary>
        /// Ask user a range of temperature for making conversion, with minimal and maximal temperature 
        /// </summary>
        private static void MakeRangeTemperatureUserConversion()
        {
            TemperatureUnit temperatureUnit;
            int minimalTemperature;
            int maximalTemperature;

            temperatureUnit = Program.GetUserTemperatureUnitToConvert();
            minimalTemperature = Program.GetMinimalTemperature(temperatureUnit);
            maximalTemperature = Program.GetMaximalTemperature(temperatureUnit, minimalTemperature);

            Program.ShowRangeTemperatureConverted(temperatureUnit, minimalTemperature, maximalTemperature);
        }

        /// <summary>
        /// Show all temperature converted between minimalTemperature and maximalTemperature
        /// </summary>
        /// <param name="originalUnit"></param>
        /// <param name="minimalTemperature"></param>
        /// <param name="maximalTemperature"></param>
        private static void ShowRangeTemperatureConverted(
            TemperatureUnit originalUnit, int minimalTemperature, int maximalTemperature)
        {
            TemperatureUnit unitConverted;
            double temperatureConverted;
                
            unitConverted = Program.GetInvertTemperatureUnit(originalUnit);
            
            for (int intermediateTemperature = minimalTemperature;
                intermediateTemperature <= maximalTemperature;
                intermediateTemperature++)
            {
                temperatureConverted = ConvertTemperature(
                    intermediateTemperature, originalUnit, unitConverted);
                
                Console.Write(intermediateTemperature + " ");
                Console.Write(Program.ConvertTemperatureUnit(originalUnit) + " ");
                Console.Write("= ");
                Console.Write(temperatureConverted + " ");
                Console.WriteLine(Program.ConvertTemperatureUnit(unitConverted));
            }
        }

        private static double ConvertTemperature(int currentTemperature, TemperatureUnit currentUnit, TemperatureUnit convertUnit)
        {
            if (currentUnit == TemperatureUnit.Celsius & convertUnit == TemperatureUnit.Fahrenheit)
            {
                return Program.ConvertTemperatureCelsiusToFahrenheit(currentTemperature);
            }
            if (currentUnit == TemperatureUnit.Fahrenheit & convertUnit == TemperatureUnit.Celsius)
            {
                return Program.ConvertTemperatureFahrenheitToCelsius(currentTemperature);
            }

            throw new Exception("This current unit or the unit to convert is not supported");
        }

        /// <summary>
        /// Convert a temperature in celsius to fahrenheit
        /// </summary>
        /// <param name="temperature">Temperature in celsius to convert</param>
        /// <returns>A temperature in fahrenheit</returns>
        private static double ConvertTemperatureCelsiusToFahrenheit(int temperature)
        {
            return (double) temperature * ((double) 9 / 5) + 32;
        }

        /// <summary>
        /// Convert a temperature in fahrenheit to celsius
        /// </summary>
        /// <param name="temperature">Temperature in fahrenheit to convert</param>
        /// <returns>A temperature in celsius</returns>
        private static double ConvertTemperatureFahrenheitToCelsius(int temperature)
        {
            return ((double) temperature - 32) * (double) 5 / 9;
        }

        /// <summary>
        /// Get the other temperature unit 
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        private static TemperatureUnit GetInvertTemperatureUnit(TemperatureUnit unit)
        {
            return unit == TemperatureUnit.Celsius ? TemperatureUnit.Fahrenheit : TemperatureUnit.Celsius;
        }

        /// <summary>
        /// Get the current temperature unit for making conversion
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static TemperatureUnit GetUserTemperatureUnitToConvert()
        {
            string userUnit;
            
            Console.WriteLine("Please enter your temperature unit (C or F)");
            userUnit = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userUnit))
            {
                throw new Exception("You need to define an unit");
            }

            return ConvertTemperatureUnit(userUnit);
        }

        /// <summary>
        /// Return temperature unit with correct type from string
        /// </summary>
        /// <param name="unitInString">Unit in string to convert to the correct type</param>
        /// <returns>The correct enumeration of the temperature unit</returns>
        /// <exception cref="NotSupportedException">The unit does not exist</exception>
        private static TemperatureUnit ConvertTemperatureUnit(string unitInString)
        {
            switch (unitInString.Trim().ToUpper())
            {
                case Program.TemperatureUnitCelsiusShort: return TemperatureUnit.Celsius;
                case Program.TemperatureUnitFahrenheitShort: return TemperatureUnit.Fahrenheit;
                default: throw new NotSupportedException("This temperature unit does not exist.");
            }
        }
        
        /// <summary>
        /// Return temperature unit to string format
        /// </summary>
        /// <param name="unit">The temperature unit to get in string</param>
        /// <param name="shortForm">Choose between short and long form. Example : C° and Celsius</param>
        /// <returns>The unit in string format</returns>
        /// <exception cref="NotSupportedException"></exception>
        private static string ConvertTemperatureUnit(TemperatureUnit unit, bool shortForm = true)
        {
            if (shortForm)
            {
                switch (unit)
                {
                    case TemperatureUnit.Celsius:
                        return Program.TemperatureUnitSpecialChar + Program.TemperatureUnitCelsiusShort;
                    case TemperatureUnit.Fahrenheit:
                        return Program.TemperatureUnitSpecialChar + Program.TemperatureUnitFahrenheitShort;
                    default: throw new NotSupportedException("This temperature unit does not exist.");
                }
            }
            switch (unit)
            {
                case TemperatureUnit.Celsius: return Program.TemperatureUnitCelsiusLong;
                case TemperatureUnit.Fahrenheit: return Program.TemperatureUnitFahrenheitLong;
                default: throw new NotSupportedException("This temperature unit does not exist.");
            }
        }

        /// <summary>
        /// Check if the temperature does not exceed the limit values, depending on the unit.
        /// </summary>
        /// <param name="temperature">Temperature to check the limit</param>
        /// <param name="temperatureUnit">The unit that will define the limits</param>
        /// <returns>Return if the temperature does not exceed the limit</returns>
        /// <exception cref="NotSupportedException"></exception>
        private static bool IsDoesNotExceedTemperatureLimit(int temperature, TemperatureUnit temperatureUnit)
        {
            switch (temperatureUnit)
            {
                case TemperatureUnit.Celsius:
                    return temperature >= Program.TemperatureCelsiusMin & temperature <= Program.TemperatureCelsiusMax;
                case TemperatureUnit.Fahrenheit:
                    return temperature >= Program.TemperatureFahrenheitMin & temperature <= TemperatureFahrenheitMax;
                default:
                    throw new NotSupportedException("The unit is not supported");
            }
        }

        /// <summary>
        /// Ask user the maximal temperature for show all conversion between minimal and this temperature
        /// </summary>
        /// <param name="temperatureUnit">Unit of temperature</param>
        /// <param name="minimalTemperature">The minimal temperature for checking if user enter a bigger temperature</param>
        /// <returns>Temperature bigger than minimal temperature</returns>
        /// <exception cref="Exception"></exception>
        private static int GetMaximalTemperature(TemperatureUnit temperatureUnit, int minimalTemperature)
        {
            int maximalTemperature;

            maximalTemperature = GetTemperatureFromUser($"Please enter the maximal temperature (bigger than {minimalTemperature}) :", temperatureUnit);

            if (maximalTemperature <= minimalTemperature)
            {
                throw new Exception($"The maximal temperature has to be bigger than {minimalTemperature}");
            }

            return maximalTemperature;
        }
        
        /// <summary>
        /// Ask user the minimal temperature for show all conversion between this temperature and maximal temperature
        /// </summary>
        /// <param name="temperatureUnit">Unit of temperature</param>
        /// <returns>First temperature for conversion</returns>
        private static int GetMinimalTemperature(TemperatureUnit temperatureUnit)
        {
            int minimalTemperature;

            minimalTemperature = GetTemperatureFromUser("Please enter the minimal temperature :", temperatureUnit);
            
            return minimalTemperature;
        }

        /// <summary>
        /// Ask user for temperature in specific unit
        /// </summary>
        /// <param name="message"></param>
        /// <param name="temperatureUnit"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static int GetTemperatureFromUser(string message, TemperatureUnit temperatureUnit)
        {
            int temperature;

            temperature = GetIntFromUser(message);

            if (!IsDoesNotExceedTemperatureLimit(temperature, temperatureUnit))
            {
                switch (temperatureUnit)
                {
                    case TemperatureUnit.Celsius:
                        throw new Exception(
                            $"The temperature is not correct : it exceed limit (between {TemperatureCelsiusMin} and {TemperatureCelsiusMax}"
                            );
                    case TemperatureUnit.Fahrenheit:
                        throw new Exception(
                            $"The temperature is not correct : it exceed limit (between {TemperatureFahrenheitMin} and {TemperatureFahrenheitMax}"
                            );
                    default:
                        throw new Exception("The temperature is not correct");
                }
            }
            
            return temperature;
        }
        
        /// <summary>
        /// Ask a correct int number to the user
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        private static int GetIntFromUser(string message)
        {
            string userEntry;
            int userInt;
            bool hasParse;
            
            Console.WriteLine(message);
            userEntry = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userEntry))
            {
                throw new NullReferenceException("you need to enter a number");
            }

            hasParse = int.TryParse(userEntry, out userInt);
            if (!hasParse)
            {
                throw new InvalidCastException("please enter a correct number, without decimal");
            }

            return userInt;
        }
    }
}