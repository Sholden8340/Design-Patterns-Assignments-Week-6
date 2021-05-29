namespace assignment2
{
    public class Computer
    {
        public IProcessor Processor { get; set; }

        public IHardDisk HardDisk { get; set; }

        public IMonitor Monitor { get; set; }

        public Computer(IProcessor processor, IHardDisk hardDisk, IMonitor monitor)
        {
            Processor = processor;
            HardDisk = hardDisk;
            Monitor = monitor;
        }

        public void Test()
        {
            Processor.PerformOperation();
            HardDisk.StoreData();
            Monitor.Display();
        }
    }
}