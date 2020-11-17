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
        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
