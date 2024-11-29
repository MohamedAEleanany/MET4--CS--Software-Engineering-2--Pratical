using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
   public class BasicRobot :IRobot
    {
        public void Walk()
        {
            Console.WriteLine("Basic Robot is walking.");
        }

        public void Talk()
        {
            Console.WriteLine("Basic Robot is talking.");
        }

        public void Fight()
        {
            throw new NotImplementedException
                ("Basic Robot cannot fight!");
        }
    }
}
