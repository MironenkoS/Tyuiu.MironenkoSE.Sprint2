﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MironenkoSE.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3 && x <= 5 && y > 3 && y <= 5) && (x == 6 && y == 5) && (x >= 7 && x <= 8 && y >= 5 && y <= 12) && (x == 3 && y == 11) && (x == 7 && y == 13) && (x >= 4 && x <= 6 && y == 9) && (x == 4 && y >= 10 & y <= 13) && (x == 9 && x == 10 && y >= 3 && y <= 8) && (x == 11 && x == 12 && y == 3) && (x == 11 && x == 12 && y >= 6 && y <= 13) && (x == 13 && y == 6 && y == 7 && y == 8) && (x == 13 && y == 11 && y == 12 && y == 13))
            {
                res = true;
            }
            else
            {
                res= false;
            }
            return res; 

        }
    }
}
