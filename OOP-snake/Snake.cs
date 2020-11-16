using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            pList = new List<Point>();

            for(int i = 0; i < length; i++)
            {
                // exact copy of te tail's dot
                Point p = new Point(tail);
                // move to direction
                p.Move(i, direction);
                // add new dot to list
                pList.Add(p);
            }
        }
    }
}
