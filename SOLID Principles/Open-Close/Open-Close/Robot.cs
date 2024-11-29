using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close
{
  public  class Robot
    {
        public string PlaySport(string sport)
        {
            if (sport == "Basketball")
            {
                return "I can play Basketball.";
            }
            else if (sport == "Football")
            {
                return "I can play Football.";
            }
            else
            {
                return "Sport not supported.";
            }
        }
    }
}
