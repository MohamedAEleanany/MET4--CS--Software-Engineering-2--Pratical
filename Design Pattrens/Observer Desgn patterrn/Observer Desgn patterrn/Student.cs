using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Desgn_patterrn
{
   public class Student : Observer
    {
       private string studentName;

       public Student (string name)
       {
           this.studentName = name;

       }

       public void update(string massege)
       {
           Console.WriteLine(this.studentName + " has new notifacation : " +massege);
       }
    }
}
