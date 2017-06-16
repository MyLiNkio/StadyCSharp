using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DZ3_Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int weight;
            int height;
            int density;
            int numfish;

            Console.Title = "Aquarium";
            Console.WriteLine("Enter weight and height");
            Console.WriteLine();
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine();
            height = int.Parse(Console.ReadLine());
            Console.WriteLine();
            density = (weight * height) / 50;
            Console.WriteLine("Enter number of fishes");
            Console.WriteLine();
            numfish = int.Parse(Console.ReadLine());
            while (numfish > density)
            {
                Console.WriteLine("so many fishes, enter number of fishes again ");
                Console.WriteLine();
                numfish = int.Parse(Console.ReadLine());
            }
            //Console.SetWindowSize(weight, height);
            Console.BackgroundColor = ConsoleColor.Cyan;

            List<Fish> fishes = new List<Fish>();
            Random rnd = new Random();
            Aquarium aquarium = new Aquarium(weight, height);
            for (int i = 0; i < numfish; i++)
            {
                fishes.Add(new Fish( rnd.Next(weight), rnd.Next(height), rnd.Next(1, 3)));
            }

            while (true)
            {
                aquarium.Render(fishes);
                if (counter > 5)
                {
                    foreach (Fish fish in fishes)
                    {
                     //   if (counter % fish.speed == 0)
                            fish.move(rnd.Next(weight), rnd.Next(height));
                    }
                    counter = 0;
                }
                Thread.Sleep(100);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
