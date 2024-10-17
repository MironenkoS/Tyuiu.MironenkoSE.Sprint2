using Tyuiu.MironenkoSE.Sprint2.V4.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.V4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.7;
            double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}