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
        public string GetName()
        {
            return this.name; 
        }
        public int GetYear()
        {
            return this.year;
        }
        public string GetPhone()
        {
            return this.phone;
        }
        public int GetCourse()
        {
            return this.course;
        }
        public List<Subject> GetSubjects()
        {
            return subjects;
        }
        public void AddSubject(Subject subject)
        {
            this.subjects.Add(subject);
        }
    }
}
