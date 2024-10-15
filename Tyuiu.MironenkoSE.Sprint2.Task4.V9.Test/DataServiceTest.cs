using Tyuiu.MironenkoSE.Sprint2.Task4.V9.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.Task4.V9.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 624.7;
            Assert.AreEqual(wait,res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 12;
            double res = ds.Calculate(x, y);
            double wait = 624.75;
            Assert.AreEqual(wait, res);
        }
    }
}