using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace IT008_GDI
{
    public class Square: Shape
    {
        public Point p1, p2, p3, p4;
        public int length;
        public Color color;
        public Square(Point p, int length, Color color)
        {
            this.p1 = p;
            this.p2 = new Point(p.X + length, p.Y);
            this.p3 = new Point(p.X, p.Y + length);
            this.p4 = new Point(p.X + length, p.Y + length);
            this.length = length;
            this.color = color;
        }
        public Square()
        {

        }
        public override void Draw(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            SolidBrush pen = new SolidBrush(this.color);
            Rectangle rect = new Rectangle(p1.X, p1.Y, length, length);
            g.FillRectangle(pen,rect);
            //throw new NotImplementedException();
        }
        public override string getStringSave()
        {
            string[] strArr = { "square", p1.X.ToString(), p1.Y.ToString(), length.ToString(), color.ToArgb().ToString() };
            string str = String.Join("/", strArr);
            return str;
            //throw new NotImplementedException();
        }
    }
}
