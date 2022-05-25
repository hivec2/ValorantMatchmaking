using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantMatchmaking.UI
{
    public partial class Button :System.Windows.Forms.Button  
    {
        public Font textFont { get; set; } = new Font("Consolas", 11);
        public StringFormat textFormat { get; set; } = new StringFormat();
        public static Color topColor { get; set; } = Color.FromArgb(75, 25, 31);
        public static Color bottomColor { get; set; } = Color.FromArgb(32, 18, 21);
        public static Brush outlineBrush { get; set; } = new SolidBrush(Color.FromArgb(61, 20, 25));
        public static Brush outlineHoverBrush { get; set; } = new SolidBrush(Color.FromArgb(101, 20, 25));
        public static Brush textBrush { get; set; } = new SolidBrush(Color.White);

        public Button()
        {
            InitializeComponent();

            textFormat.Alignment = StringAlignment.Center;
        }

        private void Button_Paint(object sender, PaintEventArgs e)
        {
            Rectangle backgroundOutline = new Rectangle() { X = 0, Y = 0, Height = this.Height, Width = this.Width };
            Rectangle background = new Rectangle() { X = 2, Y = 2, Height = this.Height - 4, Width = this.Width - 4 };

            LinearGradientBrush backgroundBrush = new LinearGradientBrush(background, topColor, bottomColor, 90f);

            ColorBlend colorBlend = new ColorBlend(2);
            colorBlend.Colors = new Color[] { topColor, bottomColor };
            colorBlend.Positions = new float[] { 0f, 1f };

            backgroundBrush.InterpolationColors = colorBlend;

            e.Graphics.FillRectangle(outlineBrush, backgroundOutline);
            e.Graphics.FillRectangle(backgroundBrush, background);

            e.Graphics.DrawString(this.Text, textFont, textBrush, this.Width / 2, this.Height / 2 - (textFont.Height / 2), textFormat);

            outlineBrush = new SolidBrush(Color.FromArgb(61, 20, 25));
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            outlineBrush = new SolidBrush(Color.FromArgb(101, 20, 25));
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            outlineBrush = new SolidBrush(Color.FromArgb(61, 20, 25));
        }
    }
}
