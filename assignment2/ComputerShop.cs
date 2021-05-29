using System;

namespace assignment2
{
    public class ComputerShop
    {
        private IComputerFactory _computerFactory;
        public ComputerShop(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }

        public Computer AssembleComputer()
        {
            return _computerFactory.AssembleComputer();
        }
    }
}