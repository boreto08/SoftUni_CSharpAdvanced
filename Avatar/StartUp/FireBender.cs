using System;

namespace StartUp
{
    public class FireBender : Bender
    {
        private double heatAggression;

        public FireBender(string name, int power,double heatAggression)
            : base(name, power)
        {
            this.heatAggression = heatAggression;
        }

        public double HeatAggression
        {
            get { return this.heatAggression; }
            set { this.heatAggression = value; }
        }

        public override string ToString()
        {
            return string.Format($"###Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression}");
        }
    }
}
