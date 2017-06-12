﻿namespace StartUp
{
    public abstract class Monument
    {
        private string name;

        protected Monument(string name)
        {
            this.name = name;
        }

        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

    }
}
