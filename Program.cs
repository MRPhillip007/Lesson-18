namespace BaaseSnake
{
    internal class Program
    {
        const int MAPWIDTH = 50;
        const int MAPHEIGHT = 20;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Snake snake = new Snake(MAPWIDTH /2, MAPHEIGHT /2, 6, new GameField(MAPWIDTH, MAPHEIGHT), new DirectionSelecter());

            while (!snake.IsGameEnded)
            {
                snake.MoveByDirection(ReadMovement(Console.ReadKey()));    
                Thread.Sleep(100);
            }

        }

        static Direction ReadMovement(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    return Direction.Top;

                case ConsoleKey.DownArrow:
                    return Direction.Down;

                case ConsoleKey.LeftArrow:
                    return Direction.Left;

                default:
                    return Direction.Right;
            }
        }
    }
}