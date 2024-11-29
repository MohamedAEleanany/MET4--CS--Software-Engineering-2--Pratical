using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
   public class Robot
    {
           public virtual string PlayGame(string game)
             {
            return string.Format("I am playing {0}.", game);
             }
    }
}
