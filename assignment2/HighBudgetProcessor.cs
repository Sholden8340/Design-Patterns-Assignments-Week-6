using System;

namespace assignment2
{
    public class HighBudgetProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("performing operation very quickly...");
        }
    }
}