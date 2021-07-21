using System;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);


            char symb = '*';



            HorizontalLine horLine1 = new HorizontalLine(0, 78, 0, symb);
            HorizontalLine horLine2 = new HorizontalLine(0, 78, 24, symb);
            VerticalLine verLine1 = new VerticalLine(0, 24, 0, symb);
            VerticalLine verLine2 = new VerticalLine(0, 24, 78, symb);

            horLine1.Draw();
            horLine2.Draw();

            verLine1.Draw();
            verLine2.Draw();

            Point p = new Point(4, 5, symb);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }


    }
}
