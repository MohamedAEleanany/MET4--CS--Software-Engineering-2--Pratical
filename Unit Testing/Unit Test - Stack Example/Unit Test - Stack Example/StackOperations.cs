using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test___Stack_Example
{
    public class StackOperations
    {
        Stack<int> myStack = new Stack<int>();

        public void PustToStack(int value)
        {
            myStack.Push(value);
        }

        public int PopFromStack()
        {
            return myStack.Pop();
        }

        public int PeekAtStack()
        {
            return myStack.Peek();
        }
    }
}
