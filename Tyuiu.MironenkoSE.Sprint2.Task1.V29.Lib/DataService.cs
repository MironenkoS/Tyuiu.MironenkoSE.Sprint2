using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MironenkoSE.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];
            result[0] = (a > b) | (c > d+1);
            result[1] = (a >b) & (c+1 > d);
            result[2] = (a >b) || (c > d+1);
            result[3] = (a >b) && (c > d+1);
            result[4] = !(!result[0]);
            result[5] = (a>b) ^ (c > d+1);
            return result;
        }
    }
}
// int a = 657;
// int b = 654;
// int c = 657;
// int d = 657;
// |, &, ||, &&, !, ^