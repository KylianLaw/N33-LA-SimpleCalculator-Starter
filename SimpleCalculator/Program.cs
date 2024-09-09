using System;
using System.Data;
using CalcLibrary;
namespace SimpleCalculator
{
    class Program
    {

        static bool ValidOperation(string operation)
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
        static void Main(string[] args)
        {
            try
            {

                // Class to perform actual calculations
               
                //CalculatorEngine calculatorEngine = new CalculatorEngine();
                Boolean work = false;
                double firstNumber= 0;
                double secondNumber = 0;
                string operation = "";
                while (work == false)
                {
                    Console.WriteLine("Enter a first value");
                    firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine(), out work);
                    switch (work) {

                        case true:
                            break;
                        case false:
                            Console.WriteLine("the conversion as failed, enter a valid number");
                            break;
                    }
                
                }
                work = false;
                while (work == false)
                {
                    Console.WriteLine("Enter a second value");
                     secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine(), out work);
                    switch (work)
                    {

                        case true:
                            break;
                        case false:
                            Console.WriteLine("the conversion as failed, enter a valid number");
                            break;
                    }
                }
                work = false;
               while (work == false) {
                    Console.WriteLine("Enter a operation symbol");
                    operation = Console.ReadLine();
                    work = ValidOperation(operation);
                    switch (work)
                    {
                        case true:
                            break;
                        case false:
                            Console.WriteLine("the conversion as failed, enter a valid operation");
                            break;
                    }
                    
                }

               


                double result =CalcEngine.Calculate(operation, firstNumber, secondNumber);

                
                Console.WriteLine("The value {0} {1} the value {2} equals to {3:.##}", firstNumber, operation, secondNumber, result);
               Console.ReadKey();
            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
