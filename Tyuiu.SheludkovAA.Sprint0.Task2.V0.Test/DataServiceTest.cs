using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint0.Task2.V0.Lib; // библиотеку классов подключаем через референс

namespace Tyuiu.SheludkovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Алексей";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Алексей", res); // если соответствует ожиданиям, то галочка
        }
    }
}
