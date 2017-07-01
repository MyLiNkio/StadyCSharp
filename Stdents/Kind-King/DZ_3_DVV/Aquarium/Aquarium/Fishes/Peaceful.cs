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
            View = new Projection('f', 'r', 'l', 'R', 'u', 'L');
            velocity = 1.5;
            Reaction = 5;
            //food = null;

        }
    }
}
