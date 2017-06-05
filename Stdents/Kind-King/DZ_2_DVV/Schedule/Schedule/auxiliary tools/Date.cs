using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Schedule.student;
using Schedule.discipline;
using Schedule.teacher;
using Schedule.auxiliary_tools;

namespace Schedule.auxiliary_tools
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string Month(int month)
        {
            switch (month)
            {
                case 1:
                    return "Сiчня";
                case 2:
                    return "Лютого";
                case 3:
                    return "Березня";
                case 4:
                    return "Квiтня";
                case 5:
                    return "Травня";
                case 6:
                    return "Червня";
                case 7:
                    return "Липня";
                case 8:
                    return "Серпня";
                case 9:
                    return "Вересня";
                case 10:
                    return "Жовтня";
                case 11:
                    return "Листопада";
                case 12:
                    return "Грудня";
                default: return "Error";
            }
        }
        public void PrintDate(Date date, Format form)
        {
            switch (form)
            {
                case Format.type_1:
                    Console.WriteLine("{0}.{1}.{2}", date.day, date.month, date.year);
                    break;
                case Format.type_2:
                    Console.WriteLine("{1}.{0}.{2}", date.day, date.month, date.year);
                    break;
                case Format.type_3:
                    Console.WriteLine("{0}.{1}.{2}", date.day, date.month, date.year % 100 );
                    break;
                case Format.type_4:
                    Console.WriteLine("День: {0}, Мiсяць: {1} Рiк: {2}", date.day, date.month, date.year);
                    break;
                case Format.type_5:
                    Console.WriteLine("{0} {1} {2}", date.day, date.Month(month), date.year);
                    break;
            }
        }

        public string GetDate(Format form)
        {
            switch (form)
            {
                case Format.type_1:
                    return (day + "." + month + "." + year);
                case Format.type_2:
                    return (month + "." + day + "." + year);
                case Format.type_3:
                    return (day + "." + month + "." + year % 100);
                case Format.type_4:
                    return ("День: " + day + "Мiсяць: " + month + "Рiк: " + year);
                case Format.type_5:
                    return day + " " + Month(month) + " " + year;
                case Format.type_6:
                    return day + " " + Month(month) + " " + year % 100;
                default: return "";
            }
        }
    }

    public enum Format
    {
        type_0,
        type_1,
        type_2,
        type_3,
        type_4,
        type_5,
        type_6,
    }

}
