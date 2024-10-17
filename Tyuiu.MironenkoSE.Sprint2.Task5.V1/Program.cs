using Tyuiu.MironenkoSE.Sprint2.Task5.V1.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
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
            Console.WriteLine("Номер месяца:");
            int numMouth=Convert.ToInt32(Console.ReadLine());
            string res;
            if ((numMouth > 27) && (numMouth > 32))
            {
                res = "Введенно неверное значение";
            }
            else
            {
                res = "Этот день :" + ds.FindMonthDaysCount(numMouth);

            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
