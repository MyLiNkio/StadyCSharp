using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1_Diana
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)------------------------------------------------------
            Console.Clear();
            double x1, y1;
            Console.WriteLine("Type x \n");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x = {0}", x1);
            y1 = 0.1 * x1 * x1 + 2;
            Console.WriteLine("y = 0.1 * {0} * {0} + 2 = {1}", x1, y1);
            Console.ReadKey();

            //2)-------------------------------------------------
            Console.Clear();
            for (double x2 = -5; x2 <= 5; x2 = x2 + 0.5)
            {
                double y2 = 0.1 * x2 * x2 + 2;
                Console.WriteLine("x = {0}, y = {1}", x2, y2);
            }
            Console.ReadKey();


            //3)----------------------------------------------
            Console.Clear();
            double[] MatY = new double[21];
            for (int i = 0; i <= 10; i++)
            {
                MatY[i] = 0.1 * (-5 + i * 0.5) * (-5 + i * 0.5) + 2;
                Console.Write("|");
                Console.Write(MatY[i] + "\n\n");
            }


            double[,] MatX = new double[1, 21];
            for (int i = 0; i < 1; i++)
                for (int j = 0; j < 21; j++)
                    MatX[i, j] = -5 + j * 0.5;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (MatX[i, j] > 0)
                        Console.Write(" +" + MatX[i, j]);
                    else
                        Console.Write(" " + MatX[i, j]);
                }
                Console.WriteLine();
            }

            int startposx = 42;
            int startposy = 33;
            int ky = 7;
            int kx = 8;
            for (double x = -5; x <= 5; x = x + 0.5)
            {
                double y = (0.1 * (x * x) + 2) * ky;
                Console.SetCursorPosition((int)(startposx + x * kx), (int)(startposy - y));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Convert.ToChar(120));
            }

            Console.ReadLine();

        }

    }

}

