﻿namespace StartUp
{
    public class EarthMonument : Monument
    {
        private int earthAffinity;

        public EarthMonument(string name,int earthAffinity)
            : base(name)
        {
            this.earthAffinity = earthAffinity;
        }

        public int EarthAffinity
        {
            get { return this.earthAffinity; }
            set { this.earthAffinity = value; }
        }
    }
}
