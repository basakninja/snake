using System.Collections.Generic;

namespace snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }

    }
}
