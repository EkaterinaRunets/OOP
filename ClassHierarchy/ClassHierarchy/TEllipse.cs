using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassHierarchy
{
    class TEllipse : TFigure // Inheritance. Ellipse is an inheritor of figure.
    {
        public override void Draw(Point pt1, Point pt2, Pen myPen, Graphics g)
        {
            g.DrawEllipse(myPen, pt1.X + 100, pt1.Y + 100, pt2.X - pt1.X + 100, pt2.Y - pt1.Y + 100);
        }
    }
}
