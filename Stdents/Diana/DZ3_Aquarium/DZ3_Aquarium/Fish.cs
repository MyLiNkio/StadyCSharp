using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_Aquarium
{
    class Fish
    {
        public int speed;
        public string sym;
        Position pos = new Position();

        public Fish(int x, int y, int speed)
        {
            pos.x = x;
            pos.y = y;
            this.speed = speed;
            this.sym = "o";
        }      
        
        public void move(int weight, int height)
        {


            if (pos.x < weight && pos.y < height)
            {
                pos.x += speed;
                pos.y += speed;
            }
            else if (pos.x == weight && pos.y == height)
            {
                weight = 0;
                height = 0;

                if (pos.x > weight && pos.y > height)
                {
                    pos.x -= speed;
                    pos.y -= speed;
                }
            }

        }
    }
}
