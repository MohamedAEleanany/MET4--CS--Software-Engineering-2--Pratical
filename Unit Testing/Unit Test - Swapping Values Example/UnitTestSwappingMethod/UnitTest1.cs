using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing___Swapping_Values_Example;

namespace UnitTestSwappingMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSwappingMethod()
        {
            Swapping swapValues = new Swapping();
            int val1 = 60;
            int val2 = 120;
            swapValues.swapTwoValues( val1,  val2);
           Assert.AreEqual(120, val1);
            
        }

        public void swapTwoValues(int val1, int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

        [TestMethod]
        public void TestSwappingMethod()
        {
            Swapping swapValues = new Swapping();
            int val1 = 60;
            int val2 = 120;
            swapValues.swapTwoValues(val1, val2);
            Assert.AreEqual(120, val1);
        }
    }
}
