using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Fishes
{
    class PeacefulFish : Fish
    {
        fishType type = fishType.Peaceful;
        public PeacefulFish(int x, int y, int speed) : base(x,y,speed)
        {
            this.sym = "@";
        }
    }   
}
