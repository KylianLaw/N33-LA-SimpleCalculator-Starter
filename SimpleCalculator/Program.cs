using System;
using System.Data;
using CalcLibrary;
namespace SimpleCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
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
                    work = InputConverter.ValidOperation(operation);
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
               Console.WriteLine($"The value {firstNumber} {operation} the value {secondNumber} equals to {result:.##}");
               Console.ReadKey();
            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }
        }
    }
}
