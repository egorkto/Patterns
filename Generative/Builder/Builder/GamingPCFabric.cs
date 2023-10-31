namespace Builder
{
    public class GamingPCFabric : IPCFabric
    {
        public PC Create()
        {
            var pc = new PCBuilder()
                .AddCPU()
                .AddMotherboard()
                .AddPowerSupply()
                .AddCPUCooler()
                .AddSSD()
                .AddHDD()
                .AddRAM()
                .AddVideoCard()
                .Build();

            return pc;
        }
    }
}
