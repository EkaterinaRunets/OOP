using System; // A developer can now type "Console.WriteLine();" rather than "System.Console.WriteLine();".
using System.Collections.Generic; // Contains interfaces and classes that define generic collections; allows to create strongly typed collections.
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassHierarchy // Helps to control the scope of classes and method names in larger programming projects.
{
    public partial class Form1 : Form // Allows to declare class in two separate file in the same project.
    {
        public Form1()
        {
            InitializeComponent(); // Required for Windows Forms designer support.
        }

        private void Form1_MouseDown(object sender, EventArgs e)
        {
            TFigure figure;
            // g is a variable, determining where to draw.
            Graphics g; // Create graphical object.
            g = this.CreateGraphics();
            Point point1 = new Point();
            Point point2 = new Point();
            point1.X = 10;
            point1.Y = 10;
            // Width and height.
            point2.X = 100;
            point2.Y = 200;

            // Color of figures.
            Pen myPen1 = new Pen(Color.BlueViolet);
            Pen myPen2 = new Pen(Color.Indigo);
            Pen myPen3 = new Pen(Color.CadetBlue);
            Pen myPen4 = new Pen(Color.DarkSalmon);

            figure = new TLine();
            figure.Draw(point1, point2, myPen1, g);
            figure = new TRectangle();
            figure.Draw(point1, point2, myPen2, g);
            figure = new TEllipse();
            figure.Draw(point1, point2, myPen3, g);
            figure = new TTriangle();
            figure.Draw(point1, point2, myPen4, g);
        }
    }
}
