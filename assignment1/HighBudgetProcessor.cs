using System;

namespace assignment1
{
    public class HighBudgetProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("performing operation very quickly...");
        }
    }
}