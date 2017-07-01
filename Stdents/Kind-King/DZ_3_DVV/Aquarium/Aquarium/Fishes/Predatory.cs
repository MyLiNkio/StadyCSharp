﻿using System;
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

        public Predatory(Aquarium aqua) : base(aqua)
        {
            //this.aqua = aqua;
            View = new Projection('f', 'r', 'l', 'R', 'u', 'L');
            velocity = 2;
            Reaction = 3;
            //food = new[] { FishType.Peaceful, FishType.Predatory };
        }
    }
}
