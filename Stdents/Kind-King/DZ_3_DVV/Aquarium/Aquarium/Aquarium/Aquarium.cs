using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Aquarium
{
    public class Aquarium
    {
        private int length;
        private int width;
        private int heigth;
        private int water;

        public Aquarium(int length, int width, int heigth)
        {
            this.length = length;
            this.width = width;
            this.heigth = heigth;
            water = heigth;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeigth()
        {
            return heigth;
        }

        public int GetWater()
        {
            return water;
        }
    }
}
