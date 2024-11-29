using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
   public class StudentView
    {
       public void DisplayStudentDetails(int id , string name , double grade)
       {
           Console.WriteLine("Student Details");
           Console.WriteLine("Student ID : " + id);
           Console.WriteLine("Student Name : " + name);
           Console.WriteLine("Student Grade" + grade);
       }
    }
}
