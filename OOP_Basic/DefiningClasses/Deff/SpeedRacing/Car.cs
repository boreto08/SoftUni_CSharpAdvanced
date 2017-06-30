
namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelCostFor1Km;
        private double distancedTraveled;

        public Car(string model, decimal fuelAmount, decimal fuelCostFor1Km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCostFor1Km = fuelCostFor1Km;
            this.distancedTraveled = 0;
        }

    

        public decimal FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double DistancedTraveled
        {
            get { return this.distancedTraveled; }
            set { this.distancedTraveled = value; }
        }

        public void calcIfPossible(double distanceToTravel)
        {

            decimal usedGas = (decimal)distanceToTravel * this.fuelCostFor1Km;
            
            if (FuelAmount - usedGas >= 0)
            {
                FuelAmount -= usedGas;
                this.distancedTraveled += distanceToTravel;
            }
            else
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
