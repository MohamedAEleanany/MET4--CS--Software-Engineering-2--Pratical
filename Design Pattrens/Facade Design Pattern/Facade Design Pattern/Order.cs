using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Design_Pattern
{
   public class Order
    {
       public void placeOrder()
       {
           Console.WriteLine("Place Order Started");


           Product product = new Product();
           product.GetProductDetails();

           Payment payment = new Payment();
           payment.makePayment();

           Invoke invoke = new Invoke();
           invoke.sendInvoice();
           
           Console.WriteLine("Order Placed Succsefully");
       }
    }
}
