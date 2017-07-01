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
        public int Length { get; }
        public int Width { get; }
        public int Heigth { get; }
        public int Water { get; set; }
        private List<Fish> fishes; //  = new List<Fish>()
        //private Projection view;

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

        public void Sort()
        {
            for (var i = 0; i < fishes.Count - 1; i++)
            {
                var fish = fishes[i];
                if (fish.CompareTo(fishes[i + 1]) > 0)
                {
                    fishes.Remove(fish);
                    fishes.Insert(i + 1, fish);
                }
            }
        }

        public int CompareX(Fish f1, Fish f2)
        {
            if (f1.Coordinates.X < f2.Coordinates.X)
                return -1;
            if (f1.Coordinates.X == f2.Coordinates.X)
                return 0;
            return 1;
        }

        public int CompareY(Fish f1, Fish f2)
        {
            if (f1.Coordinates.Y < f2.Coordinates.Y)
                return -1;
            if (f1.Coordinates.Y == f2.Coordinates.Y)
                return 0;
            return 1;
        }

        public int CompareZ(Fish f1, Fish f2)
        {
            if (f1.Coordinates.Z < f2.Coordinates.Z)
                return -1;
            if (f1.Coordinates.Z == f2.Coordinates.Z)
                return 0;
            return 1;
        }

        public void Render()
        {
            fishes.Sort(new Comparison<Fish>(CompareX));
            fishes.Sort(new Comparison<Fish>(CompareY));
            fishes.Sort(new Comparison<Fish>(CompareZ));

            foreach (var fish in fishes) {

                Console.SetCursorPosition((int)Math.Round(fish.Coordinates.Y) + (int)Math.Round(fish.Coordinates.X) + 2, (int)Math.Round(fish.Coordinates.X) + 1);
                Console.Write(' ');

                Console.SetCursorPosition(Width + (int)Math.Round(fish.Coordinates.Y) + 2, (int)Math.Round(fish.Coordinates.Z) + Width + 2);
                Console.Write(' ');

                Console.SetCursorPosition((int)Math.Round(fish.Coordinates.X) + 1, (int)Math.Round(fish.Coordinates.Z) + (int)Math.Round(fish.Coordinates.X) + 2);
                Console.Write(' ');
                fish.Step(fishes);
                //Console.SetCursorPosition((int)Math.Round(fish.Coordinates.Y) + (int)Math.Round(fish.Coordinates.X) + 2, (int)Math.Round(fish.Coordinates.X) + 1);
                //Console.Write(fish.View.Three);

                //Console.SetCursorPosition(Width + (int)Math.Round(fish.Coordinates.Y) + 2, (int)Math.Round(fish.Coordinates.Z) + Width + 2);
                //Console.Write(fish.View.Two);

                //Console.SetCursorPosition((int)Math.Round(fish.Coordinates.X) + 1, (int)Math.Round(fish.Coordinates.Z) + (int)Math.Round(fish.Coordinates.X) + 2);
                //Console.Write(fish.View.One);
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            fishes.Sort(new Comparison<Fish>(CompareX));
            foreach (var fish in fishes)
            {
                TypeFish(fish);
                Console.SetCursorPosition((int)Math.Round(fish.Coordinates.Y) + (int)Math.Round(fish.Coordinates.X) + 2, (int)Math.Round(fish.Coordinates.X) + 1);
                Console.Write(fish.View.Three);
            }
            fishes.Sort(new Comparison<Fish>(CompareY));
            foreach (var fish in fishes)
            {
                TypeFish(fish);
                Console.SetCursorPosition(Width + (int)Math.Round(fish.Coordinates.Y) + 2, (int)Math.Round(fish.Coordinates.Z) + Width + 2);
                Console.Write(fish.View.Two);
            }
            fishes.Sort(new Comparison<Fish>(CompareZ));
            foreach (var fish in fishes)
            {
                TypeFish(fish);
                Console.SetCursorPosition((int)Math.Round(fish.Coordinates.X) + 1, (int)Math.Round(fish.Coordinates.Z) + (int)Math.Round(fish.Coordinates.X) + 2);
                Console.Write(fish.View.One);
            }
        }

        private void TypeFish(Fish fish)
        {
            if (fish is Peaceful)
                Console.ForegroundColor = ConsoleColor.White;
            else
                Console.ForegroundColor = ConsoleColor.Red;
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
