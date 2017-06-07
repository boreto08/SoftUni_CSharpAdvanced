namespace SistemSplit
{
    public class PowerHardware : Hardware
    {
        public PowerHardware(string name, int maxCapacity, int maxMemory)
            : base(name, maxCapacity, maxMemory)
        {
            Type = "Power";
            this.MaxCapacity = MaxCapacity - (MaxCapacity * 75 / 100);
            this.MaxMemory = MaxMemory + (MaxMemory * 75 / 100);
        }
    }
}

