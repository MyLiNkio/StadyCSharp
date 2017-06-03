using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    // описание воды, оборудования ... 
    class Aquarium
    {
        int width, height;
        int[,] area;
        public Aquarium(int width, int height)
        {
            this.width = width;
            this.height = height;
            area = new int[width, height];
        }

        public void ClearArea()
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    area[i, j] = 0;
                }
            }
        }

        public void Render(List<Fishes.Fish> fishes)
        {
            Console.Clear();
            ClearArea();
            foreach (Fishes.Fish fish in fishes)
            {
                area[fish.x, fish.y] = 1;
                Console.SetCursorPosition(fish.x, fish.y);
                Console.Write(fish.sym);
                fish.move();
            }
            
            /*
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (area[i, j] == 0)
                        Console.Write(" ");
                    if (area[i, j] == 1)
                        Console.Write("@");
                }
                Console.Write("\n");
            }*/
            
            
        }


    }

}
