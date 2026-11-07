using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint4.Task7.V21.Lib;
namespace Tyuiu.KimAV.Sprint4.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "425963128528";
            int n = 4;
            int m = 3;
            int result = ds.Calculate(n, m, value);
            int wait = 32;
            Assert.AreEqual(wait, result);
        }
    }
}
