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