using System;

namespace SimpleCalculator
{
    public class InputConverter
    {  
        public static double ConvertInputToNumeric(string argTextInput, out bool success)
        {
            double value;
            success = double.TryParse(argTextInput, out value);
            if (argTextInput == null)
            {
                value = 0;
                Console.WriteLine("the user have to input something");
            }
            if (success)
            {
                return value;
            }
            else
            {
                return 0;
            }
        }
        public static bool ValidOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "add":
                case "subtract":
                case "multiply":
                case "divide":
                    return true;

                default:
                    Console.WriteLine("Wrong symbol");
                    return false;
            }
        }
    }
}


    

