namespace assignment2
{
    public class LowBudgetComputerFactory : IComputerFactory 
    {
        public Computer AssembleComputer()
        {
            return new Computer(new LowBudgetProcessor(), new LowBudgetHardDisk(), new LowBudgetMonitor());
        }

    }
}