using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IT008_GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            File.WriteAllText("data.txt", String.Empty);
        }

        private void buttonColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                buttonColorDialog.BackColor = colorDlg.Color;   
            }
        }

      

        private void btSquare_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int angle = rd.Next(1, 5);
            int length = rd.Next(10, 200);
            int a = panel2.Size.Width-length;
            int b = panel2.Size.Height-length;
            int c = panel2.Size.Width / 2-length;
            int d = panel2.Size.Height / 2-length;
            Point p;
            if (angle == 1)
            {
                p = new Point(rd.Next(0, a), rd.Next(0, d));
            }
            else if (angle == 2)
            {
                p = new Point(rd.Next(c,a),rd.Next(0,d));
            }
            else if (angle == 3)
            {
                p = new Point(rd.Next(0, a), rd.Next(d, b));
            }
            else
            {
                p = new Point(rd.Next(c, a), rd.Next(d, b));
            }
            Color color = buttonColorDialog.BackColor;
            Square s = new Square(p, length, color);
            s.Draw(panel2);
            string[] stringPointMerge = File.ReadAllLines("data.txt");
            string[] str = new string[stringPointMerge.Length + 1];
            for (int i = 0; i < stringPointMerge.Length; i++)
            {
                str[i] = stringPointMerge[i];
            }
            str[str.Length - 1] = s.getStringSave();
            File.WriteAllLines("data.txt", str);
        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int angle = rd.Next(1, 5);
            int radius = rd.Next(10, 200);
            int a = panel2.Size.Width - radius;
            int b = panel2.Size.Height - radius;
            int c = panel2.Size.Width / 2 - radius;
            int d = panel2.Size.Height / 2 - radius;
            Point p;
            if (angle == 1)
            {
                p = new Point(rd.Next(0, a), rd.Next(0, d));
            }
            else if (angle == 2)
            {
                p = new Point(rd.Next(c, a), rd.Next(0, d));
            }
            else if (angle == 3)
            {
                p = new Point(rd.Next(0, a), rd.Next(d, b));
            }
            else
            {
                p = new Point(rd.Next(c, a), rd.Next(d, b));
            }
            Color color = buttonColorDialog.BackColor;
            Circle ci = new Circle(p, radius, color);
            ci.Draw(panel2);
            string[] stringPointMerge = File.ReadAllLines("data.txt");
            string[] str = new string[stringPointMerge.Length + 1];
            for (int i = 0; i < stringPointMerge.Length; i++)
            {
                str[i] = stringPointMerge[i];
            }
            str[str.Length - 1] = ci.getStringSave();
            File.WriteAllLines("data.txt", str);
        }

        private void btLine_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int angle = rd.Next(1, 5);
            int width = rd.Next(10, 20);
            int a = panel2.Size.Width - width;
            int b = panel2.Size.Height - width;
            int c = panel2.Size.Width / 2 - width;
            int d = panel2.Size.Height / 2 - width;
            Point p1, p2;
            if (angle == 1)
            {
                p1 = new Point(rd.Next(0, a), rd.Next(0, d));
            }
            else if (angle == 2)
            {
                p1 = new Point(rd.Next(c, a), rd.Next(0, d));
            }
            else if (angle == 3)
            {
                p1 = new Point(rd.Next(0, a), rd.Next(d, b));
            }
            else
            {
                p1 = new Point(rd.Next(c, a), rd.Next(d, b));
            }
            angle = rd.Next(1, 5);
            if (angle == 1)
            {
                p2 = new Point(rd.Next(0, a), rd.Next(0, d));
            }
            else if (angle == 2)
            {
                p2 = new Point(rd.Next(c, a), rd.Next(0, d));
            }
            else if (angle == 3)
            {
                p2 = new Point(rd.Next(0, a), rd.Next(d, b));
            }
            else
            {
                p2 = new Point(rd.Next(c, a), rd.Next(d, b));
            }
            Color color = buttonColorDialog.BackColor;
            Line l = new Line(p1, p2, width, color);
            l.Draw(panel2);
            string[] stringPointMerge = File.ReadAllLines("data.txt");
            string[] str = new string[stringPointMerge.Length + 1];
            for (int i = 0; i < stringPointMerge.Length; i++)
            {
                str[i] = stringPointMerge[i];
            }
            str[str.Length - 1] = l.getStringSave();
            File.WriteAllLines("data.txt", str);
        }
        private void btTriangle_Click(object sender, EventArgs e)
        {
            //load data
            Random rd = new Random();
            int angle = rd.Next(1, 5);
            int a = panel2.Size.Width;
            int b = panel2.Size.Height;
            int c = panel2.Size.Width / 2;
            int d = panel2.Size.Height / 2;
            Point p1, p2, p3;
            if (angle == 1)
            {
                p1 = new Point(rd.Next(0, c), rd.Next(0, b));
                p2 = new Point(rd.Next(0, c), rd.Next(0, b));
                p3 = new Point(rd.Next(0, c), rd.Next(0, b));
            }
            else if (angle == 2)
            {
                p1 = new Point(rd.Next(c,a), rd.Next(0,c));
                p2 = new Point(rd.Next(c,a), rd.Next(0,c));
                p3 = new Point(rd.Next(c,a), rd.Next(0,c));
            }
            else if(angle == 3)
            {
                p1 = new Point(rd.Next(0, c), rd.Next(d, b));
                p2 = new Point(rd.Next(0, c), rd.Next(d, b));
                p3 = new Point(rd.Next(0, c), rd.Next(d, b));
            }
            else
            {
                p1 = new Point(rd.Next(c,a), rd.Next(d, b));
                p2 = new Point(rd.Next(c,a), rd.Next(d, b));
                p3 = new Point(rd.Next(c,a), rd.Next(d, b));
            }
            Triangle t = new Triangle(p1, p2, p3, buttonColorDialog.BackColor);
            t.Draw(panel2);
            string[] stringPointMerge = File.ReadAllLines("data.txt");
            string[] str = new string[stringPointMerge.Length + 1];
            for(int i = 0; i < stringPointMerge.Length; i++)
            {
                str[i] = stringPointMerge[i];
            }
            str[str.Length - 1] = t.getStringSave();
            File.WriteAllLines("data.txt", str);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //---LOAD DATA từ file---//
            //mỗi dòng lưu 1 tam giác gồm 3 đỉnh như sau: p1.x/p1.y/p2.x/p2.y/p3.x/p3.y
            //mỗi stringPointMerge có dạng: p1.x/p1.y/p2.x/p2.y/p3.x/p3.y
            string[] stringPointMerge = File.ReadAllLines("data.txt");
            List<Point> listPoint = new List<Point>();
            for (int i = 0; i < stringPointMerge.Length; i++)
            {
                string[] stringPointSplit = stringPointMerge[i].Split('/');
                if (stringPointSplit[0] == "triangle")
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Point p = new Point();
                        p.X = int.Parse(stringPointSplit[1 + j * 2]);
                        p.Y = int.Parse(stringPointSplit[2 + j * 2]);
                        listPoint.Add(p);
                    }
                    if (listPoint.Count == 3)
                    {
                        Color color = new Color();
                        color = Color.FromArgb(int.Parse(stringPointSplit[7]));
                        Triangle t = new Triangle(listPoint[0], listPoint[1], listPoint[2], color);
                        t.Draw(panel2);
                        listPoint.Clear();
                    }
                }
                else if (stringPointSplit[0] == "square")
                {
                    //code square
                    Color color = Color.FromArgb(int.Parse(stringPointSplit[4]));
                    Point p = new Point(int.Parse(stringPointSplit[1]), int.Parse(stringPointSplit[2]));
                    int length = int.Parse(stringPointSplit[3]);
                    Square s = new Square(p, length, color);
                    s.Draw(panel2);
                }
                else if (stringPointSplit[0] == "circle")
                {
                    //code circle
                    Color color = Color.FromArgb(int.Parse(stringPointSplit[4]));
                    Point p = new Point(int.Parse(stringPointSplit[1]), int.Parse(stringPointSplit[2]));
                    int radius = int.Parse(stringPointSplit[3]);
                    Circle c = new Circle(p, radius, color);
                    c.Draw(panel2);
                }
                else
                {
                    //code line
                    Color color = Color.FromArgb(int.Parse(stringPointSplit[6]));
                    Point p1 = new Point(int.Parse(stringPointSplit[1]), int.Parse(stringPointSplit[2]));
                    Point p2 = new Point(int.Parse(stringPointSplit[3]), int.Parse(stringPointSplit[4]));
                    int width = int.Parse(stringPointSplit[5]);
                    Line l = new Line(p1, p2, width, color);
                    l.Draw(panel2);
                }
            }
        }
    }
}
