using System.Collections.Generic;

namespace snake
{
    class HorizontalLine
    {
        List<Point> plist;

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            plist = new List<Point>();

            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x,y,sym);
                plist.Add(p);
            }



        }
        public void Draw()
        {
            foreach (Point i in plist)
            {
                i.Draw();
            }
        }


    }
}
