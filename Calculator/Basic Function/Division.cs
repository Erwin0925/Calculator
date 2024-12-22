using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator.Basic_Function
{
    internal class Division
    {
        public void Devide()
        {
            Console.Write("Please enter the numbers wanted to devide below: (exp: 5/3/7/29...) : ");
            string str = Console.ReadLine();
            string pattern = @"^[\d/.]+$";

            if (str != null && Regex.IsMatch(str,pattern)) 
            {
                double[] nums = str.Split("/").Select(x => Convert.ToDouble(x)).ToArray();
                double result = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    result = result / nums[i];
                }
                Console.WriteLine(result);
                Program.ChooseFunction();
            }
            else
            {
                Console.WriteLine("There is an error in your input, Please try again");
                Devide();
            }
        }
    }
}
