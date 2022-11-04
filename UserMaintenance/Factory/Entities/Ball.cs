using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Factory.Entities
{
    public class Ball : Label
    {
        public Ball()
        {
            this.AutoSize = false;
            this.Width = 50;
            this.Height = 50;

            this.Paint += Ball_Paint;
        }

        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, this.Width, this.Height);
        }

        public void MoveBall()
        {
            this.Left++;
        }
    }
}
