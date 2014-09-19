using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassHierarchy
{
    class TLine : TFigure // Inheritance. Line is an inheritor of figure.
    {
        public override void Draw(Point pt1, Point pt2, Pen myPen, Graphics g)
        {
            g.DrawLine(myPen, pt1, pt2);
        }
    }
}
