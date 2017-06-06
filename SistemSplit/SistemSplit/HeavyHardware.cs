namespace SistemSplit
{
    public class HeavyHardware : Hardware
    {
        public HeavyHardware(string name, int maxCapacity, int maxMemory) 
            : base(name, maxCapacity, maxMemory)
        {
            this.MaxMemory = MaxMemory - (MaxMemory * 25 / 100);
            this.MaxCapacity = MaxCapacity * 2;
        }
    }
    }
}
