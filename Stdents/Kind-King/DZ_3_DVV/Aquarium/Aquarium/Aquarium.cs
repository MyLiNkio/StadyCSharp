using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquarium.Fishes;
using System.Threading;

namespace Aquarium
{
    public class Aquarium
    {
        public int Length { get; }
        public int Width { get; }
        public int Heigth { get; }
        public int Water { get; set; }
        private List<Fish> fishes; //  = new List<Fish>()
        private Projection view;

        public Aquarium(int length, int width, int heigth)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;
            Water = heigth;
            //fishes.Add(fish);
            //fish.GetType();
        }

        public void AddFishes(List<Fish> fishes)
        {
            this.fishes = fishes;
        }

        public void Render(int delay)
        {
            fishes[0].Step();
            view = fishes[0].View;
            fishes[1].Step();


            Thread.Sleep(delay);
        }

        public void DrawAquarium()
        {
            Console.SetCursorPosition(0, 0); /// 1
            DrawEdgeHor();
            DrawAquariumSideTop(); /// 1
            Console.SetCursorPosition(Width + 1, Width + 1); /// 1
            DrawEdgeHor();

            DrawAquariumSideFront(); /// 1

            DrawAquariumSideCyma();
            DrawEdgeSloping();
            Console.SetCursorPosition(Width + 1, Heigth + Width + 2);
            DrawEdgeHor();

            //Console.SetCursorPosition(0, 0); /// 1
            //DrawEdgeVer();
            //DrawAquariumSideFront(); /// 1
            //Console.SetCursorPosition(width + 1, width + 1); /// 1
            //DrawEdgeVer();

        }

        private void DrawAquariumSideTop()
        {
            for (int j = 0; j < Width; j++)
            {
                Console.SetCursorPosition(j + 1, j + 1); /// 1
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\\");
                for (int i = 0; i < Length; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    //Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" "); // відмалювати акваріум
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\\");
                
            }
        }

        private void DrawAquariumSideFront()
        {
            for (int j = 0; j < Heigth; j++)
            {
                Console.SetCursorPosition(Width + 1, j + Width + 2); /// 1
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                for (int i = 0; i < Length; i++)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    //Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" "); // відмалювати акваріум
                }
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("|");

            }
        }

        private void DrawAquariumSideCyma()
        {
            for (int j = 0; j < Heigth; j++)
            {
                Console.SetCursorPosition(0, j + 1); /// 1
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                for (int i = 0; i < Width; i++)
                {
                    Console.SetCursorPosition(i + 1, j + i + 2);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    //Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" "); // відмалювати акваріум
                }
                //Console.BackgroundColor = ConsoleColor.DarkBlue;
                //Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine("|");

            }
        }

        private void DrawEdgeSloping()
        {
            Console.SetCursorPosition(0, Heigth + 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i + 1, Heigth + i + 2);
                Console.Write("\\");
            }
        }

        private void DrawEdgeHor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            for (int i = 0; i < Length; i++)
            {
                Console.Write("─");
            }
            Console.WriteLine("*");
        }

        private void DrawEdgeVer()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*");
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("|");
            }
            Console.WriteLine("*");
        }
    }
}
