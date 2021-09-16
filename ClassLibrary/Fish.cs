using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Fish
    {
        public bool minTempBelow = false;
        public bool maxTempBelow = false;

        public List<string> result = new List<string>();
        public int time = 0;

        public Fish() { }

        public bool ComplianceConditions(DateTime dateAndTime, string[] temps, int maxTemp, int maxTempTime, int minTemp, int minTempTime)
        {
            if (minTemp== 0 && minTempTime == 0)
            {
                for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
                {
                    if (Convert.ToInt32(temps[i]) > maxTemp)
                    {
                        maxTempBelow = true;
                        result.Add($"  {dateAndTime.AddMinutes(i * 10).ToString("dd.MM.yyyy hh:mm")}        {temps[i]}          {maxTemp}                      {(Convert.ToInt32(temps[i]) - maxTemp)}");
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

            else
            {
                for (int i = 0; i < temps.Length; i++) //Проверка на превышение мин температуры
                {
                    if (Convert.ToInt32(temps[i]) < minTemp)
                    {
                        minTempBelow = true;
                        result.Add($"  {dateAndTime.AddMinutes(i * 10).ToString("dd.MM.yyyy hh:mm")}        {temps[i]}         {minTemp}                       {(Convert.ToInt32(temps[i]) - minTemp)}");
                        time++;
                    }
                }

                for (int i = 0; i < temps.Length; i++) //Проверка на превышение макс температуры
                {
                    if (Convert.ToInt32(temps[i]) > maxTemp)
                    {
                        maxTempBelow = true;
                        result.Add($"  {dateAndTime.AddMinutes(i * 10).ToString("dd.MM.yyyy hh:mm")}        {temps[i]}         {maxTemp}                       {(Convert.ToInt32(temps[i]) - maxTemp)}");
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
}

