using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Fish
    {
        private char sign;
        public Position position;
        //воспроизведение знака
        public char GetSign()
        {
            return sign;
        }
        //изменение знака
        public void SetSign(char s)
        {
            sign = s;
        }
        //движение
        public virtual void Move(int x, int y)
        {
            Position position = new Position(x, y);
        }
    }
}
