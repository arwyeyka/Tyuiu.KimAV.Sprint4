using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint4.Task6.V18.Lib;
namespace Tyuiu.KimAV.Sprint4.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string[] array = { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            string[] waitArray = { "Попугай", "Черепаха" };
            string[] resultArray = ds.Calculate(array);
            CollectionAssert.AreEqual(waitArray, resultArray);
        }
    }
}
