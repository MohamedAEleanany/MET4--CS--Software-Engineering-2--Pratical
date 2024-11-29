using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
   public class CreditCardFactory
    {
       public static CreditCard getCreditCard(string cardType)
       {
           CreditCard creditDetails = null;

           if(cardType =="MoneyBank")
           {
               creditDetails = new MoneyBank();
           }
           else if (cardType == "Titanuim")
           {
               creditDetails = new Titanuim();
           }
           else if (cardType == "Platinum")
           {
               creditDetails = new Platinumcs();
           }
           return creditDetails;
       }
    }
}
