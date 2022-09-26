using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaseSnake
{
    internal class Food
    {
        readonly string _foodSymbol = "&";
        public int X { get; }
        public int Y { get; }
        public Food(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Generate()
        {
            Random random = new Random();
            Console.SetCursorPosition(random.Next(1, X), random.Next(1, Y));
            Console.Write(_foodSymbol);
        }
    }
}
