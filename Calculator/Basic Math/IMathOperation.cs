namespace Calculator.Basic_Math
{
    internal interface IMathOperation
    {
        public string GetInput()
        {
            Console.Write("Please enter your desired input");
            return Console.ReadLine();
        }
        public void PerformOperation();
    }
}
