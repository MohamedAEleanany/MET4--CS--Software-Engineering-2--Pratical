using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class StudentController
    {
        private Student _model;
        private StudentView _view;
        public StudentController(Student model , StudentView view )
        {
            _model = model;
            _view = view;
        }
        public void SetStudentId(int id )
        {
            _model.id = id;
        }
        public int getStudentId()
        {
            return _model.id;
        }
        public void SetStudentName(string name)
        {
            _model.name = name;
        }
        public string GetStudentName()
        {
            return _model.name;
        }
        public void SetStudentGrade(double grade)
        {
            _model.grade = grade;
        }
        public double GetStudentGrade()
        {
            return _model.grade;
        }

        public void UpdateView()
        {
            _view.DisplayStudentDetails(_model.id, _model.name, _model.grade);
        }
    }
}
