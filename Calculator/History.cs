namespace Calculator
{
    internal class History
    {
        private static History? instance;
        private List<string> historyList;

        private History()
        {
            historyList = new List<string>(); 
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
            historyList.Add(record);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Calculation History:");
            foreach (var record in historyList)
            {
                Console.WriteLine(record);
            }
        }
    }
}
