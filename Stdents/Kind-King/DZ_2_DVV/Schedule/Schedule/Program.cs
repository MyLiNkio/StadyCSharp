using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Schedule.student;
using Schedule.discipline;
using Schedule.teacher;
using Schedule.auxiliary_tools;

namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача #2
              Описать классы: 
              Студент, Предмет, Преподаватель.
              Один студент может посещать несколько предметов, 
              один преподаватель может вести несколько предметов.
              Все поля должны быть приватными, 
              а доступ к изменению или чтению полей 
              должен осуществляться через методы.
              В конечном итоге все студенты должны сформироваться в группу(массив).
              При вызове метода Info в классе Program 
              который принимает группу студентов, 
              на экран должна выводиться информация о каждом студенте: 
              имя, год рождения, номер телефона, курс, 
              количество предметов которые посещает,
              количество преподавателей, которые ведут эти предметы.
              */
            // https://habrahabr.ru/post/49808/
            // В языке C# снято существенное ограничение языка C++ на статичность массивов.
            // Массивы в языке C# являются настоящими динамическими массивами.
            Console.WriteLine("Початок");

            List<Student> group_RS_41 = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Discipline> discipline = new List<Discipline>();

            Console.WriteLine("Перепис студентiв пiсля сесiї");
            group_RS_41.Add(new Student("Вова", "Думанський", "Валерiйович", new Date(27, 07, 1996), new MobileNumber(380, 067, 7519415), Curs.third)); // Вiйни клонiв
            // group_RS_41[0].AddMobile(new MobileNumber(380, 067, 7519415)); // i тут до мене дiйшло що краще перший номер помiстити при створенi обєкту...
            group_RS_41[0].AddMobile(new MobileNumber(380, 066, 5986502));
            group_RS_41.Add(new Student("Вовчик", "Думанський", "Валерiйович", new Date(27, 07, 1996), new MobileNumber(), Curs.third));
            group_RS_41[1].AddMobile(new MobileNumber(380, 067, 7519415));
            group_RS_41.Add(new Student("Вован", "Думанський", "Валерiйович", new Date(27, 07, 1996), new MobileNumber(), Curs.third));
            group_RS_41[2].AddMobile(new MobileNumber(380, 066, 5986502));
            group_RS_41.Add(new Student("Вовк", "Думанський", "Валерiйович", new Date(27, 07, 1996), new MobileNumber(), Curs.third)); // А цi двоє без мобiлок :)
            group_RS_41.Add(new Student("Володимир", "Думанський", "Валерiйович", new Date(27, 07, 1996), new MobileNumber(), Curs.third));

            Console.WriteLine("КПI наймає викладачiв");
            teachers.Add(new Teacher("Микола", "Iгорович", "Ястребов", new Date(32, 11, 1941), new MobileNumber(), Curs.lecturer));
            //AddDiscipline(new Discipline());
            teachers.Add(new Teacher("Сергiй", "Борисович", "Могильний", new Date(32, 12, 1941), new MobileNumber(), Curs.lecturer));
            teachers.Add(new Teacher("Вiталi", "Сергiйович", "Мосiйсук", new Date(32, 10, 1985), new MobileNumber(), Curs.lecturer));
            teachers.Add(new Teacher("Олександр", "Михайлович", "Купрiй", new Date(32, 5, 1941), new MobileNumber(), Curs.practices));

            // Деканат створює розклад
            Console.WriteLine("Деканат створює розклад");

            Console.WriteLine("Лекцiя Електродинамiка");
            discipline.Add(new Discipline("Лекцiя Електродинамiка", teachers[3]));
            //discipline[0].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Monday, new Couple(1)));
            discipline[0].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Tuesday, new Couple(3)));
            discipline[0].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Wednesday, new Couple(2)));
            //discipline[0].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Thursday, new Couple(4)));
            discipline[0].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Friday, new Couple(1)));
            discipline[0].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Saturday, new Couple(1))); // Скотиняки навыть на суботу пари ставлять!

            Console.WriteLine("Практика Електродинамiка");
            discipline.Add(new Discipline("Практика Електродинамiка", teachers[3]));
            discipline[1].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Monday, new Couple(1)));
            //discipline[1].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Tuesday, new Couple(3)));
            //discipline[1].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Wednesday, new Couple(2)));
            discipline[1].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Thursday, new Couple(4)));
            //discipline[1].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Friday, new Couple(1)));
            //discipline[1].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Saturday, new Couple(1))); // Скотиняки навыть на суботу пари ставлять!

            Console.WriteLine("Лекцiя Цифровi пристрої");
            discipline.Add(new Discipline("Лекцiя Цифровi пристрої", teachers[1]));
            //discipline[2].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Monday, new Couple(2)));
            discipline[2].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Tuesday, new Couple(2)));
            //discipline[2].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Wednesday, new Couple(4)));
            discipline[2].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Thursday, new Couple(2)));
            discipline[2].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Friday, new Couple(2)));

            Console.WriteLine("Практика Цифровi пристрої");
            discipline.Add(new Discipline("Практика Цифровi пристрої", teachers[1]));
            discipline[3].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Monday, new Couple(2)));
            //discipline[3].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Tuesday, new Couple(2)));
            discipline[3].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Wednesday, new Couple(4)));
            //discipline[3].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Thursday, new Couple(2)));
            //discipline[3].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Friday, new Couple(2)));

            Console.WriteLine("Лекцiя Основи теорiї кiл");
            discipline.Add(new Discipline("Лекцiя Основи теорiї кiл", teachers[0]));
            //discipline[4].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Monday, new Couple(3)));
            discipline[4].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Tuesday, new Couple(1)));
            //discipline[4].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Wednesday, new Couple(1)));
            discipline[4].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Thursday, new Couple(3)));
            // У пятницю не буде :)
            discipline[2].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Saturday, new Couple(2))); // Скотиняки навыть на суботу пари ставлять!

            Console.WriteLine("Практика Основи теорiї кiл");
            discipline.Add(new Discipline("Практика Основи теорiї кiл", teachers[0])); 
            discipline[5].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Monday, new Couple(3)));
            //discipline[5].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Tuesday, new Couple(1)));
            discipline[5].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Wednesday, new Couple(1)));
            //discipline[5].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Thursday, new Couple(3)));
            // У пятницю не буде :)
            //discipline[5].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Saturday, new Couple(2))); // Скотиняки навыть на суботу пари ставлять!

            Console.WriteLine("Понаднормовi заняття");
            discipline.Add(new Discipline("Понаднормовi заняття", teachers[2]));
            discipline[6].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Monday, new Couple(4)));
            discipline[6].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Tuesday, new Couple(4)));
            discipline[6].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Wednesday, new Couple(3)));
            discipline[6].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Thursday, new Couple(1)));
            discipline[6].AddCouple(new Timetable(Semester.First, Week.First, DaysOfWeek.Friday, new Couple(3)));

            Console.WriteLine("Тепер викладачi дiзнаються свiй розклад");
            // Тепер викладачi дiзнаються свiй розклад // Вони можуть i помилитися :)
            // У одного вкладача може бути декiлька дисциплiн
            teachers[0].AddDiscipline(discipline[4]); teachers[0].AddDiscipline(discipline[5]);
            teachers[1].AddDiscipline(discipline[2]); teachers[1].AddDiscipline(discipline[3]);
            teachers[2].AddDiscipline(discipline[6]);
            teachers[3].AddDiscipline(discipline[0]); teachers[3].AddDiscipline(discipline[1]);

            Console.WriteLine("Тепер студенти дiзнаються свiй розклад");
            // Тепер студенти дiзнаються свiй розклад
            // По групам звичайно ж
            for (int i = 0 /* у групi повинен залишитися хочаб хтось пiсля сесiї */; i < group_RS_41.Count(); i++ )
            {
                group_RS_41[i].AddDiscipline(discipline[1]);
                group_RS_41[i].AddDiscipline(discipline[2]);
                group_RS_41[i].AddDiscipline(discipline[3]);
                group_RS_41[i].AddDiscipline(discipline[4]);
            }

            // Тепер студенти повиннi пiти на пари а у викладачiв вони з'явитися, хоча можливо i не повиннi... 
            // По-iдеї треба тут зробити календар i вiдмiчати присутнiх i тд... але це довго (на наступний раз, якщо вiн буде)


            // Завершення симуляцiї та пiдбивання пiдсумкiв
            Console.WriteLine("____________________________________________________________________\n");
            Console.WriteLine("Завершення симуляцiї та пiдбивання пiдсумкiв");
            Console.WriteLine("____________________________________________________________________\n");
            Console.WriteLine("Група РС-41");
            Info(group_RS_41);
            Console.ReadLine();
        }

        static void Info(List<Student> group)
        {
            for (int i = 0; i < group.Count; i++)
            {
                Console.WriteLine("Студент: {1} {0} {2}", group[i].GetFirstName(), group[i].GetLastName(), group[i].GetSurname());
                Console.WriteLine("Рiк народження: {0}", group[i].GetBirthday(Format.type_6));
                Console.Write("Номер телефона: ");
                for (int k = 0; k < group[i].GetNumberMobileNumbers(); k++)
                    Console.Write("{0}\n                ", group[i].GetMobileNumber(k));
                Console.WriteLine();
                Console.WriteLine("Курс: {0}", group[i].GetCurse());
                Console.WriteLine("Вивчає такi дисциплiни: ");
                for (int j = 0; j < group[i].GetNumberDiscipline(); j++)
                {
                    // кiлькiсть пар на яких був // викладачi якi йому викладають
                    Console.WriteLine("{0},\tВикладач - {1}", group[i].GetDiscipline(j).GetName(), group[i].GetDiscipline(j).GetTeacher());
                }
                Console.WriteLine("____________________________________________________________________\n");
            }
        }
    }
}
