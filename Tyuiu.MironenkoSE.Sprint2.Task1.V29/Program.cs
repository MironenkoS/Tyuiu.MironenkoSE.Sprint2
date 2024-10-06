using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MironenkoSE.Sprint2.Task1.V29.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.Task1.V29
{
    class Programm
    {
    static void Main(string[] args)
        { DataService ds = new DataService();
            int a = 657;
            int b = 654;
            int c = 657;
            int d = 657;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 Выполнил: Мироненко C.Э АСОИУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: #2.1 Операции сравнения                                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Варинат #29                                                             *");
            Console.WriteLine("* Выполнил: Мроненко Сергей Эдуарлович АСОИУ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая вычесляет которая вернет                     *");
            Console.WriteLine("*логическую последовательность и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            { Console.WriteLine(res[i]); }
            Console.ReadKey();






        }
    }
   
}
