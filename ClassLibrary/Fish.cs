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
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps, int maxTemp, int maxTempTime, int minTemp,int minTempTime) //Проверка на превышение пределов температуры, возвращает булл значение
        {
            for (int i = 0; i < temps.Length; i++) //Проверка на превышение мин температуры
            {
                if (Convert.ToInt32(temps[i]) < minTemp)
                {
                    minTempBelow = true;
                    result.Add($"  {dateAndTime.AddMinutes(i * 10)}      {temps[i]}         {minTemp}                       {(Convert.ToInt32(temps[i]) - minTemp)}");
                    time++;
                }
            }

            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"  {dateAndTime.AddMinutes(i * 10)}      {temps[i]}         {maxTemp}                       {(Convert.ToInt32(temps[i]) - maxTemp)}");
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
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps, int maxTemp, int maxTempTime, int minTemp, int minTempTime) //Проверка на превышение пределов температуры, возвращает булл значение
        {
            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"  {dateAndTime.AddMinutes(i * 10)}      {temps[i]}          {maxTemp}                      {(Convert.ToInt32(temps[i]) - maxTemp)}");
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
        }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps, int maxTemp, int maxTempTime, int minTemp,int minTempTime) //Проверка на превышение пределов температуры, возвращает булл значение
        {
            for (int i = 0; i < temps.Length; i++) //Проверка на превышение мин температуры
            {
                if (Convert.ToInt32(temps[i]) < minTemp)
                {
                    minTempBelow = true;
                    result.Add($"  {dateAndTime.AddMinutes(i * 10)}      {temps[i]}        {minTemp}                       {(Convert.ToInt32(temps[i]) - minTemp)}");
                    time++;
                }
            }

            for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
            {
                if (Convert.ToInt32(temps[i]) > maxTemp)
                {
                    maxTempBelow = true;
                    result.Add($"  {dateAndTime.AddMinutes(i * 10)}      {temps[i]}        {maxTemp}                       {(Convert.ToInt32(temps[i]) - maxTemp)}");
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

