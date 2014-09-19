using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassHierarchy
{
    class TRectangle : TFigure // Inheritance. Rectangle is an inheritor of figure.
    {
        public override void Draw(Point pt1, Point pt2, Pen myPen, Graphics g)
        {
            g.DrawRectangle(myPen, pt1.X + 50, pt1.Y + 50, pt2.X - pt1.X + 50, pt2.Y - pt1.Y + 50);

        }
    }
}
