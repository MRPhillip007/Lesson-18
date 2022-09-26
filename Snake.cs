using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaseSnake
{
    delegate void MoveTo();
    internal class Snake
    {
        public event MoveTo MoveDirection;
        readonly string _symbol = "*";
        public bool IsGameEnded { get { return GameEnded(); } }
        public GameField GameField { get; }
        public Pixel Head { get; set; }
        public Queue<Pixel> SnakeBody { get; }
        public Direction Direction { get; set; }
        public Snake(int x, int y, int size, GameField gameField, DirectionSelecter direction)
        {
            GameField = gameField;
            Head = new Pixel(x, y);
            SnakeBody = new Queue<Pixel>();
            MoveByDirection(Direction);
            direction.ChangeDirection += MoveByDirection;
            for (int i = size; i >= 0 ; i--)
            {
                SnakeBody.Enqueue(new Pixel(Head.X - i - 1, y));
            }

            gameField.Draw();
            DrawSnake();
        }

        void DrawSnake()
        {
            Head.Draw(_symbol);

            foreach (Pixel item in SnakeBody)
            {
                item.Draw(_symbol);
            }
        }

        void Clear()
        {
            Head.Draw(_symbol);

            foreach (var item in SnakeBody)
            {
                item.Clear();
            }
        }
        bool GameEnded()
        {
            if (Head.X >= GameField.X - 1 || Head.X <= 1 || Head.Y >= GameField.Y || Head.Y <= 1)
            {
                Console.WriteLine("Game over");
                return true;
            }
            return false;
        }
        public void MoveByDirection(Direction direction)
        {
            Clear();

            SnakeBody.Enqueue(new Pixel(Head.X, Head.Y));
            SnakeBody.Dequeue();

            switch (direction)
            {
                case Direction.Right:
                    Head = new Pixel(Head.X + 1, Head.Y);
                    break;

                case Direction.Left:
                    Head = new Pixel(Head.X - 1, Head.Y);
                    break;

                case Direction.Top:
                    Head = new Pixel(Head.X, Head.Y - 1);
                    break;

                case Direction.Down:
                    Head = new Pixel(Head.X, Head.Y + 1);
                    break;
            }
            DrawSnake();
        }
    }
}
