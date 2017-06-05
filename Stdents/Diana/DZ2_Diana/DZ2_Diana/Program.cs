using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DZ2_Diana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Best students of RTF *****\n");

            string[] dyhovychnyi = new string[] { "Lineyka", "Difur", "Matan" };
            string[] antonets = new string[] { "Vstup", "Dzherela", "RPdP" };
            string[] mogilnyi = new string[] { "DSP", "DigitalDev" };

            string[] dianless = new string[] { mogilnyi[0], antonets[1], antonets[2], dyhovychnyi[2] };
            string[] vikaless = new string[] { mogilnyi[0], antonets[1], antonets[2], dyhovychnyi[0], mogilnyi[1] };
            string[] vovaless = new string[] { antonets[1], antonets[2] };
            string[] andrless = new string[] { antonets[2], dyhovychnyi[1] };


            Student[] studList = new Student[4];
            studList[0] = new Student("Diana", 1997, "066*******", 3, dianless.Length, 3);
            studList[1] = new Student("Vika", 1997, "095*******", 3, vikaless.Length, 3);
            studList[2] = new Student("Vova", 1997, "090*******", 3, vovaless.Length, 1);
            studList[3] = new Student("Andrey", 1997, "090*******", 3, andrless.Length, 2);
            Info(studList);

            Console.ReadKey();

        }
        static void Info(Student[] studList)
        {

            Console.WriteLine("|  Name  |  Year of birth  |   Phone number  | Course | Number of lessons | Number of professors |\n");

            foreach (Student stu in studList)
            {
                stu.PrintStud();
            }

        }
    }
}
