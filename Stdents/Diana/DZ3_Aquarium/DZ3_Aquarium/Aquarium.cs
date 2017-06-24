using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_Aquarium
{
    class Aquarium
    {
        public int weight;
        public int height;

        public Aquarium(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }

        public void Render(List<Fish> fishes)
        {
            Console.Clear();
            foreach (Fish fish in fishes)
            {
                Console.SetCursorPosition(fish.x, fish.y);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(fish.sym);
                fish.move(weight, height);

            }

        }
    }
}
