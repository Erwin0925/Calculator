using System.Text.RegularExpressions;
using Calculator.Menu;

namespace Calculator.Basic_Function
{
    internal class Addition
    {
        public void Sum()
        {
            Console.Write("Please enter the numbers wanted to Sum below: (exp: 1+2+3+4...) : ");
            string str = Console.ReadLine();

            double result = 0;
            string pattern = @"^[\d\s\+\.]+$";

            if (str != null && Regex.IsMatch(str, pattern))
            {
                double[] nums = str.Split("+").Select(s => s.Trim()).Select(double.Parse).ToArray();
                foreach (double item in nums)
                {
                    result += item;
                }
                Console.WriteLine($"The result for {String.Join(" + ", nums)} is {result}");
                Console.WriteLine();
                History.Instance.StoreHistory(String.Join(" + ", nums )+ " = " + result);
                BasicFunctionMenu.ShowBasicFunctionMenu();
            }
            else
            {
                Console.WriteLine("There is an error in your input, Please try again");
                History.Instance.StoreHistory(str + "!! Bad Input");
                Sum();
            }
        }
    }
}
