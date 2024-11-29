using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creation_of_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the Singleton
            Singlton s1 = Singlton.getInstance();
        }
    }

    class Singlton
    {
        // Make an Intance of The Class "Singleton"
        private static Singlton instance = null;

        // Create a Private Constructor to Protect to Make a new Instance External the class
        private Singlton() { }

        public static Singlton getInstance()
        {

            if (instance == null)
            {
                instance = new Singlton();
            }
            return instance;
        }
       
    }
}
