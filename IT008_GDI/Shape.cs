using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT008_GDI
{
    public abstract class Shape
    {
        public abstract void Draw(Panel panel);
        public abstract string getStringSave();
    }
}
