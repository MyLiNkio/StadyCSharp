using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Fishes
{
    class Fish
    {
        public int x, y; // текущие координаты
        int final_x, final_y; // координаты назначения передвижения
        int speed; // скорость рыбки (point per step)
        public string sym;
        fishType type;
        public Fish(int x, int y, int speed)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            this.sym = "@";
            this.type = fishType.Peaceful;
        }

        public void move()
        {
            if (this.x < final_x)
                this.x += speed;
            else if (this.x > final_x)
                this.x -= speed;
            if (this.y < final_y)
                this.y += speed;
            else if (this.y > final_y)
                this.y -= speed;
            // проверки на допустимое передвижение
        }

        public void changeSpeed(int speed)
        {
            this.speed = speed; 
        }

        public void changeFinalyPossition(int x, int y)
        {
            this.final_x = x;
            this.final_y = y;
        }
        

    }

    public enum fishType{
        Predatory, // хищные
        Peaceful,  // мирные
    }
}
