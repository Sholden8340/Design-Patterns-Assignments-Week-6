namespace assignment2
{
    public class HighBudgetComputerFactory : IComputerFactory
    {
        public Computer AssembleComputer()
        {
            return new Computer(new HighBudgetProcessor(), new HighBudgetHardDisk(), new HighBudgetMonitor());
        }

    }
}