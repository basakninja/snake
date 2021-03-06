using System;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point()
        {
        }

        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        // p.Move(i, direction);

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += offset;
            }
            else if (direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if (direction == Direction.UP)
            {
                y += offset;
            }
            else if (direction == Direction.DOWN)
            {
                y -= offset;
            }
        }

        public void Clear()
        {
            symb = ' ';
            Draw();
        }
    }
}
