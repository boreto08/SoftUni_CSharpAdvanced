using System;

namespace StartUp
{
    public class AirBender : Bender
    {
        private double aerialIntegirty;

        public AirBender(string name, int power,double aerialIntegirty) 
            : base(name, power)
        {
            this.aerialIntegirty = aerialIntegirty;
        }


        public double AerialIntegirty
        {
            get { return this.aerialIntegirty; }
            set { this.aerialIntegirty = value; }
        }

        public override string ToString()
        {
           return string.Format($"###Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegirty}");
        }
    }
}
