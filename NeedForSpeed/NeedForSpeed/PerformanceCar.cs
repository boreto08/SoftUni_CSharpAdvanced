namespace NeedForSpeed
{
    using System.Collections.Generic;

    public class PerformanceCar : Car
    {
        private List<string> addOns;

        public PerformanceCar(int id, string type, string brand, 
            string model, int yearOfProduction, int horsepower, 
            int acceleration, int suspension, int durability) 
            : base(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
            this.addOns = new List<string>();
            this.horsePower += (int)(horsepower * (1.0 / 2.0));
            this.suspension -=(int)(suspension * (25 / 100.0));
        }
    }
}
