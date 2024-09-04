using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public static double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            
            switch (argOperation)
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;


                case "-":
                case "substract":
                    result = argFirstNumber - argSecondNumber;
                    break;


                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;


                case "/":
                case "divide":
                    if(argSecondNumber != 0) {

                        result = argFirstNumber / argSecondNumber;
                    }
                    else
                        throw new DivideByZeroException("can't divide by zero");

                    break;


                default :
                    throw new InvalidOperationException("Invalid");
                    
            }

            return result;
        }
    }
}
