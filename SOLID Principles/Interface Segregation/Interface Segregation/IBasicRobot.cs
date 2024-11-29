using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class IBasicRobot:IWalkingRobot,ITalkingRobot
    {
        public void Talk()
        {
            Console.WriteLine("Basic Robot is talking.");
        }

        public void Walk()
        {
            Console.WriteLine("Basic Robot is walking.");   
        }
    }
}
