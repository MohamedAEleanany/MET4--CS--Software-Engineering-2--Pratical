using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    class IPassiveRobot :RobotManager
    {
        public override string PlayGame(string game)
        {
            return string.Format("I prefer not to play {0}, but I can watch."
                , game);
        }
    }
}
