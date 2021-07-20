using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {

                HorizontalLine line = new HorizontalLine(0, 100, i, '$');
                line.Draw();

            }



            Console.ReadLine();
        }


    }
}
