using Tyuiu.MironenkoSE.Sprint2.Task0.V21.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.Task0.V21
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService();
            int x = 1705;
            int y = 775; bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y); Console.Title = "Спринт #2 Выполнил: Мироненко C.Э АСОИУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: #2.0 Операции сравнения                                           *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Варинат #21                                                             *");
            Console.WriteLine("* Выполнил: Мроненко Сергей Эдуарлович АСОИУ-24-1                         *");
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая вычесляет которая вернет                     *");
            Console.WriteLine("*логическую последовательность и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X+ = " + x); Console.WriteLine("Y+ = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            { Console.WriteLine(res[i]); }
            Console.ReadKey();
        }
    }
}

    
    

