using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aquarium.Tool;
using Aquarium;

namespace Aquarium.Fishes
{
    public class Fish
    {
        protected double velocity;
        protected Coordinates purpuse;
        protected double reaction; // відстань на якій риби бачать один одного....
        protected Projection view;
        protected Coordinates coordinates;
        //protected List<FishType> food; // 

        protected Fish(/*Aquarium size,*/ Projection view)
        {
            this.view = view;
            coordinates.x = 0; // Random.Next(size.GetLength());
            coordinates.y = 0;
            coordinates.z = 0;
            GetPurpuse();
        }

        private void GetPurpuse()
        {
            purpuse.x = 5; // Random.Next(size.GetLength());
            purpuse.y = 5;
            purpuse.z = 5;
        }

        public void Step()
        {
            if (IfPurpuse())
            {
                GetPurpuse();
            }
            // Я вже кидаю як небудь код...
            coordinates.x += velocity;
            coordinates.y += velocity;
            coordinates.z += velocity;

        }

        private bool IfPurpuse()
        {
            return purpuse.x == coordinates.x && purpuse.y == coordinates.y && purpuse.z == coordinates.z;
        }
    }

    public class Projection
    {
        private char front;
        private char rear;
        private char left;
        private char right;
        private char upper;
        private char lower;

        public Projection(char front, char rear, char left, char right, char upper, char lower)
        {
            this.front = front;
            this.rear = rear;
            this.left = left;
            this.right = right;
            this.upper = upper;
            this.lower = lower;
        }

        public char GetFront()
        {
            return front;
        }

        public char GetRear()
        {
            return rear;
        }

        public char GetLeft()
        {
            return left;
        }

        public char GetRight()
        {
            return right;
        }

        public char GetUpper()
        {
            return upper;
        }

        public char GetLower()
        {
            return lower;
        }
    }
    
}
