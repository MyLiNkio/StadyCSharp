using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquarium.Fishes;
using System.Threading;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Початок 09.06.17 23:51
            // Завдання згадую по памяті, адже інтернету немає...
            int length = 10;
            int width = 10;
            int heigth = 15;
            List<Fish> fishes = new List<Fish>();

            Aquarium aquarium = new Aquarium(length, width, heigth);

            for (int i = 0; i < 1; i++)
            {
                fishes.Add(new Predatory(aquarium));
            }
            for (int i = 0; i < 1; i++)
            {
                fishes.Add(new Peaceful(aquarium));
            }

            aquarium.AddFishes(fishes);
            aquarium.DrawAquarium();
            
            while (true)
            {
                aquarium.Render();
                Thread.Sleep(10);
            }


            Console.ReadLine();
        }
    }
}
