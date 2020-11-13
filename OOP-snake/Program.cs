using System;

namespace OOP_snake
{
	class Program
	{
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            int x = 1;
            Func1(x);
            Console.WriteLine($"\n\nFunc1 x={x}");

            Func2(x);
            Console.WriteLine($"Func2 x={x}");

            Func3(x);
            Console.WriteLine($"Func3 x={x}");

            Move(p1, 10, 10);
            Console.WriteLine($"Move(p1, 10, 10) p1.x = {p1.x}, p1.y = {p1.y}");

            Reset(p2);
            Console.WriteLine($"Reset(p2) p2.x = {p2.x}, p2.y = {p2.y}, p2.sym = {p2.sym}");

            p1 = p2;
            p1.Draw();
            p2.Draw();

            Console.ReadKey();
        }

        private static void Func1(int x)
        {

        }

        private static void Func2(int value)
        {
            value = value + 1;
        }

        private static void Func3(int x)
        {
            x += 1;
        }

        private static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        private static void Reset(Point p)
        {
            p = p;
            //  Здесь переменная p2 останется без изменений
        }
    }
}
