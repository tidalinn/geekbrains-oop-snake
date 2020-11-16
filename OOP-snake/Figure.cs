using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_snake
{
    // base class for descendants
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
