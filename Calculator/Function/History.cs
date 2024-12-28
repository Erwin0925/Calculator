using Calculator.Menu;

namespace Calculator.Function
{
    internal class History
    {
        private static History? instance;
        private Stack<string> historyStack;

        private History()
        {
            historyStack = new Stack<string>();
        }

        public static History Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new History();
                }
                return instance;
            }
        }

        public void StoreHistory(string record)
        {
            historyStack.Push(record);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Calculation History:");
            if (historyStack.Count == 0)
            {
                Console.WriteLine("No history available\nPress 1 to redict to Math Function Menu\nPress any other key back to View History Page");
                Console.Write("Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (choice == 1)
                {
                    BasicFunctionMenu.ChooseFunction();
                }
                else
                {
                    var viewHistoryMenu1 = new ViewHistoryMenu();
                    viewHistoryMenu1.ChooseHistoryFunction();
                }
            }
            for (int i = 0; i < historyStack.Count; i++)
            {
                Console.WriteLine((i + 1) + " | " + historyStack.ElementAt(i));
            }
            Console.WriteLine();
            var viewHistoryMenu = new ViewHistoryMenu();
            viewHistoryMenu.ChooseHistoryFunction();
        }

        public void ClearHistory()
        {
            historyStack.Clear();
            Console.WriteLine("Done Clearing All The History");
            Console.WriteLine();
            var viewHistoryMenu2 = new ViewHistoryMenu();
            viewHistoryMenu2.ChooseHistoryFunction();
        }
    }
}
