using CalculationsLibrary;
using System;
using System.Globalization;
using System.Threading;

namespace SimpleCalculator
{
    class i18n
    {
        static void Main(string[] args)
        {
            while(true)
            {
               Console.WriteLine("Enter your language (en) / Entrez votre langue (fr)");
               String language = Console.ReadLine().Trim();

                if(language == "en" || language == "fr")
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
                    break;
                }
            }
          

            CalculatorEngine engine = new CalculatorEngine();

            double firstNumber = 0;
            while (true)
            {
                Console.WriteLine(Properties.Constants.FirstNumberRequest);
                string currentLine = Console.ReadLine().Trim();
                if (double.TryParse(currentLine, out firstNumber))
                {
                    break;
                }

                Console.WriteLine(Properties.Constants.FirstNumberTypeError);
            }

            double secondNumber = 0;
            while (true)
            {
                Console.WriteLine(Properties.Constants.SecondNumberRequest);
                string currentLine = Console.ReadLine().Trim();
                if (double.TryParse(currentLine, out secondNumber))
                {
                    break;
                }
                Console.WriteLine(Properties.Constants.SecondNumberTypeError);
            }

            string operation = null;
            while (true)
            {
                Console.WriteLine(Properties.Constants.OperatorRequest);
                string currentLine = Console.ReadLine().Trim();
                if (currentLine == "+" || currentLine == "-" || currentLine == "*" || currentLine == "/" ||
                  currentLine == "add" || currentLine == "subtract" || currentLine == "multiply" || currentLine == "divide" ||
                  currentLine == "plus" || currentLine == "moins" || currentLine == "multiplié par" || currentLine == "divisé par")
                {
                    operation = currentLine;
                    break;
                }
                Console.WriteLine(Properties.Constants.OperatorRequestError);
            }

            double result = engine.Calculate(operation, firstNumber, secondNumber);
            Console.WriteLine(Properties.Constants.Result + $" {firstNumber} {operation} {secondNumber} = {result:N2}");

        }
    }
}