using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Close
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotManager robot = new RobotManager();

            ISport basketball = new Basketball();
            ISport football = new Football();

            Console.WriteLine(robot.PlaySport(basketball)); // Output: I can play Basketball.
            Console.WriteLine(robot.PlaySport(football));   // Output: I can play Football.
        }
    }
}
