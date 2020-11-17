using System;
using System.Collections.Generic;
using System.Threading;

namespace OOP_snake
{
	class Program
	{
        static void Main(string[] args)
        {
            // descendant of the Class Figure
            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p = new Point(4, 5, '*');
            // indicate fSnake as the descendant of the Figure Class
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            // hovewer! now you can't use the methods of the Snake Class since it's just a Figure
            // so it should be aligned to the Snake Class
            Snake snake = (Snake)fSnake;

            // descendant of the Class Figure
            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            // list of Figures
            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }
        }

        static void Draw(Figure figure) // takes the descendants of Figure Class only
        {
            figure.Draw();
        }
    }
}
