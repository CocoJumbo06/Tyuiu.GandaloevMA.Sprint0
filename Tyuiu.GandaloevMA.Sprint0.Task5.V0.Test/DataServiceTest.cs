using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GandaloevMA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.GandaloevMA.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(2,DataService.Division(10,5));
        }
    }
}
