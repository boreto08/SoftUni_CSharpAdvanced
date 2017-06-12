namespace StartUp
{
    public class EarthBender : Bender
    {
        private double groundSaturation;

        public EarthBender(string name, int power,double groundSaturation)
            : base(name, power)
        {
            this.groundSaturation = groundSaturation;
        }


        public double GroundSaturation
        {
            get { return this.groundSaturation; }
            set { this.groundSaturation = value; }
        }

        public override string ToString()
        {
            return string.Format($"###Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.GroundSaturation}");
        }
    }
}
