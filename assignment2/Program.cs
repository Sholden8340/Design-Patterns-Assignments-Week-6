using System;

namespace assignment2
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

            ComputerShop expensiveComputerShop = new ComputerShop(new HighBudgetComputerFactory());
            Computer expensiveComputer = expensiveComputerShop.AssembleComputer();
            expensiveComputer.Test();

            Console.WriteLine();

            Console.WriteLine("[shop creating cheap computers]");

            ComputerShop cheapComputerShop = new ComputerShop(new LowBudgetComputerFactory());
            Computer cheapComputer = cheapComputerShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}