namespace assignment1
{
    public class LowBudgetComputerShop : ComputerShop
    {
        public override Computer AssembleComputer()
        {
            return new Computer(new LowBudgetProcessor(), new LowBudgetHardDisk(), new LowBudgetMonitor());
        }
    }
}