using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    class IActiveRobot :RobotManager
    {
        public override string PlayGame(string game)
        {
            return string.Format("I am playing {0}.", game);
        }
    }
}
