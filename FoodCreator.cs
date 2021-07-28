using System;


namespace snake
{
    internal class FoodCreator
    {
        int mapWith;
        int mapHight;
        char symb;

        Random random = new Random();

        public FoodCreator(int mapWith, int mapHight, char symb)
        {
            this.mapWith = mapWith;
            this.mapHight = mapHight;
            this.symb = symb;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWith - 2);
            int y = random.Next(2, mapHight - 2);
            return new Point(x, y, symb);
        }

    }


}