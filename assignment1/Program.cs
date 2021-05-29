using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        private void Start()
        {


            Console.WriteLine("[shop creating expensive computers]");

            ComputerShop expensiveComputerShop = new HighBudgetComputerShop();
            Computer expensiveComputer = expensiveComputerShop.AssembleComputer();
            expensiveComputer.Test();

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");

            ComputerShop cheapComputerShop = new LowBudgetComputerShop();
            Computer cheapComputer = cheapComputerShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}