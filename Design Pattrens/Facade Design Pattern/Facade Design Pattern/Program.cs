using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.placeOrder();
            
        }
    }
}
