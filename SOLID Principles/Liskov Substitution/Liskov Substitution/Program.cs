using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot silver = new Robot();
            Robot silverJr = new PassiveRobot();

            Console.WriteLine(silver.PlayGame("Dota"));   // Output: I am playing Dota.
            Console.WriteLine(silverJr.PlayGame("Dota")); // Output: I don't play games. (Behavior changes unexpectedly!)


            RobotManager Isilver = new IActiveRobot();
            RobotManager IsilverJr = new IPassiveRobot();

            Console.WriteLine(Isilver.PlayGame("Dota"));   // Output: I am playing Dota.
            Console.WriteLine(IsilverJr.PlayGame("Dota")); // Output: I prefer not to play Dota, but I can watch.
        }
    }
}
