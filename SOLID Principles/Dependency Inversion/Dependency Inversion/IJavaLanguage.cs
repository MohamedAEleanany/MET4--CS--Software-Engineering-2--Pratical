using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
   public class IJavaLanguage:IProgrammingLanguage
    {
        public void Code()
        {
            Console.WriteLine("Coding in Java...");
        }
    }
}
