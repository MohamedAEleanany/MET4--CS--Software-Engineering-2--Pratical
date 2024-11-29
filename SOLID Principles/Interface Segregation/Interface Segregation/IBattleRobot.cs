using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
   public class IBattleRobot:IWalkingRobot,IFightingRobot
    {
        public void Walk()
        {
            Console.WriteLine("Battle Robot is walking.");
        }

        public void Fight()
        {
            Console.WriteLine("Battle Robot is fighting.");
        }
    }
}
