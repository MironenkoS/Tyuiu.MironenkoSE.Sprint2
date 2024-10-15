
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MironenkoSE.Sprint2.Task3.V20.Lib;
namespace Tyuiu.MironenkoSE.Sprint2.Task3.V20.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 4.5;
            Assert.AreEqual(wait, res);




        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);


        }
    }
}