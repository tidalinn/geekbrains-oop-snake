using System;
using System.Collections.Generic;

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

            HorizontalLine xLine = new HorizontalLine(5, 10, 8, '+');
            xLine.Draw();

            VerticalLine yLine = new VerticalLine(2, 10, 20, '+');
            yLine.Draw();

            Console.ReadLine();
        }
    }
}
