using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test___Stack_Example;

namespace UnitTestStackOperations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStackOperations()
        {

            StackOperations stack = new StackOperations();

            stack.PustToStack(15);
            stack.PustToStack(35);
            stack.PustToStack(100);
            stack.PopFromStack();

            int ExpectResult = 35;

            Assert.AreEqual(ExpectResult, stack.PeekAtStack());
        }
    }
}
