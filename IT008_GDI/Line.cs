using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_GDI
{
    public class Line:Shape
    {
        public Point p1, p2;
        public int width;
        public Color color;
        public Line() { }
        public Line(Point p1, Point p2, int width, Color color)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.width = width;
            this.color = color;
        }

        public override void Draw(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            Pen pen = new Pen(color, width);
            g.DrawLine(pen, p1, p2);
            g.Dispose();
            //throw new NotImplementedException();
        }
        public override string getStringSave()
        {
            string[] strArr = { "line", p1.X.ToString(), p1.Y.ToString(), p2.X.ToString(), p2.Y.ToString(), width.ToString(), color.ToArgb().ToString() };
            string str = String.Join("/", strArr);
            return str;
            //throw new NotImplementedException();
        }
    }
}
