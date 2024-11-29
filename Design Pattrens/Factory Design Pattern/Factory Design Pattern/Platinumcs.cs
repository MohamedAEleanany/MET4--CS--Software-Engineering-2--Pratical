using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Platinumcs :CreditCard
    {
        public string getCardType()
        {
            return "Platinum Plus";
        }

        public int getCreditLimit()
        {
            return 35000;
        }

        public int getAnnualCharge()
        {
            return 2000;
        }
    }
}
