namespace assignment1
{
    public class HighBudgetComputerShop : ComputerShop
    {
        public override Computer AssembleComputer()
        {
            return new Computer(new HighBudgetProcessor(), new HighBudgetHardDisk(), new HighBudgetMonitor());
        }
    }
}