using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Fish.Species
{
    class Peaceful : Fish
    {
        public Peaceful(Projection view) : base(view)
        {
            velocity = 1.5;
            reaction = 5;
            type = FishType.Peaceful;
            food = null;
        }
    }
}
