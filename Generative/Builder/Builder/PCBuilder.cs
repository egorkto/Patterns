using System;

namespace Builder
{
    public class PCBuilder
    {
        private readonly PC pc = new PC();

        public PCBuilder AddCPU()
        {
            pc.AddCPU();
            return this;
        }

        public PCBuilder AddMotherboard()
        {
            pc.AddMotherboard();
            return this;
        }

        public PCBuilder AddCPUCooler()
        {
            pc.AddCPUCooler();
            return this;
        }

        public PCBuilder AddRAM()
        {
            pc.AddRAM();
            return this;
        }
        public PCBuilder AddPowerSupply()
        {
            pc.AddPowerSupply();
            return this;
        }

        public PCBuilder AddVideoCard()
        {
            pc.AddVideoCard();
            return this;
        }

        public PCBuilder AddHDD()
        {
            pc.AddHDD();
            return this;
        }

        public PCBuilder AddSSD()
        {
            pc.AddSSD();
            return this;
        }

        public PC Build()
        {
            if(pc.ReadyToWork())
            {
                return pc;
            }

            throw new Exception("ПК не готов к работе!");
        }
    }
}
