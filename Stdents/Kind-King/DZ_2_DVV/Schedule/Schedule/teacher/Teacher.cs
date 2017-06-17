using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Schedule.student;
using Schedule.discipline;
using Schedule.teacher;
using Schedule.auxiliary_tools;

namespace Schedule.teacher
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        private string surname;
        private Date birthday;
        //private MobileNumber[] mobileNumbers = new MobileNumber[1];
        private List<MobileNumber> mobileNumbers = new List<MobileNumber>();
        private Curs curs;
        private List<Discipline> disciplines = new List<Discipline>();
        //private List<Student> students = new List<Student>(); Студенти не у викладача а у дисципліни!

        public void SetCurs(Curs curs)
        {
            if (curs >= Curs.postgraduate)
                this.curs = curs;
            else Console.WriteLine("Error!");
        }

        public Teacher(string firstName, string lastName, string surname, Date birthday, MobileNumber mobileNumber, Curs curs) : this(firstName, lastName, surname, birthday, mobileNumber)
        {
            SetCurs(curs);
        }

        public Teacher(string firstName, string lastName, string surname, Date birthday, MobileNumber mobileNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.surname = surname;
            this.birthday = birthday;
            AddMobile(mobileNumber);
        }


        public void AddDiscipline(Discipline discipline) // Було б непогано зробити ... template
        {
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline) // Було б непогано зробити ... template
        {
            disciplines.RemoveAt(disciplines.BinarySearch(discipline));
        }

        public Discipline GetDiscipline(int i)
        {
            if (disciplines[i] != null && disciplines.Count() > i)
                return disciplines[i];
            else
                return GetDiscipline(i - 1);
        }

        public void RewriteMobile(Discipline newDiscipline, Discipline oldDiscipline)
        {
            if (disciplines.Contains(oldDiscipline))
            {
                disciplines.Insert(disciplines.BinarySearch(oldDiscipline), newDiscipline);
            }
        }


        //public void AddStudent(Student student) // Було б непогано зробити ... template
        //{
        //    students.Add(student);
        //}

        //public void RemoveStudent(Student student) // Було б непогано зробити ... template
        //{
        //    students.RemoveAt(students.BinarySearch(student));
        //}

        //public Student GetStudent(int i)
        //{
        //    if (students[i] != null && students.Count() > i)
        //        return students[i];
        //    else
        //        return GetStudent(i - 1);
        //}

        //public void RewriteStudent(Student newStudent, Student oldStudent)
        //{
        //    if (students.Contains(oldStudent))
        //    {
        //        students.Insert(students.BinarySearch(oldStudent), newStudent);
        //    }
        //}


        //template <class T> не проконало :(

        public void AddMobile(MobileNumber mobileNumber) // Було б непогано зробити ... template
        {
            mobileNumbers.Add(mobileNumber);
        }

        public void RemoveMobile(MobileNumber mobileNumber) // Було б непогано зробити ... template
        {
            mobileNumbers.RemoveAt(mobileNumbers.BinarySearch(mobileNumber));
        }

        public string GetMobileNumber(int i)
        {
            if (mobileNumbers[i] != null && mobileNumbers.Count() > i)
                return mobileNumbers[i].GetMobileNumber();
            else
                return GetMobileNumber(i - 1);
        }

        public void RewriteMobile(MobileNumber newMobileNumber, MobileNumber oldMobileNumber)
        {
            if (mobileNumbers.Contains(oldMobileNumber))
            {
                mobileNumbers.Insert(mobileNumbers.BinarySearch(oldMobileNumber), newMobileNumber);
            }
        }

        public string GetBirthday(Format type)
        {
            return birthday.GetDate(type);
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetCurse()
        {
            switch (curs)
            {
                case Curs.postgraduate:
                    return "Аспірант";
                case Curs.practices:
                    return "Практик";
                case Curs.lecturer:
                    return "Лектор";
                case Curs.professor:
                    return "Професор";
                default:
                    return ""; 
            }
        }
    }
}
