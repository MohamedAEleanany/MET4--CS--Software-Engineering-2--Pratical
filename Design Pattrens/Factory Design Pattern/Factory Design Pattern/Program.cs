using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creaditDetails = CreditCardFactory.getCreditCard("Platinum");
            if(creaditDetails != null)
            {
                Console.WriteLine("CreaditType" +   creaditDetails.getCardType());
                Console.WriteLine("CreaditLimit" + creaditDetails.getCreditLimit());
                Console.WriteLine("CreaditCharge" + creaditDetails.getAnnualCharge());

            }
        }
    }
}
