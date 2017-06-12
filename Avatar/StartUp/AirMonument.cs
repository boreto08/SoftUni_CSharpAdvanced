﻿namespace StartUp
{
    public class AirMonument : Monument
    {
        private int airAffinity;

        public AirMonument(string name,int airAffinity)
            : base(name)
        {
            this.airAffinity = airAffinity;
        }

        public int AirAffinity
        {
            get { return this.airAffinity; }
            set { this.airAffinity = value; }
        }

    }
}
