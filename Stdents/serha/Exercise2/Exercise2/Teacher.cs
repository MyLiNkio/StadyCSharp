using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Teacher
    {
        List<Subject> subjects = new List<Subject>();
        string name;
        public Teacher(string name){
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
