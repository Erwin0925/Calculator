using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Menu;

namespace Calculator.Basic_Function
{
    internal class AllFunction
    {
        public void Calculate()
        {
            Console.Write("Please enter the numbers wanted to calculate below: (exp: (1*2+3)/4...) : ");
            string str = Console.ReadLine();

            string pattern = @"^[\d\s\+\-\*\/\.]+$";

            if (str != null && System.Text.RegularExpressions.Regex.IsMatch(str, pattern))
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(str, String.Empty);
                double output = Convert.ToDouble(result);

                Console.WriteLine($"The result for {str} is {result}");
                Console.WriteLine();
                History.Instance.StoreHistory(str + " = " + result);
                BasicFunctionMenu.ShowBasicFunctionMenu();
            }
            else
            {
                Console.WriteLine("There is an error in your input, Please try again");
                History.Instance.StoreHistory(str + "!! Bad Input");
                Calculate();
            }
        }
    }
}
