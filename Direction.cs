using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaaseSnake
{
    public delegate void ChangeTo(Direction direction);
    public class DirectionSelecter
    {
        public event ChangeTo ChangeDirection;

        public void Set(Direction direction)
        {
            ChangeDirection.Invoke(direction);
        }
    }
    
    public enum Direction : byte
    {
        Right,
        Left,
        Top,
        Down
    }
}