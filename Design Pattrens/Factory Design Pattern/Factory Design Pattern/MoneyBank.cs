using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class MoneyBank : CreditCard
    {
        public string getCardType()
        {
            return "MoneyBank";
        }

        public int getCreditLimit()
        {
            return 15000;
        }

        public int getAnnualCharge()
        {
            return 500;
        }
    }
}
