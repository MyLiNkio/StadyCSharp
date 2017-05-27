using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class FishTank
    {
        public int width;
        public int height;
        public Fish[] fishes;

        public FishTank(int a, int b)
        {
            width = a;
            height = b;
        }

        public void AddFish(Fish fish)
        {
            if (fish == null) return;

            if (fishes == null)
            {
                fishes = new Fish[1];
                fishes[0] = fish;
            }
            else
            {
                Fish[] newFishes = new Fish[fishes.Length + 1];
                for (var i = 0; i < fishes.Length; i++)
                {
                    newFishes[i] = fishes[i];
                }
                newFishes[fishes.Length] = fish;
                fishes = newFishes;
            }
        }      
     }
}


