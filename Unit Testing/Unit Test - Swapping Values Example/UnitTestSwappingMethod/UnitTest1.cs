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
            swapValues.swapTwoValues(ref val1,ref  val2);
           Assert.AreEqual(120, val1);
            
        }

      

        [TestMethod]
        public void TestSwappingMethod()
        {
      
        }
    }
}
