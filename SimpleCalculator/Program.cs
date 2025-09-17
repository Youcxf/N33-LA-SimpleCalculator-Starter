using CalculationsLibrary;
using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CalculatorEngine engine = new CalculatorEngine();

                double firstNumber = 0;
                while (true)
                {
                    Console.WriteLine("Enter the first number:");
                    string currentLine = Console.ReadLine().Trim();
                    if (double.TryParse(currentLine, out firstNumber))
                    { 
                        break; 
                    }
                        
                    Console.WriteLine("The first input needs to be a number (e.g 6, 7, 8, ...)");
                }

                double secondNumber = 0;
                while (true)
                {
                    Console.WriteLine("Enter the second number:");
                    string currentLine = Console.ReadLine().Trim();
                    if (double.TryParse(currentLine, out secondNumber))
                    {
                        break;
                    }
                    Console.WriteLine("The second input needs to be a number (e.g 6, 7, 8, ...)");
                }

                string operation = null;
                while (true)
                {
                    Console.WriteLine("Enter the operator (+, -, *, /, add, subtract, multiply, divide):");
                    string currentLine = Console.ReadLine().Trim();
                    if (currentLine == "+" || currentLine == "-" || currentLine == "*" || currentLine == "/" ||
                        currentLine == "add" || currentLine == "subtract" || currentLine == "multiply" || currentLine == "divide")
                    {
                        operation = currentLine;
                        break;
                    }
                    Console.WriteLine("The operator is not valid. It must be one of the following (+, -, *, /, add, subtract, multiply, divide).");
                }

                double result = engine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} is : {result:N2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
