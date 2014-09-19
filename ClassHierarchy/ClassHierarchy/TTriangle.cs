using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassHierarchy
{
    class TTriangle : TFigure // Inheritance. Triangle is an inheritor of figure.
    {
        // Provides a new implementation of a member that is inherited from a base class.
        public override void Draw(Point pt1, Point pt2, Pen myPen, Graphics g)
        {
            g.DrawLine(myPen, pt1.X + 250, pt2.Y + 250, pt1.X + (pt2.X - pt1.X) / 2 + 250, pt1.Y + 250);
            g.DrawLine(myPen, pt1.X + (pt2.X - pt1.X) / 2 + 250, pt1.Y + 250, pt2.X + 250, pt2.Y + 250);
            g.DrawLine(myPen, pt2.X + 250, pt2.Y + 250, pt1.X + 250, pt2.Y + 250);
        }
    }
}
