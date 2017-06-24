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

            Predatory a = new Predatory(new Projection('f', 'r', 'l', 'R', 'u','L'));
            Peaceful b = new Peaceful(new Projection('f', 'r', 'l', 'R', 'u', 'L'));



            Aquarium aquarium = new Aquarium(length, width, heigth);
            aquarium.DrawAquarium();
            Console.ReadLine();
        }
    }
}
