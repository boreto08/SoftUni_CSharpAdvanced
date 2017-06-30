namespace RawData
{
    public class Car
    {
       
        private string model;
        private Cargo cargo;
        private Engine engine;
        private Tire[] tires;

         
        public Car(string model, int engineSpeed,int enginePower,int cargoWeight,string cargoType,
            int tireAge1, double tirePressure1, 
            int tireAge2, double tirePressure2, 
            int tireAge3, double tirePressure3,
            int tireAge4, double tirePressure4)
        {
            this.Model = model;
            this.cargo = new Cargo(cargoWeight,cargoType);
            this.engine = new Engine(engineSpeed,enginePower);
            
            addTires(tireAge1, tirePressure1,
                tireAge2, tirePressure2,
                tireAge3, tirePressure3,
                tireAge4, tirePressure4);
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public Cargo Cargo  
        {
            get { return this.cargo; }
            private set { this.cargo = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            private set { this.engine = value; }
        }

        public Tire[] Tire
        {
            get { return this.tires; }
            private set { this.tires = value; }
        }


        private void addTires(int tireAge1, double tirePressure1,
            int tireAge2, double tirePressure2,
            int tireAge3, double tirePressure3,
            int tireAge4, double tirePressure4)
        {
            this.tires = new Tire[4];
            Tire tire1 = new Tire(tireAge1, tirePressure1);
            Tire tire2 = new Tire(tireAge2, tirePressure2);
            Tire tire3 = new Tire(tireAge3, tirePressure3);
            Tire tire4 = new Tire(tireAge4, tirePressure4);
            this.tires[0] = tire1;
            this.tires[1] = tire2;
            this.tires[2] = tire3;
            this.tires[3] = tire4;

            
        }
    }
}
