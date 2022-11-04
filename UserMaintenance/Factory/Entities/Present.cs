using Factory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities
{
    public class Present : Toy
    {
        public SolidBrush RibbonColor { get; set; }
        public SolidBrush BoxColor { get; set; }
        public Present(Color ribbon, Color box)
        {
            this.RibbonColor = new SolidBrush(ribbon);
            this.BoxColor = new SolidBrush(box);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, this.Width, this.Height);
            int size = this.Width / 5;
            g.FillRectangle(RibbonColor, this.Width / 2 - size / 2, 0, size, this.Height);
            g.FillRectangle(RibbonColor, 0, this.Height / 2 - size / 2, this.Width, size);
        }
    }
}
