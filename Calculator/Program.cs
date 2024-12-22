using System;
using System.Data;
using Calculator.Basic_Function;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Greating();
            int choice = ChooseFunction();

            switch (choice)
            {
                case 1:
                    Addition addition = new Addition();
                    addition.Sum();
                    break;
                case 4:
                    Division division = new Division();
                    division.Devide();
                    break;
                case 5:
                    AllFunction allFunction = new AllFunction();
                    allFunction.Calculate();
                    break;

                default:
                    Console.WriteLine("Please only choose choice in range of 1 - 5 only");
                    break;
            }
        }

        public static void Greating()
        {
            Console.WriteLine("Welcome to the Calculator Program ~ ");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public static int ChooseFunction()
        {
            Console.WriteLine("Please Choose The Function you wanted to use enter the function no.");
            Console.WriteLine(" 1. -- Addition (+)\n 2. -- Subtraction (-)\n 3. -- Multiplication (*)\n 4. -- Division (/)\n 5. -- All Function(+,-,*,/)");
            Console.Write("Your Choice : ");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
