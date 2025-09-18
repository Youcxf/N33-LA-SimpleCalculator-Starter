using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLibrary
{
    public class CalculatorEngine
    {
        public double? Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double? result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add" || argOperation.ToLower() == "plus")
            {
                result = argFirstNumber + argSecondNumber;
            }
            else if (argOperation == "-" || argOperation.ToLower() == "subtract" || argOperation.ToLower() == "moins")
            {
                result = argFirstNumber - argSecondNumber;
            }
            else if (argOperation == "*" || argOperation.ToLower() == "multiplied by" || argOperation.ToLower() == "multiplié par")
            {
                result = argFirstNumber * argSecondNumber;
            }
            else if (argOperation == "/" || argOperation.ToLower() == "divided by" || argOperation.ToLower() == "divisé par")
            {
                //try
                //{
                //    result = argFirstNumber / argSecondNumber;
                //}
                //catch (DivideByZeroException) 
                //{
                //    result = null;
                //}

                if (argSecondNumber == 0)
                {
                    result = null;
                }
                else
                {
                    result = argFirstNumber / argSecondNumber;
                }

            }

            return result;
        }
    }
}