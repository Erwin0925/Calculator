namespace Calculator.Menu
{
    internal class MainMenu
    {
        public static void GetMenuChoice()
        {
            int choice = Greating();
            MainMenu.HandleMainChoice(choice);
        }
        public static int Greating()
        {
            Console.WriteLine("Welcome to the Calculator Program ~ ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Please Choose The Function you wanted to use by entering their no.");
            Console.WriteLine(" 1. -- Math Basic Operator\n 2. -- View History\n 3. -- Exit");
            Console.Write("Your Choice : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void HandleMainChoice(int choice1)
        {
            switch (choice1)
            {
                case 1:
                    int choice2 = BasicFunctionMenu.ChooseFunction();
                    BasicFunctionMenu.HandleFunctionChoice(choice2);
                    break;
                case 2:
                    History.Instance.ShowHistory();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please only choose choice in range of 1 - 3 only");
                    GetMenuChoice();
                    break;
            }
        }
    }
}
