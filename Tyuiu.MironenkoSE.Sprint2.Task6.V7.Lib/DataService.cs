﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MironenkoSE.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7

    {
        public string FindMonthName(int startYear, int n)
        {
            int startyear = n % 12;
            
            switch (startyear)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default: throw new ArgumentException($"Данные не верны. Значение {startyear}");
            }
        }
    }
}
   






