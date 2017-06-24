using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Fishes
{
    public class Predatory : Fish //public Fish // так в С++ наслідувальні класи , інета немає подивитися не можу як в C#
    {
        // тут треба якийсь буст рибі написати
        // щоб вона могля їсти інших риб, наприклад
        //static private Fish food; // 

        public Predatory(Projection view) : base(view)
        {
            velocity = 2;
            reaction = 3;
            //food = new[] { FishType.Peaceful, FishType.Predatory };
        }
    }
}
