﻿
namespace RawData
{
    public class Tire
    {
        public Tire(int tireAge, double tirePressure)
        {
            this.TireAge = tireAge;
            this.TirePressure = tirePressure;
        }

        public int TireAge { get; set; }
        public double TirePressure { get; set; }
    }
}
