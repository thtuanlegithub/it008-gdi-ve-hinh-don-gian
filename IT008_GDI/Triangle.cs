using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_GDI
{
    public class Triangle : Shape
    {
        Point p1, p2, p3;
        Color color = new Color();
        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public Triangle()
        {

        }
        public Triangle(Point p1, Point p2, Point p3, Color color) : this(p1, p2, p3)
        {
            this.color = color;
        }

        public override void Draw(Panel panel)
        {
            Graphics g = panel.CreateGraphics();
            SolidBrush pen = new SolidBrush(this.color);
            Point[] ptsArray = { p1, p2, p3 };
            g.FillPolygon(pen, ptsArray);
        }
        public override string getStringSave()
        {
            string[] strArr = {"triangle",p1.X.ToString(), p1.Y.ToString(), p2.X.ToString(), p2.Y.ToString(), p3.X.ToString(), p3.Y.ToString(), color.ToArgb().ToString() };
            string str = String.Join("/",strArr);
            return str;
        }
    }
}
