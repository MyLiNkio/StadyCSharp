using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Aquarium.Fishes;


namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<Fish> fishes = new List<Fish>();
            Random random = new Random();
            Aquarium aquarium = new Aquarium(100,30);
            for (int i = 0; i < 10; i++)
            {
                fishes.Add(new PeacefulFish(random.Next(99), random.Next(29), 1));
            }
            for (int i = 0; i < 10; i++)
            {
                fishes.Add(new PredatoryFish(random.Next(99), random.Next(29), 1));
            }

            while (true) { 
                aquarium.Render(fishes);
                if (counter > 5)
                {
                    foreach (Fish fish in fishes)
                    {
                        fish.changeFinalyPossition(random.Next(99), random.Next(29));
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

