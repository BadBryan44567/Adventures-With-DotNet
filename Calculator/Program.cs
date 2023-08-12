﻿// See https://aka.ms/new-console-template for more information

namespace Calculator;

class Program
{
    private static void Main(string[] args)
    {
        var b = 0;
        Operations operations = new Operations();
        
        Console.WriteLine("Welcome to Calculator! ");
        Console.WriteLine("Here are available options:\n" +
                          "1. Add (+)\n" +
                          "2. Subtract (-)\n" +
                          "3. Multiply (*)\n" +
                          "4. Divide (/)\n");
        var ch = Console.ReadLine();
        
       Console.WriteLine("Enter First Number ( Operand ): ");
       var numInput1 = Console.ReadLine();
       var a = int.Parse(numInput1!);
       
       Console.WriteLine("Enter Second Number ( Operand ): ");
       var numInput2 = Console.ReadLine();

       try
       {
           if (numInput2 != null) b = int.Parse(numInput2);
       }
       catch (FormatException e)
       {
           Console.WriteLine("Error occured: " + e.Message);
       }
       
        switch (ch)
        {
            case "+": 
                Console.WriteLine("Result is: " + operations.Add(a, b));
                break;
            case "-": 
                Console.WriteLine("Result is: " + operations.Subtract(a, b));
                break;
            case "*": 
                Console.WriteLine("Result is: " + operations.Multiply(a, b));
                break;
            case "/":
                try
                {
                    var result = operations.Division(a, b);
                    Console.WriteLine("Result is: " + result);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                break;
            default: 
                Console.WriteLine("Runtime Exception x000001: Invalid Operation");
                break;
        }
    }
}

class Operations
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Division(double a, double b)
    {
        return a / b;
    }
}