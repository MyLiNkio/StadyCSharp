using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2_School
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WindowWidth = 200;
			Console.WindowHeight = 200;

			Console.ReadKey();

            Subject subject0 = new Subject();
            subject0.subject = "English";
            Subject subject1 = new Subject();
            subject1.subject = "Math";
            Subject subject2 = new Subject();
            subject2.subject = "Biology";
            Subject subject3 = new Subject();
            subject3.subject = "Geography";
            Subject subject4 = new Subject();
            subject4.subject = "History";

            Subject[] subjects = new Subject[5];
            subjects[0] = subject0;
            subjects[1] = subject1;
            subjects[2] = subject2;
            subjects[3] = subject3;
            subjects[4] = subject4;

            ///////////////////////////////////////////////////////////

            Student student0 = new Student(); ;
            student0.Name = "Mark";
            student0.Bithday = "12.05.2000";
            student0.Telephone = "0951234910";
            student0.Rang = "1";
            student0.NumberOfSubjects = 3;
            student0.AddSubject(subjects[0]);
            student0.AddSubject(subjects[2]);
            student0.AddSubject(subjects[4]);


            Student student1 = new Student(); ;
            student1.Name = "Greg";
            student1.Bithday = "17.08.2000";
            student1.Telephone = "0951282054";
            student1.Rang = "1";
            student1.NumberOfSubjects = 2;
            student1.AddSubject(subjects[3]);
            student1.AddSubject(subjects[4]);

            Student student2 = new Student(); ;
            student2.Name = "Anna";
            student2.Bithday = "30.01.1999";
            student2.Telephone = "0671231210";
            student2.Rang = "1";
            student2.NumberOfSubjects = 1;
            student2.AddSubject(subjects[1]);

            ///////////////////////////////////////////////////////////////

            Student[] group = new Student[3];
            group[0] = student0;
            group[1] = student1;
            group[2] = student2;

            ////////////////////////////////////////////////////////////////

            Teacher teacher0 = new Teacher();
            teacher0.Name = "Stive";
            teacher0.AddSubject(subjects[0]);

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Mike";
            teacher1.AddSubject(subjects[1]);

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Arnold";
            teacher2.AddSubject(subjects[2]);

            Teacher teacher3 = new Teacher();
            teacher3.Name = "Ronaldo";
            teacher3.AddSubject(subjects[3]);

            Teacher teacher4 = new Teacher();
            teacher4.Name = "Gleb";
            teacher4.AddSubject(subjects[4]);

            ////////////////////////////////////////////////////////

            Info(group);
            Console.Read();

        }

        static void Info(Student[] students)
        {
            foreach (var student in students)
            {

                Console.WriteLine("Студент " + student.Name + ", " + student.Rang + " курса");
                Console.WriteLine("Год рожения " + student.Bithday + ", контактный номер " + student.Telephone);
                Console.WriteLine("Посещает " + student.NumberOfSubjects + " предметов");
                Console.WriteLine();
            }           
        }
    }
}
