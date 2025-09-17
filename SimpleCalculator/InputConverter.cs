using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            bool isValid = double.TryParse(argTextInput, out double result);
            if (!isValid)
            {
                throw new ArgumentException("Not a valid number");
            }
            double numeric = double.Parse(argTextInput);
            return numeric;
        }
    }
}
