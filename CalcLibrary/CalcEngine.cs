using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public class CalcEngine
    {

        public static double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;


            switch (argOperation)
            {
                case "+":
                case "add":
                case "plus":
                    result = argFirstNumber + argSecondNumber;
                    break;


                case "-":
                case "substract":
                case "moins":
                    result = argFirstNumber - argSecondNumber;
                    break;


                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;


                case "/":
                case "divide":
                    if (argSecondNumber != 0)
                    {

                        result = argFirstNumber / argSecondNumber;
                    }
                    else
                        throw new DivideByZeroException("can't divide by zero");

                    break;


                default:
                    throw new InvalidOperationException("Invalid");

            }

            return result;
        }
    }


}

