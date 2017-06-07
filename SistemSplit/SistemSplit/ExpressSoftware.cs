namespace SistemSplit
{
    public class ExpressSoftware : Software
    {

        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption) 
            : base(name, capacityConsumption, memoryConsumption)
        {
            Type = "Express";
            this.MemoryConsumption = MemoryConsumption * 2;
        }
    }
}
