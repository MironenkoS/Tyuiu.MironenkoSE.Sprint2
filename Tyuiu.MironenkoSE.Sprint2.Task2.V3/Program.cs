using Tyuiu.MironenkoSE.Sprint2.Task2.V3.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 Выполнил: Мироненко C.Э АСОИУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: #2.2 Операции сравнения                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Варинат #3                                                          *");
            Console.WriteLine("* Выполнил: Мроненко Сергей Эдуарлович АСОИУ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу,которая вычесляет которая вернет                     *");
            Console.WriteLine("*логическую последовательность и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной X: ");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области ");
            }
            else
            {
                Console.WriteLine("Точка находится в не заштрихованной области");

            }
            Console.ReadKey();
        }
    }
}
