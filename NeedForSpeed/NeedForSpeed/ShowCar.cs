namespace NeedForSpeed
{

    public class ShowCar : Car
    {
        private int stars;

        public ShowCar(int id, string type, string brand, string model, 
            int yearOfProduction, int horsepower, int acceleration, 
            int suspension, int durability) 
            : base(id, type, brand, model, yearOfProduction, 
                  horsepower, acceleration, suspension, durability)
        {
            this.stars = 0;
        }
    }
}
