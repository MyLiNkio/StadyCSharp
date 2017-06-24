using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquarium.Fishes;

namespace Aquarium
{
    public class Aquarium
    {
        private int length;
        private int width;
        private int heigth;
        private int water;
        private List<Fish> fishes = new List<Fish>();

        public Aquarium(int length, int width, int heigth, Fish fish)
        {
            this.length = length;
            this.width = width;
            this.heigth = heigth;
            water = heigth;
            fishes.Add(fish);
        }

        public void Render()
        {
            fishes[0].
        }

        public void DrawAquarium()
        {
            Console.SetCursorPosition(0, 0); /// 1
            DrawEdgeHor();
            DrawAquariumSideTop(); /// 1
            Console.SetCursorPosition(width + 1, width + 1); /// 1
            DrawEdgeHor();

            DrawAquariumSideFront(); /// 1

            DrawAquariumSideCyma();
            DrawEdgeSloping();
            Console.SetCursorPosition(width + 1, heigth + width + 2);
            DrawEdgeHor();

            //Console.SetCursorPosition(0, 0); /// 1
            //DrawEdgeVer();
            //DrawAquariumSideFront(); /// 1
            //Console.SetCursorPosition(width + 1, width + 1); /// 1
            //DrawEdgeVer();

        }

        private void DrawAquariumSideTop()
        {
            for (int j = 0; j < width; j++)
            {
                Console.SetCursorPosition(j + 1, j + 1); /// 1
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\\");
                for (int i = 0; i < length; i++)
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
            for (int j = 0; j < heigth; j++)
            {
                Console.SetCursorPosition(width + 1, j + width + 2); /// 1
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                for (int i = 0; i < length; i++)
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
            for (int j = 0; j < heigth; j++)
            {
                Console.SetCursorPosition(0, j + 1); /// 1
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                for (int i = 0; i < width; i++)
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
            Console.SetCursorPosition(0, heigth + 1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i + 1, heigth + i + 2);
                Console.Write("\\");
            }
        }

        private void DrawEdgeHor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            for (int i = 0; i < length; i++)
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
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("|");
            }
            Console.WriteLine("*");
        }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeigth()
        {
            return heigth;
        }

        public int GetWater()
        {
            return water;
        }
    }
}
