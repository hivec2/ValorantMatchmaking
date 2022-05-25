using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantMatchmaking.UI
{
    public partial class PanelDataContainer : UserControl
    {
        public Font titleFont { get; set; } = new Font("Consolas", 9);
        public Font dataFont { get; set; } = new Font("Consolas", 7);
        public StringFormat titleFormat { get; set; } = new StringFormat();

        public Brush backgroundBrush { get; set; } = new SolidBrush(Color.FromArgb(35, 5, 20));
        public Brush backgroundOutlineBrush { get; set; } = new SolidBrush(Color.FromArgb(55, 21, 30));
        public Brush outlineBrush { get; set; } = new SolidBrush(Color.FromArgb(61, 20, 25));
        public Brush outlineHoverBrush { get; set; } = new SolidBrush(Color.FromArgb(101, 20, 25));
        public Brush titleBrush { get; set; } = new SolidBrush(Color.White);
        public Brush dataBrush { get; set; } = new SolidBrush(Color.Gray);

        public PanelDataContainer()
        {
            InitializeComponent();
            titleFormat.Alignment = StringAlignment.Center;
        }

        private void PanelDataContainer_Paint(object sender, PaintEventArgs e)
        {
         
            Rectangle background = new Rectangle() { X = 2, Y = 2, Height = this.Height - 4, Width = this.Width - 4 };
            Rectangle backgroundOutline = new Rectangle() { X = 0, Y = 0, Height = this.Height, Width = this.Width };

            e.Graphics.FillRectangle(backgroundOutlineBrush, backgroundOutline);
            e.Graphics.FillRectangle(backgroundBrush, background);


            e.Graphics.DrawString("Valorant Information", titleFont, titleBrush, this.Width / 2, 10, titleFormat);
            e.Graphics.DrawString($"Version: {ValorantMatchmaking.SDK.GameData.gameVersion}", titleFont, dataBrush, this.Width / 2, 25, titleFormat);
        }
    }
}
