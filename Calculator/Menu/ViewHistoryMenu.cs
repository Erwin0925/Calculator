using Calculator.Function;

namespace Calculator.Menu
{
    internal class ViewHistoryMenu
    {
        public void ChooseHistoryFunction()
        {
            Console.WriteLine("Please choose the function you want to perform");
            Console.WriteLine(" 1. -- View Histor\n 2. -- Clear History\n 3. -- Back to Main Menu");
            Console.Write("Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            HandleHistoryChoice(choice);
        }

        public void HandleHistoryChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    History.Instance.ShowHistory();
                    break;
                case 2:
                    History.Instance.ClearHistory();
                    break;
                case 3:
                    MainMenu.GetMenuChoice();
                    break;
                default:
                    Console.WriteLine("Please only choose choice in range of 1 - 3 only");
                    ChooseHistoryFunction();
                    break;
            }
        }
    }
}
