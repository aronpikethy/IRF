using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Factory.Abstractions;

namespace Factory.Entities
{
    public class Ball : Toy
    {
        public SolidBrush BallColor { get; private set; }
        public Ball(Color color)
        {
            this.BallColor = new SolidBrush(color);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, this.Width, this.Height);
        }
    }
}
