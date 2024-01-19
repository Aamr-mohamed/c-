using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Calculator enter 1\n For Complete Numbers enter 2");
            string progChoice=Console.ReadLine();
            switch(progChoice)
            {
                case "1":
                    Calculator();
                    break;
                case "2":
                    CompleteNumbers();
                    break;
            }
        }

        static void CompleteNumbers()
        {
            Console.WriteLine("Please enter your number! \n");
            string compNum=Console.ReadLine();
            if(int.TryParse(compNum,out int num))
            {
                NumProg(num);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            
        }
        static void NumProg(int num)
        {
            int progress = 0;
            for(int i = 0; i < num;i++)
            {
                if (progress < num)
                {
                progress += i;
                    Console.WriteLine($"Your number progress is:{container}");
                }
                else
                {
                    break;
                }
            Console.WriteLine(i);
            }
        }


        static void Calculator()
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
