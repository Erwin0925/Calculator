using Calculator.Basic_Function;

namespace Calculator.Menu
{
    internal class BasicFunctionMenu
    {
        public static void ShowBasicFunctionMenu()
        {
            int choice = ChooseFunction();
            HandleFunctionChoice(choice);
        }
        public static int ChooseFunction()
        {
            Console.WriteLine("Please Choose The Function you wanted to use enter the function no.");
            Console.WriteLine(" 1. -- Addition (+)\n 2. -- Subtraction (-)\n 3. -- Multiplication (*)\n 4. -- Division (/)\n 5. -- All Function(+,-,*,/)\n 6. -- Back to Menu");
            Console.Write("Your Choice : ");
            return Convert.ToInt32(Console.ReadLine()); 
        }

        public static void HandleFunctionChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Addition addition = new Addition();
                    addition.PerformOperation();
                    break;
                case 2:
                    Subtraction subtraction = new Subtraction();
                    subtraction.PerformOperation();
                    break;
                case 3:
                    Multiplication multiplication = new Multiplication();
                    multiplication.PerformOperation();
                    break;
                case 4:
                    Division division = new Division();
                    division.PerformOperation();
                    break;
                case 5:
                    AllFunction allFunction = new AllFunction();
                    allFunction.PerformOperation();
                    break;
                case 6:
                    MainMenu.GetMenuChoice();
                    break;
                default:
                    Console.WriteLine("Please only choose choice in range of 1 - 6 only");
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------");
                    break;
            }
        }
    }
}
