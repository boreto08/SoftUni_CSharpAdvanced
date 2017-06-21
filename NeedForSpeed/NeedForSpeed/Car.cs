namespace NeedForSpeed
{
    public abstract class Car
    {
        protected int id;
        protected string type;
        protected string brand;
        protected string model;
        protected int yearOfProduction;
        protected int horsePower;
        protected int acceleration;
        protected int suspension;
        protected int durability;
        protected bool isFree;

        
        protected Car(int id,string type, string brand, string model,
            int yearOfProduction, int horsepower,
            int acceleration, int suspension, int durability)
        {
            this.id = id;
            this.type = type;
            this.brand = brand;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.horsePower = horsepower;
            this.acceleration = acceleration;
            this.suspension = suspension;
            this.durability = durability;
        }

  

        public bool IsFree
        {
            get { return this.isFree; }
            set { this.isFree = value; }
        }

    }
}
