using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* имя, год рождения,номер телефона, курс, количество предметов которые посещает, 
 * количество преподавателей, которые ведут эти предметы */

namespace Exercise2
{
    class Student
    {
        List<Subject> subjects = new List<Subject>();
        string name;
        int year;
        string phone;
        int course;
        public Student(string name, int year, string phone, int course) 
        {
            this.name = name;
            this.year = year;
            this.phone = phone;
            this.course = course;
        }
        public string getName()
        {
            return this.name; 
        }
        public int getYear()
        {
            return this.year;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public int getCourse()
        {
            return this.course;
        }
        public List<Subject> getSubjects()
        {
            return subjects;
        }
        public void addSubject(Subject subject)
        {
            this.subjects.Add(subject);
        }
    }
}
