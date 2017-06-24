namespace NeedForSpeed
{
    using System.Collections.Generic;

    public class PerformanceCar : Car
    {
        private List<string> addOns;

        public PerformanceCar(string brand, 
            string model, int yearOfProduction, int horsepower, 
            int acceleration, int suspension, int durability) 
            : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
            this.addOns = new List<string>();
            this.HorsePower += (int)(horsepower * 0.5);
            this.Suspension -=(int)(suspension * (25 / 100.0));
        }
    }
}
