namespace Builder
{
    public class PC
    {
        public bool CPU { get; private set; }
        public bool Motherboard { get; private set; }
        public bool CPUCooler { get; private set; }
        public bool RAM { get; private set; }
        public bool PowerSupply { get; private set; }
        public bool VideoCard { get; private set; }
        public bool HDD { get; private set; }
        public bool SSD { get; private set; }

        public void AddCPU()
        {
            CPU = true;
        }

        public void AddMotherboard()
        {
            Motherboard = true;
        }

        public void AddCPUCooler()
        {
            CPUCooler = true;
        }

        public void AddRAM()
        {
            RAM = true;
        }
        public void AddPowerSupply()
        {
            PowerSupply = true;
        }

        public void AddVideoCard()
        {
            VideoCard = true;
        }

        public void AddHDD()
        {
            HDD = true;
        }

        public void AddSSD()
        {
            SSD = true;
        }

        public bool ReadyToWork()
        {
            return CPU && Motherboard && CPUCooler && PowerSupply && RAM && (SSD || HDD);
        }

        public override string ToString()
        {
            return $" CPU: {CPU} \n RAM: {RAM} \n Motherboard: {Motherboard} \n PowerSupply: {PowerSupply} \n CPU cooler: {CPUCooler} \n HDD: {HDD} \n SSD: {SSD} \n Video card: {VideoCard}";
        }
    }
}
