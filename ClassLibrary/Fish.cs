using System;

namespace ClassLibrary
{
    public class Fish
    {
        public string name;
        protected int maxTemp;
        protected int maxTempTime;
        protected int minTemp;
        protected int minTempTime;     

        public Fish() { }

        protected void Output()
        {
            Console.WriteLine(name);
            Console.WriteLine(maxTemp);
            Console.WriteLine(maxTempTime);
            Console.WriteLine(minTemp);
            Console.WriteLine(minTempTime);
        }
    }
}

