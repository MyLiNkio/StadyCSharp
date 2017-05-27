using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {

            FishTank tunk = new FishTank(10, 10);

            var fish = new Fish();
            var fish2 = new Fish();
            var fish3 = new Cleaner();

            tunk.AddFish(fish);
            tunk.AddFish(fish2);
            tunk.AddFish(fish3);
        }
    }
}
