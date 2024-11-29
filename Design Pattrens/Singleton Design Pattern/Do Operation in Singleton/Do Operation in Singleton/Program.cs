using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_Operation_in_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singlton s1 = Singlton.getInstance();
            s1.doSingleTonOperation();
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
        public void doSingleTonOperation()
        {
            Console.WriteLine("SingleTon Operation");
        }
    }
}
