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
        protected Coordinates purpuse = new Coordinates();
        public double Reaction { get; protected set; } // відстань на якій риби бачать один одного....
        public Projection View { get; protected set; }
        //private Coordinates coordinates = new Coordinates();
        public Coordinates Coordinates { get; private set; }
           // = new Coordinates();
        //protected List<FishType> food; // 
        Random rand = new Random();
        protected Aquarium aqua;
        Coordinates vector = new Coordinates(); // private
        double module;

        protected Fish(Aquarium aqua)
        {
            this.aqua = aqua;
            //this.view = view;
            Coordinates = new Coordinates();
            Coordinates.X = rand.Next(aqua.Width); // можуть впасти комусь на голову
            Coordinates.Y = rand.Next(aqua.Length);
            Coordinates.Z = rand.Next(aqua.Heigth);
            GetPurpuse();
        }
        ~Fish() // Деструктор
        {
            // Відмалювати кроваве п'ятно на місці смерті
        }

        private void GetPurpuse()
        {
            purpuse.X = rand.Next(aqua.Width);
            purpuse.Y = rand.Next(aqua.Length);
            purpuse.Z = rand.Next(aqua.Heigth);
            
            vector.X = purpuse.X - Coordinates.X;
            vector.Y = purpuse.Y - Coordinates.Y;
            vector.Z = purpuse.Z - Coordinates.Z;

            module = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z);
            vector.X /= module; // одиничний вектор
            vector.Y /= module;
            vector.Z /= module;

            View.TurnFish(vector); // Повернути рибку в напрямку руху

        }

        public void Step()
        {
            if (module > velocity)
            {
                Coordinates.X += vector.X * velocity;
                Coordinates.Y += vector.Y * velocity;
                Coordinates.Z += vector.Z * velocity;
                module -= velocity;
            }
            else
            {
                //Coordinates = purpuse; Проконало б якщо це була структура
                Coordinates.X = purpuse.X;
                Coordinates.Y = purpuse.Y;
                Coordinates.Z = purpuse.Z;
                GetPurpuse(); // рибка допливла до місця призначення
            }
        }

    }

    public class Projection
    {
        public char One { get; private set; }
        public char Two { get; private set; }
        public char Three { get; private set; } // Upper, Lower
        public static char Front { get; private set; }
        public static char Rear { get; private set; }
        public static char Left { get; private set; }
        public static char Right { get; private set; }
        public static char Upper { get; private set; }
        public static char Lower { get; private set; }

        public Projection(char front, char rear, char left, char right, char upper, char lower)
        {
            Projection.Front = front;
            Projection.Rear = rear;
            Projection.Left = left;
            Right = right;
            Upper = upper;
            Lower = lower;
        }

        public void TurnFish(/* Setting view,*/ Coordinates SingleVector)
        {
            Three = Upper;

            if (SingleVector.X > SingleVector.Y) // Рух впродовж акваріуму
            {
                if (SingleVector.X > 0) // Рух вправо
                {
                    One = Right;
                    Two = Rear;
                }
                else // Рух вліво
                {
                    One = Left;
                    Two = Front;
                }
            }
            else // Рух поперек акваріуму
            {
                if (SingleVector.Y > 0) // Рух вперед
                {
                    One = Front;
                    Two = Right;
                }
                else // Рух назад
                {
                    One = Rear;
                    Two = Left;
                }
            }
            One = Front;
            Two = Front;
        }

    }
}
