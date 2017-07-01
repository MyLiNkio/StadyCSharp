using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Schedule.student;
using Schedule.discipline;
using Schedule.teacher;
using Schedule.auxiliary_tools;

namespace Schedule.discipline
{
    public class Discipline
    {
        private string name;
        private List<Timetable> timetable = new List<Timetable>();
        private List<Student> students = new List<Student>();
        private Teacher teacher; // У дисциплiни один викладач! , але його можна замiнити якщо вiн захворiв, чого не можна зробити зi студентом :) хоча...

        public Discipline(string discipline, Teacher teacher/*, Timetable couple*/)
        {
            this.name = discipline;
            this.teacher = teacher;
            //AddCouple(couple);
        }

        public void AddStudent(Student student) // Було б непогано зробити ... template
        {
            students.Add(student);
        }
        public void RemoveStudent(Student student) // Було б непогано зробити ... template
        {
            students.RemoveAt(students.BinarySearch(student));
        }
        public Student GetStudent(int i)
        {
            if (students[i] != null && students.Count() > i)
                return students[i];
            else
                return GetStudent(i - 1);
        }
        public void RewriteStudent(Student newStudent, Student oldStudent)
        {
            if (students.Contains(oldStudent))
            {
                students.Insert(students.BinarySearch(oldStudent), newStudent);
            }
        }

        public void AddCouple(Timetable couple) // Було б непогано зробити ... template
        {
            timetable.Add(couple);
        }
        public void RemoveCouple(Timetable couple) // Було б непогано зробити ... template
        {
            timetable.RemoveAt(timetable.BinarySearch(couple));
        }
        public Timetable GetCouple(int i)
        {
            if (timetable[i] != null && timetable.Count() > i)
                return timetable[i];
            else
                return GetCouple(i - 1);
        }
        public void RewriteCouple(Timetable newCouple, Timetable oldCouple)
        {
            if (timetable.Contains(oldCouple))
            {
                timetable.Insert(timetable.BinarySearch(oldCouple), newCouple);
            }
        }

        public string GetTeacher()
        {
            return teacher.GetSurname() + " " + teacher.GetFirstName() + " " + teacher.GetLastName();
        }

        public void RewriteTeacher(Teacher newTeacher)
        {
            teacher = newTeacher;
        }

        //public string GetTime()
        //{
        //    return timetable.GetTimetable();
        //}

        public string GetName()
        {
            return name;
        }
    }
}
