namespace Builder
{
    public class OfficePCFabric : IPCFabric
    {
        public PC Create()
        {
            var pc = new PCBuilder()
                .AddCPU()
                .AddMotherboard()
                .AddPowerSupply()
                .AddCPUCooler()
                .AddHDD()
                .AddRAM()
                .Build();

            return pc;
        }
    }
}
