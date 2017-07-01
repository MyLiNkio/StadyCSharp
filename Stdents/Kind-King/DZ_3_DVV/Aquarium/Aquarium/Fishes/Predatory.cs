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

        public Predatory(Aquarium aqua) : base(aqua)
        {
            //this.aqua = aqua;
            //View = new Projection('f', 'r', 'l', 'R', 'u', 'L');
            velocity = 0.3;
            Reaction = 5;
            //GetPurpuse();
            //food = new[] { FishType.Peaceful, FishType.Predatory };

            
        }

        protected override void DoIt(List<Fish> fishes)
        {
            foreach (Fish fish in fishes)
            {
                if (fish is Peaceful)
                {
                    double x = fish.Coordinates.X - Coordinates.X;
                    double y = fish.Coordinates.Y - Coordinates.Y;
                    double z = fish.Coordinates.Z - Coordinates.Z;
                    double module = Math.Sqrt(x * x + y * y + z * z);
                    if (module < Reaction)
                    {
                        if (module == 0)
                        {
                            fishes.Remove(fish);
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            purpuse.X = fish.Coordinates.X;
                            purpuse.Y = fish.Coordinates.Y;
                            purpuse.Z = fish.Coordinates.Z;
                            this.module = module;
                        }
                        
                    }
                }
            }
        }
    }
}
