using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            // Robot directly calls methods tied to specific implementations
            robot.CodeInJava();
            robot.CodeInCSharp();


            IRobot Irobot = new IRobot();

            // Use Java
            Irobot.SetLanguage(new IJavaLanguage());
            Irobot.StartCoding();

            // Use C#
            Irobot.SetLanguage(new ICSharpLanguage());
            Irobot.StartCoding();
        }
    }
}
