using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static float function(float x)
        {
            //return (float)(0.1 * x * x + 2);
            return (float)(0.02 * x * x * x * Math.Cos(x * x / 10) + 1 / Math.Exp(x * x) + 1);
            //return (x + (float)1.1);
        }
        static void Main(string[] args)
        {
            /*Задача1
            Есть функция: y = 0.1*x*x + 2
            1. Рассчитать значение функции при фиксированном значении х.
            2. Рассчитать все значения функции при изменении х в пределах от -5 до 5 с шагом 0,5
            3. Построить с помощью символов таблицы ascii (точки для графика, вертикальные и горизонтальные линии для системы координат)
            график функции в соответствии с результатами п.2. (если точка функции попадает на линию системы координат, преимущество остается за системой координат)
            */

            const int heightConsole = 60; // Висота поля
            Console.BufferWidth = 100; // Ширина поля (Рекомендовано виставляти парне число через часте ділення на 2 в програмі без переведення типу int в float)
            const int discrete = 5; // Дискретизація
            const int step = 5; // Крок відмалювання значень шкали

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < heightConsole; i++)
            {
                draw_the_line(i, heightConsole, discrete, step, false);
            }

            while (true)
            {
                Console.SetCursorPosition(25, heightConsole);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("y = ");
                float y = Convert.ToSingle(Console.ReadLine()); // float.Parse("41.00027357629127") //Convert.ToSingle(Console.ReadLine()) видає помилку при некоретних записах
                int Y = heightConsole / 2 - (int)Math.Round(y * discrete);
                // Треба зробити перевірку, але мені вже влом
                Console.BackgroundColor = ConsoleColor.Red;
                draw_the_line(Y, heightConsole, discrete, step, true);

                Console.SetCursorPosition(55, heightConsole);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("x = ");
                float x = Convert.ToSingle(Console.ReadLine()); // float.Parse("41.00027357629127")
                int X = (int)((float)Console.BufferWidth / 2 + Math.Round(x * discrete));
                // Треба зробити перевірку, але мені вже влом
                Console.BackgroundColor = ConsoleColor.Red;
                draw_the_column(X, heightConsole, discrete, step, true);

                Console.SetCursorPosition(33, heightConsole);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ENTER to Clear");
                Console.ReadLine();
                Clear(heightConsole, 30);

                Console.BackgroundColor = ConsoleColor.White;
                draw_the_column(X, heightConsole, discrete, step, false);
                draw_the_line(Y, heightConsole, discrete, step, false);
            }

        }

        static void Clear(int heightConsole, int row)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < row; i++)
            {
                Console.SetCursorPosition(0, heightConsole + i);
                Console.Write("                                                                                "); // 80 chars
            }
            Console.SetCursorPosition(0, heightConsole);
        }

        // public struct environment
        public class environment
        {
            public bool top;
            public bool down;
            public bool left;
            public bool right;
            //public bool top_right;
            //public bool top_left;
            //public bool down_right;
            //public bool down_left;
            public float futureSumCol, futureSumRow, oldSumCol, oldSumRow;
        }

        static void draw_the_column(int j, int heightConsole, int discrete, int step, bool flag)
        {
            int root = 0;
            float lineWidth = ((float)1 / (10 * discrete));
            float x = (j - (float)Console.BufferWidth / 2) / discrete;
            float y = -(0 - (float)heightConsole / 2) / discrete;
            float sum = (y + (float)1 / discrete) - function(x); // для oldSumRow
            environment roots = new environment();
            roots.futureSumCol = 0;
            roots.futureSumRow = (y) - function(x);

            //Console.SetCursorPosition(0, i);
            for (int i = 0; i < heightConsole; i++)
            {
                Console.SetCursorPosition(j, i);
                y = -((float)i - (float)heightConsole / 2) / discrete;
                x = ((float)j - (float)Console.BufferWidth / 2) / discrete;

                roots.oldSumRow = sum;
                roots.oldSumCol = (y) - function(x - (float)1 / discrete);
                sum = roots.futureSumRow;
                roots.futureSumCol = (y) - function(x + (float)1 / discrete);
                roots.futureSumRow = (y - (float)1 / discrete) - function(x);


                roots.left = sum > 0 ^ roots.oldSumCol > 0;
                roots.right = sum > 0 ^ roots.futureSumCol > 0;
                roots.top = sum > 0 ^ roots.oldSumRow > 0;
                roots.down = sum > 0 ^ roots.futureSumRow > 0;

                if (sum >= -lineWidth && sum <= lineWidth)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    if (flag)
                    {
                        Console.SetCursorPosition(55, heightConsole + ++root);
                        Console.WriteLine("y = {0}", ((float)i - (float)heightConsole / 2) / discrete); //(int)((float)Console.BufferWidth / 2 + Math.Round(x * discrete));
                        //((float)j - Console.BufferWidth / 2) / discrete
                        // Наче так , якщо не так то мені ...
                        Console.SetCursorPosition(j, i);
                    }
                    Console.Write("*");  // Точно до товщини лінії
                }
                else if ((roots.left || roots.right || roots.top || roots.down) // Перевірка на зміна знаку
                    && (Math.Abs(sum) < Math.Abs(roots.futureSumCol) && Math.Abs(roots.oldSumCol) > Math.Abs(sum) /* && Можливе ігнорування елементів */ || // Інгнорування елементів немає
                        Math.Abs(sum) < Math.Abs(roots.futureSumRow) && Math.Abs(roots.oldSumRow) > Math.Abs(sum))) // Дана точка є найбільш блищою до мінумуму? 
                {
                    //switch (roots) // Да ну так не прикольно! :( 
                    //{              // В С++ проконало б!
                    //    case 0x0000: // Якщо зробити структуру з одних булевих зміних!
                    //}

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (flag)
                    {
                        Console.SetCursorPosition(55, heightConsole + ++root);
                        Console.WriteLine("y = {0}", ((float)i - (float)heightConsole / 2) / discrete); //(int)((float)Console.BufferWidth / 2 + Math.Round(x * discrete));
                        // Наче так , якщо не так то мені ...
                        Console.SetCursorPosition(j, i);
                    }
                    if (roots.left && !roots.right && !roots.top && !roots.down) // По одному і по три
                        Console.Write("[");
                    else if (!roots.left && roots.right && roots.top && roots.down)
                        Console.Write("}");
                    else if (!roots.left && roots.right && !roots.top && !roots.down)
                        Console.Write("]");
                    else if (!roots.left && roots.right && !roots.top && !roots.down)
                        Console.Write("{");
                    else if (!roots.left && !roots.right && roots.top && !roots.down)
                        Console.Write("\"");
                    else if (roots.left && roots.right && !roots.top && roots.down)
                        Console.Write("U");
                    else if (!roots.left && !roots.right && !roots.top && roots.down)
                        Console.Write("_");
                    else if (roots.left && roots.right && roots.top && !roots.down)
                        Console.Write("^");
                    else if (roots.left && roots.right && !roots.top && !roots.down) // По парі
                        Console.Write("─");
                    else if (!roots.left && !roots.right && roots.top && roots.down)
                        Console.Write("|");
                    else if (roots.left && !roots.right && roots.top && !roots.down)
                        Console.Write("┘");
                    else if (!roots.left && roots.right && !roots.top && roots.down)
                        Console.Write("┌");
                    else if (roots.left && !roots.right && !roots.top && roots.down)
                        Console.Write("┐");
                    else if (!roots.left && roots.right && roots.top && !roots.down)
                        Console.Write("└");
                    else if (roots.left && roots.right && roots.top && roots.down) // По чотири
                        Console.Write("┼");
                    else Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    if (j == Console.BufferWidth / 2 - 4)
                    {
                        if (i == heightConsole / 2)
                            Console.Write((j % step == Console.BufferWidth / 2 % step) ? "╬" : "═");
                        else if (i % step == heightConsole / 2 % step)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("{0}", (float)(-i + heightConsole / 2) / discrete);
                            //j = Console.CursorLeft - 1; // по ідеї це треба переписати але мені вже впадлу
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        else
                            Console.Write(" ");
                    }
                    else if (j == Console.BufferWidth / 2)
                        Console.Write((i % step == heightConsole / 2 % step) ? "╬" : "║");
                    else if (i == heightConsole / 2 - 1)
                    {
                        if (j % step == Console.BufferWidth / 2 % step)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("{0}", (float)(j - Console.BufferWidth / 2) / discrete);
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            if (Console.CursorTop == heightConsole / 2 - 1)
                            {
                                //j = Console.CursorLeft - 1; // по ідеї це треба переписати але мені вже впадлу
                            }
                            else
                            {
                                Console.SetCursorPosition(j, i);
                                Console.Write(" ");
                            }
                        }
                        else
                            Console.Write(" ");
                    }
                    else if (i == heightConsole / 2)
                        Console.Write((j % step == Console.BufferWidth / 2 % step) ? "╬" : "═");
                    else
                        Console.Write(" ");
                    //i = i;
                }
            }
        }




        static void draw_the_line(int i, int heightConsole, int discrete, int step, bool flag)
        {
            int root = 0;
            Console.SetCursorPosition(0, i);
            float lineWidth = ((float)1 / (10 * discrete));
            float x = (0 - (float)Console.BufferWidth / 2) / discrete;
            float y = -(i - (float)heightConsole / 2) / discrete;
            float sum = (y) - function(x - (float)1 / discrete); // для oldSumCol
            environment roots = new environment();
            roots.futureSumCol = (y) - function(x);
            roots.futureSumRow = 0;

            //Console.SetCursorPosition(0, i);
            for (int j = 0; j < Console.BufferWidth; j++)
            {
                y = -((float)i - (float)heightConsole / 2) / discrete;
                x = ((float)j - (float)Console.BufferWidth / 2) / discrete;

                roots.oldSumRow = (y + (float)1 / discrete) - function(x);
                roots.oldSumCol = sum; //(y) - function(x - (float)1 / discrete);  
                sum = roots.futureSumCol; // через те що значення відмалювання значень шкали може збільшити інкремент виникає похибка відмалювання, з метою оптимізації цей баг в цьому місці не буде виправлятися! (так задумано! :) )
                roots.futureSumCol = (y) - function(x + (float)1 / discrete);
                roots.futureSumRow = (y - (float)1 / discrete) - function(x);


                roots.left = sum > 0 ^ roots.oldSumCol > 0;
                roots.right = sum > 0 ^ roots.futureSumCol > 0;
                roots.top = sum > 0 ^ roots.oldSumRow > 0;
                roots.down = sum > 0 ^ roots.futureSumRow > 0;

                if (sum >= -lineWidth && sum <= lineWidth)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    if (flag)
                    {
                        Console.SetCursorPosition(25, heightConsole + ++root);
                        Console.WriteLine("root: {0}", ((float)j - Console.BufferWidth / 2) / discrete); //heightConsole / 2 - (int)Math.Round(y * discrete);
                        //((float)i - (float)heightConsole / 2) / discrete
                        // Наче так , якщо не так то мені ...
                        Console.SetCursorPosition(j, i);
                    }
                    Console.Write("*");  // Точно до товщини лінії
                }
                else if ((roots.left || roots.right || roots.top || roots.down) // Перевірка на зміна знаку
                    && (Math.Abs(sum) < Math.Abs(roots.futureSumCol) && Math.Abs(roots.oldSumCol) > Math.Abs(sum) /* && Можливе ігнорування елементів */ || // Інгнорування елементів немає
                        Math.Abs(sum) < Math.Abs(roots.futureSumRow) && Math.Abs(roots.oldSumRow) > Math.Abs(sum))) // Дана точка є найбільш блищою до мінумуму? 
                {
                    //switch (roots) // Да ну так не прикольно! :( 
                    //{              // В С++ проконало б!
                    //    case 0x0000: // Якщо зробити структуру з одних булевих зміних!
                    //}
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (flag)
                    {
                        Console.SetCursorPosition(25, heightConsole + ++root);
                        Console.WriteLine("root: {0}", ((float)j - Console.BufferWidth / 2) / discrete); //heightConsole / 2 - (int)Math.Round(y * discrete);
                        // Наче так , якщо не так то мені ...
                        Console.SetCursorPosition(j, i);
                    }
                    if (roots.left && !roots.right && !roots.top && !roots.down) // По одному і по три
                        Console.Write("[");
                    else if (!roots.left && roots.right && roots.top && roots.down)
                        Console.Write("}");
                    else if (!roots.left && roots.right && !roots.top && !roots.down)
                        Console.Write("]");
                    else if (!roots.left && roots.right && !roots.top && !roots.down)
                        Console.Write("{");
                    else if (!roots.left && !roots.right && roots.top && !roots.down)
                        Console.Write("\"");
                    else if (roots.left && roots.right && !roots.top && roots.down)
                        Console.Write("U");
                    else if (!roots.left && !roots.right && !roots.top && roots.down)
                        Console.Write("_");
                    else if (roots.left && roots.right && roots.top && !roots.down)
                        Console.Write("^");
                    else if (roots.left && roots.right && !roots.top && !roots.down) // По парі
                        Console.Write("─");
                    else if (!roots.left && !roots.right && roots.top && roots.down)
                        Console.Write("|");
                    else if (roots.left && !roots.right && roots.top && !roots.down)
                        Console.Write("┘");
                    else if (!roots.left && roots.right && !roots.top && roots.down)
                        Console.Write("┌");
                    else if (roots.left && !roots.right && !roots.top && roots.down)
                        Console.Write("┐");
                    else if (!roots.left && roots.right && roots.top && !roots.down)
                        Console.Write("└");
                    else if (roots.left && roots.right && roots.top && roots.down) // По чотири
                        Console.Write("┼");
                    else Console.Write(" ");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    if (j == Console.BufferWidth / 2 - 4)
                    {
                        if (i == heightConsole / 2)
                            Console.Write((j % step == Console.BufferWidth / 2 % step) ? "╬" : "═");
                        else if (i % step == heightConsole / 2 % step)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("{0}", (float)(-i + heightConsole / 2) / discrete);
                            j = Console.CursorLeft - 1;
                            //Console.ForegroundColor = ConsoleColor.DarkBlue;
                        }
                        else
                            Console.Write(" ");
                    }
                    else if (j == Console.BufferWidth / 2)
                        Console.Write((i % step == heightConsole / 2 % step) ? "╬" : "║");
                    else if (i == heightConsole / 2 - 1)
                    {
                        if (j % step == Console.BufferWidth / 2 % step)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("{0}", (float)(j - Console.BufferWidth / 2) / discrete);
                            //Console.ForegroundColor = ConsoleColor.DarkBlue;
                            if (Console.CursorTop == heightConsole / 2 - 1)
                                j = Console.CursorLeft - 1;
                            else
                            {
                                Console.SetCursorPosition(j, i);
                                Console.Write(" ");
                            }
                        }
                        else
                            Console.Write(" ");
                    }
                    else if (i == heightConsole / 2)
                        Console.Write((j % step == Console.BufferWidth / 2 % step) ? "╬" : "═");
                    else
                        Console.Write(" ");
                    //i = i;
                }
            }
        }
    }
}
