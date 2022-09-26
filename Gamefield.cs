using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaseSnake
{
    class GameField
    {
        const string BORDERSYMBOL = "#";
        public int X { get; }
        public int Y { get; }
        public GameField(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < X; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine(BORDERSYMBOL);

                Console.SetCursorPosition(i, Y);
                Console.WriteLine(BORDERSYMBOL);
            }
            for (int i = 0; i < Y; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(BORDERSYMBOL);

                Console.SetCursorPosition(X, i);
                Console.WriteLine(BORDERSYMBOL);
            }
        }
    }

}
