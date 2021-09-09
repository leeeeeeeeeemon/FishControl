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

            Console.WriteLine("input date(DD.M.YYYY HH:MM)");
            string dateAndTimeFish = Console.ReadLine();
            DateTime dateFish = ConvertStringToDateTime(dateAndTimeFish);

            Console.WriteLine("input temperatures(18-54)");
            string[] temp = Console.ReadLine().Split(' ');

            if (chooseType == "Semga")
            {
                Semga f = new Semga();
                f.ComplianceConditions(dateFish, temp);
            }

            string sdad = Console.ReadLine();
        }

        public static DateTime ConvertStringToDateTime(string dd_mm_yy_HH_MM)
        {
            string[] dateAndTimeFish = dd_mm_yy_HH_MM.Split(' ');
            string[] dateNumbers = dateAndTimeFish[0].Split('.');
            string[] timeNumbers = dateAndTimeFish[1].Split(':');
            DateTime dateFish = new DateTime(Convert.ToInt32(dateNumbers[2]), Convert.ToInt32(dateNumbers[1]), Convert.ToInt32(dateNumbers[0]), Convert.ToInt32(timeNumbers[0]), Convert.ToInt32(timeNumbers[1]), 0);
            return dateFish;
        }

    }

    

    class Fish
    {
        public string name;
        protected int maxTemp;
        protected int maxTempTime;
        protected int minTemp;
        protected int minTempTime;

        protected List<string> result = new List<string>();
        protected int time = 0;

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

        public void ComplianceConditions(DateTime dateAndTime, string[] temps)
        {
            bool minTempBelow = false;
            for (int i = 0; i < temps.Length; i++)
            {
                if(Convert.ToInt32(temps[i]) < minTemp)
                {
                    minTempBelow = true;
                    result.Add($"Время:{dateAndTime.AddMinutes(i * 10)}, Факт:{temps[i]}, Норма:{minTemp}, Отклонение от нормы:{(Convert.ToInt32(temps[i]) - minTemp)}");
                    time++;
                }
            }
            if (minTempBelow && time * 10 > minTempTime)
            {
                Console.WriteLine("Порог минимальной допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                foreach(var f in result)
                {
                    Console.WriteLine(f);
                }
            }
        }

    }
}
