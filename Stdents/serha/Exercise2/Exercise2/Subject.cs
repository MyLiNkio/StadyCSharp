using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Subject
    {
        List<Teacher> teachers = new List<Teacher>();
        string name;
        public Subject(string name)
        {
            this.name = name;
        }
        public void addTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public List<Teacher> getTeachers()
        {
            return this.teachers;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
