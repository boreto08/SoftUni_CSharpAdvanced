namespace Startup
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private bool isCleansed;
        private string adoptionCenter;

        protected Animal(string name, int age,string adoptionCenter)
        {
            this.name = name;
            this.age = age;
            this.adoptionCenter = adoptionCenter;
            this.isCleansed = false;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string AdoptionCenter
        {
            get { return this.adoptionCenter; }
            set { this.adoptionCenter = value; }
        }


        public bool IsCleansed
        {
            get { return this.isCleansed; }
            set { this.isCleansed = value; }
        }

    }
}
