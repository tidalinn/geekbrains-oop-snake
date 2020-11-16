﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP_snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
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
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            // current position of snake's head
            Point head = pList.Last();
            // copy of the preceding position of head
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
