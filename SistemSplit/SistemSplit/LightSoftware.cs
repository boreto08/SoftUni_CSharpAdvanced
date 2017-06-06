namespace SistemSplit
{
    public class LightSoftware : Software
    {
        public LightSoftware(string name, int capacityConsumption, int memoryConsumption) 
            : base(name, capacityConsumption, memoryConsumption)
        {
            this.CapacityConsumption = CapacityConsumption + (CapacityConsumption * 50 / 100);
            this.MemoryConsumption = MemoryConsumption - (MemoryConsumption * 50 / 100);
        }
    }
}
