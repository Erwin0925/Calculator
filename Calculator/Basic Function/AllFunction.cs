using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Basic_Function
{
    internal class AllFunction
    {
        public void Calculate()
        {
            Console.Write("Please enter the numbers wanted to calculate below: (exp: (1*2+3)/4...) : ");
            string input = Console.ReadLine();

            DataTable dt = new DataTable();
            var result = dt.Compute(input, String.Empty);
            double output = Convert.ToDouble(result);

            Console.WriteLine(output);
        }
    }
}
