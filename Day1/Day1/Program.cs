using System;

namespace Day1
{
    internal class Program
    {
       static void Main(string[] args)
        {
            
            Console.WriteLine("Hello human \n Please enter your first number \n");
           string firstNum = Console.ReadLine();

            Console.WriteLine("Please enter your second number \n");
           string secondNum = Console.ReadLine();

            Console.WriteLine("Please choose your operator (+,-,*,/) \n");
           string operatorr = Console.ReadLine();

            if (double.TryParse(firstNum, out double x) && double.TryParse(secondNum, out double y))
            {
                Calculation(x, y, operatorr);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numeric values.");
            }
        }

        static void Calculation(double x, double y, string operatorr)
        {
            switch (operatorr) { 
             case "*":
                Multiply(x, y);
                break;
            case "+":
                Add(x, y);
                break;
            case "-":
                Subtract(x, y);
                break;
            case "/":
                if (y != 0)
                {
                    Divide(x, y);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                break;
            }
        }



        static void Multiply( double x,double y )

        {
            Console.WriteLine($"The result is equal {x * y}");
        }
        static void Divide( double x, double y)
        {
            Console.WriteLine($"The result is equal {x / y}") ;
        }
        
        static void Subtract( double x, double y )
        {
            Console.WriteLine($"The result is equal {x - y}") ;
        }
        
        static void Add(double x, double y)
        {
            Console.WriteLine($"The result is equal {x + y}") ;
        }
    }
}
