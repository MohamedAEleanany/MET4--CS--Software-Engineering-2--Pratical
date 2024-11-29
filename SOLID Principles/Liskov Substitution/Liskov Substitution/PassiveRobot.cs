using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
   public class PassiveRobot :Robot
    {
       public override string PlayGame(string game)
       {
           return "I don't play games.";
       }
    }
}
