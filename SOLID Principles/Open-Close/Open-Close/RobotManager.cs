using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close
{
   public class RobotManager
    {
       public string PlaySport(ISport sport)
       {
           return sport.Play();
       }
    }
}
