namespace NeedForSpeed
{
    public abstract class Car
    {
        
        private string brand;
        private string model;
        private int yearOfProduction;
        private int horsePower;
        private int acceleration;
        private int suspension;
        private int durability;
        private bool isFree;

        
        protected Car(string brand, string model,
            int yearOfProduction, int horsepower,
            int acceleration, int suspension, int durability)
        {
            
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

        

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public int YearOfProduction
        {
            get { return this.yearOfProduction; }
            set { this.yearOfProduction = value; }
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

        public int Acceleration
        {
            get { return this.acceleration; }
            set { this.acceleration = value; }
        }

        public int Durability
        {
            get { return this.durability; }
            set { this.durability = value; }
        }

        public int Suspension
        {
            get { return this.suspension; }
            set { this.suspension = value; }
        }

    }
}
