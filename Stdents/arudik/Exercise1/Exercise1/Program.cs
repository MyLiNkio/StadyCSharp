using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /*
    Задача 1
    Есть функция: y = 0.1*x*x + 2
    1. Рассчитать значение функции при фиксированном значении х.
    2. Рассчитать все значения функции при изменении х в пределах от -5 до 5 с шагом 0,5
    3. Построить с помощью символов таблицы ascii (точки для графика, 
     * вертикальные и горизонтальные линии для системы координат) 
     * график функции в соответствии с результатами п.2. 
     * (если точка функции попадает на линию системы координат, 
     * преимущество остается за системой координат)
     * 3. Построить график функции в соответствии с результатами п.2. 
     * С лева на консоле должны быть числа шкалы У, снизу - числа шкалы Х
     */

    class Program
    {
        static void Main(string[] args)
        {
            List<double> arrX = new List<double>();
            List<double> arrY = new List<double>();
            
            /* Заполняем списки значениями*/
            for (double i = -5; i <= 5; i += 0.5){
                arrX.Add(i);
                arrY.Add(funcY(i));
            }

            /* рисуем функцию */
            for (int i = 0; i < arrY.Count; i++)
            {
                Console.SetCursorPosition((int)(arrX[i] * 10 + 50 + 4), (int)Math.Abs((int)Math.Round(arrY[i] * 10) - 50));
                Console.Write("■");
            }

            /* вертикальные оси */
            for (int i = 0; i < 50; i++)
            {
                /* отсчеты */
                if (i % 5 == 0)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write((double)(50 - i) * 0.1);
                }

                /* боковая вертикальная ось */
                Console.SetCursorPosition(0 + 4, i);
                Console.Write("|");
            }

            /* горизонтальная ось внизу */
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(i + 4, 50);
                Console.Write("-");
                if (i % 10 == 0)
                {
                    Console.SetCursorPosition(i + 4, 50 + 1);
                    Console.Write((double)(i - 50) * 0.1);
                }
            }

            Console.ReadKey();

        }

        static double funcY(double x)
        {
            return (0.1 * x * x + 2);
            //return 2 * Math.Sin(x);
        } 
        
    }
}
