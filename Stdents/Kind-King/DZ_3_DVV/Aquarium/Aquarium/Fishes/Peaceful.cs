using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Fishes
{
    class Peaceful : Fish
    {
        public Peaceful(Aquarium aqua) : base(aqua)
        {
            //this.aqua = aqua;
            //View = new Projection('f', 'r', 'l', 'R', 'u', 'L');
            velocity = 0.15;
            Reaction = 5;
            //food = null;
        }

        protected override void DoIt(List<Fish> fishes)
        {
            foreach (Fish fish in fishes)
            {
                if (fish is Predatory)
                {
                    double x = fish.Coordinates.X - Coordinates.X;
                    double y = fish.Coordinates.Y - Coordinates.Y;
                    double z = fish.Coordinates.Z - Coordinates.Z;
                    if (Math.Sqrt(x * x + y * y + z * z) < Reaction)
                    {
                        //purpuse.X = fish.Coordinates.X - 2 * x;
                        //purpuse.Y = fish.Coordinates.Y - 2 * y;
                        //purpuse.Z = fish.Coordinates.Z - z;
                    }
                }
            }
        }
    }
}
