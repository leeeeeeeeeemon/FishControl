using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    abstract public class Fish
    {
        public string name;
        public int maxTemp;
        public int maxTempTime;
        public int minTemp;
        public int minTempTime;

        public bool minTempBelow = false;
        public bool maxTempBelow = false;

        public List<string> result = new List<string>();
        public int time = 0;

        public Fish() { }
    }

    public class Semga : Fish
    {
        public Semga() : base()
        {
            name = "Semga";
            maxTemp = 6;
            maxTempTime = 20;
            minTemp = -3;
            minTempTime = 50;
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps) //Проверка на превышение пределов температуры, возвращает булл значение
        {
            for (int i = 0; i < temps.Length; i++) //Проверка на превышение мин температуры
            {
                if (Convert.ToInt32(temps[i]) < minTemp)
                {
                    minTempBelow = true;
                    result.Add($"  Время:{dateAndTime.AddMinutes(i * 10)},   Факт:{temps[i]},   Норма:{minTemp},   Отклонение от нормы:{(Convert.ToInt32(temps[i]) - minTemp)}");
                    time++;
                }
            }

            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"  Время:{dateAndTime.AddMinutes(i * 10)},   Факт:{temps[i]},   Норма:{maxTemp},   Отклонение от нормы:+{(Convert.ToInt32(temps[i]) - maxTemp)}");
                    time++;
                }
            }

            if ((minTempBelow && time * 10 > minTempTime) || (maxTempBelow && time * 10 > maxTempTime)) //Проверка на продолжиельность превышения пределов
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    public class Pollock : Fish //Минтай ( по англ Pollock воть так-_-)
    {
        public Pollock() : base()
        {
            name = "Pollock";
            maxTemp = -5;
            maxTempTime = 40;
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps) //Проверка на превышение пределов температуры, возвращает булл значение
        {
            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"  Время:{dateAndTime.AddMinutes(i * 10)},   Факт:{temps[i]},   Норма:{maxTemp},   Отклонение от нормы:+{(Convert.ToInt32(temps[i]) - maxTemp)}");
                    time++;
                }
            }

            if (maxTempBelow && time * 10 > maxTempTime) //Проверка на продолжиельность превышения пределов
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    public class PinkSalmon : Fish //Горбуша ( по англ Pink Salmon -_-)
    {
        public PinkSalmon() : base()
        {
            name = "PinkSalmon";
            minTemp = -7;
            minTempTime = 20;
            maxTemp = 2;
            maxTempTime = 40;
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps) //Проверка на превышение пределов температуры, возвращает булл значение
        {
            for (int i = 0; i < temps.Length; i++) //Проверка на превышение мин температуры
            {
                if (Convert.ToInt32(temps[i]) < minTemp)
                {
                    minTempBelow = true;
                    result.Add($"  Время:{dateAndTime.AddMinutes(i * 10)},   Факт:{temps[i]},   Норма:{minTemp},   Отклонение от нормы:{(Convert.ToInt32(temps[i]) - minTemp)}");
                    time++;
                }
            }

            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"  Время:{dateAndTime.AddMinutes(i * 10)},   Факт:{temps[i]},   Норма:{maxTemp},   Отклонение от нормы:+{(Convert.ToInt32(temps[i]) - maxTemp)}");
                    time++;
                }
            }

            if ((minTempBelow && time * 10 > minTempTime) || (maxTempBelow && time * 10 > maxTempTime)) //Проверка на продолжиельность превышения пределов
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

