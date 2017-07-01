using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquarium.Fishes;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Початок 09.06.17 23:51
            // Завдання згадую по памяті, адже інтернету немає...
            int length = 50;
            int width = 10;
            int heigth = 20;
            List<Fish> fishes = new List<Fish>();

            Aquarium aquarium = new Aquarium(length, width, heigth);

            fishes.Add(new Predatory(aquarium));
            fishes.Add(new Peaceful(aquarium));

            aquarium.AddFishes(fishes);

            aquarium.DrawAquarium();
            Console.ReadLine();
        }
    }
}
