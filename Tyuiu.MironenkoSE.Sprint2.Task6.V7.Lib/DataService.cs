using tyuiu.cources.programming.interfaces.Sprint2;
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
                case 2: return "Январь";
                case 3: return "Январь";
                case 4: return "Январь";
                case 5: return "Январь";
                case 6: return "Январь";
                case 7: return "Январь";
                case 8: return "Январь";
                case 9: return "Январь";
                case 10: return "Январь";
                case 11: return "Январь";
                case 12: return "Январь";
                default: throw new ArgumentException($"Данные не верны. Значение {startyear}");
            }
        }
    }
}
   






