using Tyuiu.MironenkoSE.Sprint2.Task2.V3.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait =true;
            Assert.AreEqual(wait,res);
        }
    }
}