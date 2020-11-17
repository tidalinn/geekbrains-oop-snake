using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        // override the parent's method
        public override void Draw()
        {
            base.Draw();
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                // call the base Class realization of the method Draw
                base.Draw();

                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
