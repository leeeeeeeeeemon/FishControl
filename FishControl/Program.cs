using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace FishControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose type fish (Semga / Pollock)");
            string chooseType = Console.ReadLine();

            Console.WriteLine("input date(DD.M.YYYY HH:MM)");
            string dateAndTimeFish = Console.ReadLine();
            DateTime dateFish = ConvertStringToDateTime(dateAndTimeFish);

            Console.WriteLine("input temperatures(18-54)");
            string[] temp = Console.ReadLine().Split(' ');

            if (chooseType == "Semga")
            {
                Semga f = new Semga();
                if(f.ComplianceConditions(dateFish, temp)) // проверка на темп
                {
                    if (f.minTempBelow) //если превышен минимальный
                    {
                        Console.WriteLine("Порог минимальной допустимой температуры превышен на " + TimeSpan.FromMinutes(f.time * 10) + " минут");
                        foreach(var r in f.result)
                        {
                            Console.WriteLine(r);
                        }
                    }
                    else if(f.maxTempBelow) //если превышен максимальный
                    {
                        Console.WriteLine("Порог максимальной допустимой температуры превышен на " + TimeSpan.FromMinutes(f.time * 10) + " минут");
                        foreach (var r in f.result)
                        {
                            Console.WriteLine(r);
                        }
                    }
                }
            }
            if (chooseType == "Pollock")
            {
                Pollock f = new Pollock();
                if (f.ComplianceConditions(dateFish, temp)) // проверка на темп
                {
                        Console.WriteLine("Порог максимальной допустимой температуры превышен на " + TimeSpan.FromMinutes(f.time * 10) + " минут");
                        foreach (var r in f.result)
                        {
                            Console.WriteLine(r);
                        }

                }
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
        public bool minTempBelow = false;
        public bool maxTempBelow = false;

        public List<string> result = new List<string>();
        public int time = 0;
        

        public Fish()
        {
       
        }

        protected void Output()
        {
            Console.WriteLine(name);
            Console.WriteLine(maxTemp);
            Console.WriteLine(maxTempTime);
            Console.WriteLine(minTemp);
            Console.WriteLine(minTempTime);
        }
    }

    class Semga : Fish
    {
        public Semga() : base()
        {
            name = "Semga";
            maxTemp = 5;
            maxTempTime = 20;
            minTemp = -3;
            minTempTime = 50;

            Output();
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps) //Проверка на превышение пределов температуры, возвращает булл значение
        {

            for (int i = 0; i < temps.Length; i++) //Проверка на превышение мин температуры
            {
                if (Convert.ToInt32(temps[i]) < minTemp)
                {
                    minTempBelow = true;
                    result.Add($"Время:{dateAndTime.AddMinutes(i * 10)}, Факт:{temps[i]}, Норма:{minTemp}, Отклонение от нормы:{(Convert.ToInt32(temps[i]) - minTemp)}");
                    time++;
                }
            }

            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"Время:{dateAndTime.AddMinutes(i * 10)}, Факт:{temps[i]}, Норма:{maxTemp}, Отклонение от нормы:{(Convert.ToInt32(temps[i]) - maxTemp)}");
                    time++;
                }


            }


            if ((minTempBelow && time * 10 > minTempTime) || (maxTempBelow && time * 10 > maxTempTime))
            {
                //Console.WriteLine("Порог минимальной допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                //foreach(var f in result)
                //{
                //    Console.WriteLine(f);
                //}
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class Pollock : Fish //Минтай ( по англ Pollock воть так-_-)
    {
        public Pollock() : base()
        {
            name = "Pollock";
            maxTemp = -7;
            maxTempTime = 20;

            Output();
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps) //Проверка на превышение пределов температуры, возвращает булл значение
        {
            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"Время:{dateAndTime.AddMinutes(i * 10)}, Факт:{temps[i]}, Норма:{maxTemp}, Отклонение от нормы:{(Convert.ToInt32(temps[i]) - maxTemp)}");
                    time++;
                }


            }
            if (maxTempBelow)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
