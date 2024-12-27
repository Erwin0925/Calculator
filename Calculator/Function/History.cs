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
            for (int i = 0; i < historyStack.Count; i++)
            {
                Console.WriteLine((i + 1) + " | " + historyStack.ElementAt(i));
            }
        }
    }
}
