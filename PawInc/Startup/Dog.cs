namespace Startup
{
    public class Dog : Animal
    {
        private int learnedCommands;

        public Dog(string name, int age,string adoptionCenter,int learnedCommands) 
            : base(name, age,adoptionCenter)
        {
            this.learnedCommands = learnedCommands;
        }
    }
}
