namespace SistemSplit
{
    using System.Collections.Generic;

    public abstract class Hardware
    {
        private string name;
        private int maxCapacity;
        private int maxMemory;
        Dictionary<string, Software> mapNameSoftware;

        protected Hardware(string name,int maxCapacity,int maxMemory)
        {
            this.name = name;
            this.maxCapacity = maxCapacity;
            this.maxMemory = maxMemory;
            this.mapNameSoftware = new Dictionary<string, Software>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int MaxCapacity
        {
            get { return this.maxCapacity; }
            set { this.maxCapacity = value; }
        }

        public int MaxMemory
        {
            get { return this.maxMemory; }
            set { this.maxMemory = value; }
        }
    }
}
