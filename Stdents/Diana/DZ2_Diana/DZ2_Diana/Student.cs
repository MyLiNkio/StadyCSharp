using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Diana
{
    class Student
    {
        private string Name;
        private int Age;
        private string PhoneNumber;
        private int Course;
        private int NumberOfLessons;
        private int NumberOfProfessors;

        public void PrintStud()
        {
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}\t\t{4}\t\t{5}\n", Name, Age, PhoneNumber, Course, NumberOfLessons, NumberOfProfessors);
        }

        public Student(string nm, int age, string phone, int cours, int less, int prof)
        {
            Name = nm;
            Age = age;
            PhoneNumber = phone;
            Course = cours;
            NumberOfLessons = less;
            NumberOfProfessors = prof; 
        }

    }
}
