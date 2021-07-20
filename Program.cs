using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(5, 5, '&');
            p1.Draw();

            Point p2 = new Point(4,4,'!');
            p2.Draw();


            Console.ReadLine();
        }


    }
}
