using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
   public class Product
    {
       // creating subsystem
       public void GetProductDetails()
       {
           Console.WriteLine("Fetching the Product Details");
       }
    }
}
