using System.Data;
using System.Text.RegularExpressions;
using Calculator.Basic_Math;
using Calculator.Function;
using Calculator.Menu;

namespace Calculator.Basic_Function
{
    internal class AllFunction : IMathOperation
    {
        public string GetInput()
        {
            string pattern = @"^[\d\s\+\-\*\/\.]+$";
            Console.Write("Please enter the numbers wanted to calculate below: (exp: (1*2+3)/4...) : ");
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
            DataTable dt = new DataTable();
            var result = dt.Compute(str, String.Empty);
            double output = Convert.ToDouble(result);
            Console.WriteLine($"The result for {str} is {result}");
            Console.WriteLine();
            History.Instance.StoreHistory(str + " = " + result);
            BasicFunctionMenu.ShowBasicFunctionMenu();
        }
    }
}
