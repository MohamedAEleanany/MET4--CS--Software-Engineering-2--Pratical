using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Titanuim : CreditCard
    {
        public string getCardType()
        {
            return "Titanuim Edge";
        }

        public int getCreditLimit()
        {
            return 25000;
        }

        public int getAnnualCharge()
        {
            return 1500;
        }
    }
}
