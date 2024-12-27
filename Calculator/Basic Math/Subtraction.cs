using System.Text.RegularExpressions;
using Calculator.Basic_Math;
using Calculator.Function;
using Calculator.Menu;

namespace Calculator.Basic_Function
{
    internal class Subtraction : IMathOperation
    {
        public string GetInput()
        {
            string pattern = @"^[\d\s\-\.]+$";
            Console.Write("Please enter the numbers wanted to subtract below: (exp: 5-3-7-29...) : ");
            string str = Console.ReadLine();
            if (str != null && Regex.IsMatch(str, pattern))
            {
                return str;
            }
            else
            {
                Console.WriteLine("There is an error in your input, Please try again");
                History.Instance.StoreHistory(str + "!! Bad Input");
                return GetInput();
            }
        }

        public void PerformOperation()
        {
            string str = GetInput();
            double[] nums = str.Split("-").Select(x => Convert.ToDouble(x)).ToArray();
            double result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result = result - nums[i];
            }
            Console.WriteLine($"The result for {String.Join(" - ", nums)} is {result}");
            Console.WriteLine();
            History.Instance.StoreHistory(String.Join(" - ", nums) + " = " + result);
            BasicFunctionMenu.ShowBasicFunctionMenu();
        }
    }
}
