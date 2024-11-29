using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test___Car_Example;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var car = new Car();

            car.DirectionTo();

            Assert.IsTrue(car.EngineAreWorking);
            Assert.AreEqual(29000, car.speed);
            Assert.AreEqual("To Cairo", car.Direction);
        }
    }
}
