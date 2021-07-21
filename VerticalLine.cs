using System.Collections.Generic;

namespace snake
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yTop, int yBottom, int x, char symb)
        {
            pList = new List<Point>();

            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }

    }
}
