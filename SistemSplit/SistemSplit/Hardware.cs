namespace SistemSplit
{
    using System.Collections.Generic;

    public abstract class Hardware
    {
        private string type;
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

        public string Type
        {
            get { return this.type; }
            protected set { this.type = value; }  
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

        public Dictionary<string, Software> MapNameSoftware
        {
            get { return this.mapNameSoftware; }
            private set { this.mapNameSoftware = value; }
        }

        public int CalcMemoryConsumption()
        {
            int result = 0;
            foreach (var software in this.mapNameSoftware.Values)
            {
                result += software.MemoryConsumption;
            }
            return result;
        }

        public int CalcCapacityConsumption()
        {
            int result = 0;
            foreach (var software in this.mapNameSoftware.Values)
            {
                result += software.CapacityConsumption;
            }
            return result;
        }

        public int countExpessSoftware()
        {
            int result = 0;
            foreach (var software in MapNameSoftware.Values)
            {
                if (software.Type == "Express")
                {
                    result++;
                }
            }
            return result;
        }

        public int countLightSoftware()
        {
            int result = 0;
            foreach (var software in MapNameSoftware.Values)
            {
                if (software.Type == "Light")
                {
                    result++;
                }
            }
            return result;
        }

        public List<string> softwareNames()
        {
            List<string> softwares = new List<string>();
            foreach (var software in MapNameSoftware.Keys)
            {
                softwares.Add(software);
            }
            return softwares;
        }

        public int memoryInUse()
        {
            int result = 0;
            foreach (var software in mapNameSoftware.Values)
            {
                result += software.MemoryConsumption;
            }
            return result;
        }

        public int capacityInUse()
        {
            int result = 0;
            foreach (var software in mapNameSoftware.Values)
            {
                result += software.CapacityConsumption;
            }
            return result;
        }

    }
}
