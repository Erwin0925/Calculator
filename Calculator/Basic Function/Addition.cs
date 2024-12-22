using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator.Basic_Function
{
    internal class Addition
    {
        public void Sum()
        {
            Console.Write("Please enter the numbers wanted to Sum below: (exp: 1+2+3+4...) : ");
            string str = Console.ReadLine();

            double result = 0;
            string pattern = @"^[\d+.]+$";

            if (str != null && Regex.IsMatch(str, pattern))
            {
                double[] nums = str.Split("+").Select(double.Parse).ToArray();
                foreach (double item in nums)
                {
                    result += item;
                }
                Console.WriteLine($"The result for {String.Join(" + ", nums)} is {result}");
                Program.ChooseFunction();
            }
            else
            {
                Console.WriteLine("There is an error in your input, Please try again");
                Sum();
            }
        }
    }
}
