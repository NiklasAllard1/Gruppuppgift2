using System;
using System.Data;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Calculator");

        while(true)
        {
            Console.WriteLine("Enter an expression (ex. 1 + 2): ");
            string input = Console.ReadLine();

            try
            {
                double result = EvaluateException(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid expression. Error");
            }

            Console.WriteLine("Do you want to continue (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
            {
                break;
            }
        }
    }
