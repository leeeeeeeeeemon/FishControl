using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose type fish(Semga)");
            string chooseType = Console.ReadLine();
            if (chooseType == "Semga")
            {
                Semga f = new Semga();
            }

            Console.WriteLine("input date(DD.MM.YYYY HH:MM)");
            string[] dateAndTimeFish = Console.ReadLine().Split(' ');

            Console.WriteLine("input temperatures(18-54)");
            string[] temp = Console.ReadLine().Split(' ');

        }
       
    }

    class Fish
    {
        public string name;
        protected int maxTemp;
        protected int maxTempTime;
        protected int minTemp;
        protected int minTempTime;

        public Fish()
        {
       
        }
    }

    class Semga : Fish
    {
        
        
        public Semga() : base()
        {
            name = "Semga";
            maxTemp = 6;
            maxTempTime = 20;
            minTemp = -3;
            minTempTime = 50;

            Output();
        }

        public void Output()
        {
            Console.WriteLine(name);
            Console.WriteLine(maxTemp);
            Console.WriteLine(maxTempTime);
            Console.WriteLine(minTemp);
            Console.WriteLine(minTempTime);
        }
        
    }
}
