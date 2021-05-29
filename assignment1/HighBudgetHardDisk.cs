using System;

namespace assignment1
{
    public class HighBudgetHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data very quickly...");
        }
    }
}