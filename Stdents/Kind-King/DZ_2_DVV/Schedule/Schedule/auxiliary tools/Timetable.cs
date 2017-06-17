using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.auxiliary_tools
{
    public class Couple
    {
        private int hoarBegin;
        private int minuteBegin;
        private int hoarEnd;
        private int minuteEnd;
        private int couple;

        public int GetCouple()
        {
            return couple;
        }
        public Couple(int couple)
        {
            this.couple = couple;
            switch (couple)
            {
                case 1:
                    hoarBegin = 8; minuteBegin = 30;
                    hoarEnd = 10; minuteEnd = 5;
                    break;
                case 2:
                    hoarBegin = 10; minuteBegin = 25;
                    hoarEnd = 12; minuteEnd = 0;
                    break;
                case 3:
                    hoarBegin = 12; minuteBegin = 20;
                    hoarEnd = 13; minuteEnd = 55;
                    break;
                case 4:
                    hoarBegin = 14; minuteBegin = 15;
                    hoarEnd = 15; minuteEnd = 50;
                    break;
                case 5:
                    hoarBegin = 16; minuteBegin = 10;
                    hoarEnd = 17; minuteEnd = 45;
                    break;
                case 6: // В КПІ 6 пара трiшки не така, але всi викладачi її проводять так
                    hoarBegin = 18; minuteBegin = 5;
                    hoarEnd = 19; minuteEnd = 40;
                    break;
                default:
                    hoarBegin = 0; minuteBegin = 0;
                    hoarEnd = 0; minuteEnd = 0;
                    this.couple = 0;
                    break;  
            }
        }
        public string GetTimeBegin()
        {
            return hoarBegin +"." + minuteBegin;
        }
        public string GetTimeEnd()
        {
            return hoarEnd + "." + minuteEnd;
        }
    }

    public class Timetable
    {
        private DaysOfWeek dayOfWeek;
        private Week week;
        private Semester semester;
        private Couple couple;

        public Timetable(Semester semester, Week week, DaysOfWeek dayOfWeek, Couple couple)
        {
            this.semester = semester;
            this.week = week;
            this.dayOfWeek = dayOfWeek;
            this.couple = couple;
        }

        public string Month(int month)
        {
            switch (month)
            {
                case 1:
                    return "Сiченя";
                case 2:
                    return "Лютого";
                case 3:
                    return "Березеня";
                case 4:
                    return "Квiтеня";
                case 5:
                    return "Травеня";
                case 6:
                    return "Червеня";
                case 7:
                    return "Липеня";
                case 8:
                    return "Серпеня";
                case 9:
                    return "Вересеня";
                case 10:
                    return "Жовтеня";
                case 11:
                    return "Листопада";
                case 12:
                    return "Груденя";
                default: return "Error";
            }
        }

        public void PrintTimetable(Timetable timetable)
        {
            Console.Write("Day of week: {0}, ", GetDaysOfWeek());
            Console.Write("Week: {0}, ", GetWeek());
            Console.Write("Semester: {0}, ", GetSemester());
            Console.WriteLine("Couple: {0}", GetCouple());
        }

        public string GetTimetable()
        {
            return "Day of week: " + GetDaysOfWeek() + ", Week: " + GetWeek() + 
                "Semester: " + GetSemester() + "/nCouple: " + GetCouple() + 
                "/nBegin: " + couple.GetTimeBegin() + "End: " + couple.GetTimeEnd();
        }

        private string GetDaysOfWeek()
        {
            switch (dayOfWeek)
            {
                case DaysOfWeek.Monday:
                    return "Monday";
                case DaysOfWeek.Tuesday:
                    return "Tuesday";
                case DaysOfWeek.Wednesday:
                    return "Wednesday";
                case DaysOfWeek.Thursday:
                    return "Thursday";
                case DaysOfWeek.Friday:
                    return "Friday";
                case DaysOfWeek.Saturday:
                    return "Saturday";
                case DaysOfWeek.Sunday:
                    return "Sunday";
                default: return "";
            }
        }
        private string GetWeek()
        {
            switch (week)
            {
                case Week.First:
                    return "First";
                case Week.Second:
                    return "Second";
                default: return "";
            }
        }
        private string GetSemester()
        {
            switch (semester)
            {
                case Semester.First:
                    return "First";
                case Semester.Second:
                    return "Second";
                default: return "";
            }
        }
        private string GetCouple()
        {
            return couple.GetCouple().ToString();
        }
    }

    public enum DaysOfWeek
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
    }

    public enum Week
    {
        First = 0,
        Second = 1,
    }

    public enum Semester
    {
        First = 0,
        Second = 1,
    }
}
