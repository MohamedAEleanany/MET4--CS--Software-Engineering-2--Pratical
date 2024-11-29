using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibilty
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Robo1");
            Console.WriteLine(robot.IntroduceActivities());
        }
    }
}
