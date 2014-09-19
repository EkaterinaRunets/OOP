using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassHierarchy
{
    abstract class TFigure
    {
        public abstract void Draw(Point pt1, Point pt2, Pen myPen, Graphics g);
    }
}
