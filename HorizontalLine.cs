﻿using System.Collections.Generic;

namespace snake
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
