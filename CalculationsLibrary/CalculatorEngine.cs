using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLibrary
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add" || argOperation.ToLower() == "plus")
            {
                result = argFirstNumber + argSecondNumber;
            }
            else if (argOperation == "-" || argOperation.ToLower() == "subtract" || argOperation.ToLower() == "moins")
            {
                result = argFirstNumber - argSecondNumber;
            }
            else if (argOperation == "*" || argOperation.ToLower() == "multiply" || argOperation.ToLower() == "multiplié par")
            {
                result = argFirstNumber * argSecondNumber;
            }
            else if (argOperation == "/" || argOperation.ToLower() == "divide" || argOperation.ToLower() == "divisé par")
            {
                try
                {
                    result = argFirstNumber / argSecondNumber;
                }
                catch (DivideByZeroException)
                {
                    throw new DivideByZeroException("Cannot divide by zero / Division par 0 est impossible");
                }
            }

            return result;
        }
    }
}