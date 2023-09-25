using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GandaloevMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GandaloevMA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Мага";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет,Мага", res);
        }
    }
}
