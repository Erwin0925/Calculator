using Calculator.Menu;

namespace Calculator.Basic_Function
{
    internal class Multiplication
    {
        public void Multiply()
        {
            Console.Write("Please enter the numbers wanted to multiply below: (exp: 5*3*7*29...) : ");
            string str = Console.ReadLine();
            string pattern = @"^[\d\s\*\.]+$";

            if (str != null && System.Text.RegularExpressions.Regex.IsMatch(str, pattern))
            {
                double[] nums = str.Split("*").Select(x => Convert.ToDouble(x)).ToArray();
                double result = 1;
                foreach (double item in nums)
                {
                    result *= item;
                }
                Console.WriteLine($"The result for {String.Join(" x ", nums)} is {result}");
                Console.WriteLine();
                History.Instance.StoreHistory(String.Join(" x ", nums) + " = " + result);
                BasicFunctionMenu.ShowBasicFunctionMenu();
            }
            else
            {
                Console.WriteLine("There is an error in your input, Please try again");
                History.Instance.StoreHistory(str + "!! Bad Input");
                Multiply();
            }
        }
    }
}
