using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Fishes
{
    class PredatoryFish : Fish
    {
        fishType type = fishType.Predatory;
        public PredatoryFish(int x, int y, int speed) : base(x,y,speed)
        {
            this.sym = "$";
        }
    }
}
