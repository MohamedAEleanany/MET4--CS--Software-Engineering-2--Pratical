using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IRobot basicRobot = new BasicRobot();

           
            basicRobot.Walk();

            
            basicRobot.Talk();

            try
            {
                basicRobot.Fight();
            }
            catch (NotImplementedException ex)
            {
                
                Console.WriteLine(ex.Message);
            }

            // using Interface Segregation
            IWalkingRobot IbasicRobot = new IBasicRobot();
            IbasicRobot.Walk();

            IFightingRobot IbattleRobot = new IBattleRobot();
            IbattleRobot.Fight();
        }
    }
}
