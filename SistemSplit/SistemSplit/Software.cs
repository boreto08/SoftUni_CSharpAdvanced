namespace SistemSplit
{
    public abstract class Software
    {
        private string name;
        private int capacityConsumption;
        private int memoryConsumption;


        protected Software(string name,int capacityConsumption,int memoryConsumption)
        {
            this.name = name;
            this.capacityConsumption = capacityConsumption;
            this.memoryConsumption = memoryConsumption;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int CapacityConsumption
        {
            get { return this.capacityConsumption; }
            set { this.capacityConsumption = value; }
        }

        public int MemoryConsumption
        {
            get { return this.memoryConsumption; }
            set { this.memoryConsumption = value; }
        }
    }
}
