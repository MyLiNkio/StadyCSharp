﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Задача #2
 * Описать классы: 
 * Студент, Предмет, Преподаватель. Один студент может посещать несколько предметов, 
 * один преподаватель может вести несколько предметов. Все поля должны быть приватными, 
 * а доступ к изменению или чтению полей должен осуществляться через методы. 
 * В конечном итоге все студенты должны сформироваться в группу (массив). 
 * При вызове метода Info в классе Program который принимает группу студентов, 
 * на экран должна выводиться информация о каждом студенте: имя, год рождения, 
 * номер телефона, курс, количество предметов которые посещает, 
 * количество преподавателей, которые ведут эти предметы
 */
namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();
            
            students.Add(new Student("Андрей1", 1999, "+38(000)000-00-56", 3));
            students.Add(new Student("Андрей2", 1989, "+38(000)000-00-12", 2));
            students.Add(new Student("Андрей3", 1979, "+38(000)000-00-34", 4));
            
            teachers.Add(new Teacher("Andrey1"));
            teachers.Add(new Teacher("Andrey2"));
            teachers.Add(new Teacher("Andrey3"));
            teachers.Add(new Teacher("Andrey4"));
            teachers.Add(new Teacher("Andrey5"));

            subjects.Add(new Subject("Programming Course1"));
            subjects.Add(new Subject("Programming Course2"));
            subjects.Add(new Subject("Programming Course3"));
            subjects.Add(new Subject("Programming Course4"));

            subjects[0].AddTeacher(teachers[3]);
            subjects[0].AddTeacher(teachers[0]);
            
            subjects[1].AddTeacher(teachers[2]);
            subjects[2].AddTeacher(teachers[1]);
            subjects[3].AddTeacher(teachers[3]);

            students[0].AddSubject(subjects[0]);
            students[0].AddSubject(subjects[2]);
            students[0].AddSubject(subjects[3]);

            students[1].AddSubject(subjects[1]);
            students[1].AddSubject(subjects[2]);
            
            students[2].AddSubject(subjects[1]);


            Info(students);
            Console.ReadKey();
        }

        static void Info(List<Student> students)
        {
            foreach(Student student in students){
                Console.Write("Имя: ");
                Console.WriteLine(student.GetName());
                Console.Write("Курс: ");
                Console.WriteLine(student.GetCourse());
                Console.Write("телефон: ");
                Console.WriteLine(student.GetPhone());
                List<Subject> subjects = student.GetSubjects();
                Console.Write("Количество предметов: ");
                Console.WriteLine(student.GetSubjects().Count);
                Console.Write("Предметы:\n");
                foreach (Subject subject in student.GetSubjects()){
                    Console.Write(subject.GetName());
                    Console.Write(": ");
                    Console.Write(subject.GetTeachers().Count);
                    Console.Write("\n");
                }
                Console.Write("\n");
                
            }
        }

    }
}
