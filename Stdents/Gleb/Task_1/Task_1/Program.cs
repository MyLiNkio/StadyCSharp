using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 21;
            int[] Y = new int[i];
            double[] X = new double[i];

            i = 0;

            for (double x = -5; x <= 5; x += 0.5)
            {
                X[i] = x;
                //Console.WriteLine(X[i]);
                Y[i] = Convert.ToInt32((function(x) * 10));
                //Console.WriteLine(Y[i]);
                i++;
            }

            string[,] Area = new string[i*2 + 4, i*5 + 2];
            for (int k = 0; k < i*2 + 4; k++)
            {
                int w = 0;
                for (int j = 0; j < i*5 + 2; j++)
                {
                    Area[k, j] = " ";
                    Area[45, j] = "-";
                    if (j % 5 == 0)
                    {
                        Area[k, j] = ".";
                        Area[45, j] = "+";
                    }
                    //Area[k, 55] = "|";

                    double znachenie = 45 - k;
                    string znachenie_string = Convert.ToString(znachenie / 10);
                    if (znachenie_string.Length == 1)
                        znachenie_string = znachenie_string + "  ";
                    Area[k, 0] = znachenie_string;
                }
            }


            for (int k = 0; k < i * 2 + 4; k++)
            {
                int w = 0;
                for (int j = 0; j < i * 5 + 2; j++)
                {
                    if (j % 5 == 0)
                    {
                        if (w == 21)
                            w = 20;
                        Area[45 - Y[w], (w + 1) * 5] = "@";
                        w++;
                    }
                    Area[k, 55] = "|";
                    Console.Write(Area[k, j]);
                }
                Console.WriteLine();
            }


            Console.Write("   ");
            int a = 5;
            string argument_string = null;
            for (int j = 0; j < i; j++)
            {
                argument_string = Convert.ToString(X[j]);
                argument_string = argument_string.PadLeft(a, ' ');
                Console.Write(argument_string);
                argument_string = null;
            }
            
            Console.Read();
        }

        static double function(double x)
        {
            return 0.1 * x * x + 2;
        }
    }

}
