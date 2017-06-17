using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Schedule.student;
using Schedule.discipline;
using Schedule.teacher;
using Schedule.auxiliary_tools;

namespace Schedule.student
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string surname;
        private Date birthday;
        //private MobileNumber[] mobileNumbers = new MobileNumber[1];
        private List<MobileNumber> mobileNumbers = new List<MobileNumber>(); 
        private Curs curs;
        private List<Discipline> disciplines = new List<Discipline>();
        //private List<Teacher> teachers = new List<Teacher>(); Викладачi не у студентiв а у дисциплiни!

        public void SetCurs(Curs curs)
        {
            if (curs < Curs.postgraduate)
                this.curs = curs;
            else Console.WriteLine("Error!");
        }

        public Student(string firstName, string lastName, string surname, Date birthday, MobileNumber mobileNumber, Curs curs) : this(firstName, lastName, surname, birthday, mobileNumber)
        {
            SetCurs(curs);
        }

        public Student(string firstName, string lastName, string surname, Date birthday, MobileNumber mobileNumber) 
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
        public int GetNumberDiscipline()
        {
            return disciplines.Count();
        }

        public void RewriteDiscipline(Discipline newDiscipline, Discipline oldDiscipline)
        {
            if (disciplines.Contains(oldDiscipline))
            {
                disciplines.Insert(disciplines.BinarySearch(oldDiscipline), newDiscipline);
            }
        }


        //public void AddTeacher(Teacher teacher) // Було б непогано зробити ... template
        //{
        //    teachers.Add(teacher);
        //}

        //public void RemoveTeacher(Teacher teacher) // Було б непогано зробити ... template
        //{
        //    teachers.RemoveAt(teachers.BinarySearch(teacher));
        //}

        //public Teacher GetTeacher(int i)
        //{
        //    if (teachers[i] != null && teachers.Count() > i)
        //        return teachers[i];
        //    else
        //        return GetTeacher(i - 1);
        //}

        //public void RewriteTeacher(Teacher newTeacher, Teacher oldTeacher)
        //{
        //    if (teachers.Contains(oldTeacher))
        //    {
        //        teachers.Insert(teachers.BinarySearch(oldTeacher), newTeacher);
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
            if (mobileNumbers.Count() > i && mobileNumbers[i] != null)
                return mobileNumbers[i].GetMobileNumber();
            else
                return "";
        }

        public int GetNumberMobileNumbers()
        {
            return mobileNumbers.Count();
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

        public string GetCurse() // switch() return string
        {
            switch (curs)
            {
                case Curs.applicant:
                    return "Абiтурiєнт";
                case Curs.first:
                    return "Перший";
                case Curs.second:
                    return "Другий";
                case Curs.third:
                    return "Третiй";
                case Curs.fourth:
                    return "Четвертий";
                case Curs.fifth:
                    return "П'ятий";
                case Curs.sixth:
                    return "Шостий";
                default:
                    return "";
            }
        }
    }

    public enum Curs
    {
        applicant = 0, // абiтурiєнт
        first = 1,
        second = 2,
        third = 3,
        fourth = 4,
        fifth = 5,
        sixth = 6,
        postgraduate = 7, // аспiрант
        practices = 8, // практик
        lecturer = 9, // лектор
        professor = 10, //....
    }
}
