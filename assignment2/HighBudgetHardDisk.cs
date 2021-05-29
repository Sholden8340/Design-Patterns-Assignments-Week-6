using System;

namespace assignment2
{
    public class HighBudgetHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data very quickly...");
        }
    }
}