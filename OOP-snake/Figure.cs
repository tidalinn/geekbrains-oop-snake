using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake
{
    // base class for descendants
    class Figure
    {
        protected List<Point> pList;

        // virtual means the possibility of overriding this method by the Figure's descendant
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var p in pList)
            {
                if(figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach(var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
