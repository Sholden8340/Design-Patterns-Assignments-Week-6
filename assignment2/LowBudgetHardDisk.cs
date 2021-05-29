using System;

namespace assignment2
{
    public class LowBudgetHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data not so quickly...");
        }
    }
}