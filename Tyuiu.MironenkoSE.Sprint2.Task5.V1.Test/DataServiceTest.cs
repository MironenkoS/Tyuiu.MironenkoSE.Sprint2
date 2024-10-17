using Tyuiu.MironenkoSE.Sprint2.Task5.V1.Lib;
using System;
namespace Tyuiu.MironenkoSE.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("31", ds.FindMonthDaysCount(1, res));
            Assert.AreEqual("28", ds.FindMonthDaysCount(2, res));
            Assert.AreEqual("30", ds.FindMonthDaysCount(3, res));
            Assert.AreEqual("31", ds.FindMonthDaysCount(4, res));
            Assert.AreEqual("30", ds.FindMonthDaysCount(5, res));
            Assert.AreEqual("31", ds.FindMonthDaysCount(6, res));
            Assert.AreEqual("30", ds.FindMonthDaysCount(7, res));
            Assert.AreEqual("31", ds.FindMonthDaysCount(8, res));
            Assert.AreEqual("30", ds.FindMonthDaysCount(9, res));
            Assert.AreEqual("31", ds.FindMonthDaysCount(10, res));
            Assert.AreEqual("30", ds.FindMonthDaysCount(11, res));
            Assert.AreEqual("31", ds.FindMonthDaysCount(12, res));
            Assert.AreEqual.ThrowsException<ArgumentException>(()=>
            { }

        }
    }
}