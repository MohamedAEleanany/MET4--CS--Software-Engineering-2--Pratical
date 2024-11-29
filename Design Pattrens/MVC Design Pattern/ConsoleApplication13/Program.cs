using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { id = 1, name = "Ali", grade = 85.5 };

            StudentView view = new StudentView();

            StudentController controller = new StudentController(student, view);

            controller.UpdateView();

            controller.SetStudentName("Ahmed");
            controller.SetStudentGrade(92.5);
            controller.UpdateView();
        }
    }
}
