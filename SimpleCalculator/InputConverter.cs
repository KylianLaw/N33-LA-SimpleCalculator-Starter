using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        /*
        public static double ConvertInputToNumeric(string argTextInput, out Boolean state)
        {
            
           
              double result;
              try
              {
                  result = double.Parse(argTextInput);
                  state = true;
                  return result;
              }
              catch
              {

                  state = false;
                  return 0;
              }
             

        }
       */
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

    }
}


    

