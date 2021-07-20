using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1 = 5;
            int y1 = 5;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            x1 = 10;
            y1 = 15;
            sym1 = '*';

            Draw(x1, y1, sym1);

            x1 = 50;
            y1 = 50;
            sym1 = '*';

            Draw(x1, y1, sym1);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
