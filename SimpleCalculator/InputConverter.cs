using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
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
       
    }
}
