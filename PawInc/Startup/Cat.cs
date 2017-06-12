namespace Startup
{
    public class Cat : Animal
    {
        private int intelligance;

        public Cat(string name, int age,string adoptionCenter, int intelligance) 
            : base(name, age, adoptionCenter)
        {
            this.intelligance = intelligance;
        }
    }
}
