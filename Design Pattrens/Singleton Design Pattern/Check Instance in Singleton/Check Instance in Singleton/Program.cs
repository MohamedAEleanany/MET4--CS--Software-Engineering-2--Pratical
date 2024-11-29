using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Instance_in_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singlton s1 = Singlton.getInstance();
            Singlton s2 = Singlton.getInstance();
            if (s1 == s2)
            {
                Console.WriteLine("Singleton Instance Created Successfully");
            }
            else 
            {
                Console.WriteLine("Opps..There is an Error");
            }
            
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
