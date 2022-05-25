using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ValorantMatchmaking.UI
{
    public class Background : ContainerControl
    {
        public Color colorTop { get; set; } = Color.FromArgb(1, 1, 1);
        public Color colorBottom { get; set; } = Color.FromArgb(31, 5, 20);
        public Brush brushBorder { get; set; } = new SolidBrush(Color.FromArgb(45, 5, 0));
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle background = new Rectangle() { X = 0, Y = 0, Height = this.Height, Width = this.Width };

            LinearGradientBrush brush = new LinearGradientBrush(background, colorBottom, colorTop, 90f);

            ColorBlend colorBlend = new ColorBlend(2);
            colorBlend.Colors = new Color[] { colorTop, colorBottom };
            colorBlend.Positions =  new float[] { 0f, 1f };

            brush.InterpolationColors = colorBlend;

            e.Graphics.FillRectangle(brushBorder, new Rectangle() { X = 0, Y = 0, Height = this.Height + 1, Width = this.Width + 1 });
            e.Graphics.FillRectangle(brush, new Rectangle() { X = 2, Y = 2, Height = this.Height - 4, Width = this.Width - 4 });
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

    }
}
