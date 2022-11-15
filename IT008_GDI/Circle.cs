using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_GDI
{
    public class Circle:Shape
    { 
        public Point p;
        public int radius;
        public Color color;
        public Circle() { }
        public Circle(Point p, int radius, Color color)
        {
            this.p = p;
            this.radius = radius;
            this.color = color;
        }
        public override void Draw(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            SolidBrush pen = new SolidBrush(this.color);
            Rectangle rect = new Rectangle(p.X, p.Y, radius, radius);
            g.FillEllipse(pen, rect);
            //throw new NotImplementedException();
        }
        public override string getStringSave()
        {
            string[] strArr = { "circle", p.X.ToString(), p.Y.ToString(), radius.ToString(), color.ToArgb().ToString() };
            string str = String.Join("/", strArr);
            return str;
            //throw new NotImplementedException();
        }
    }
}
