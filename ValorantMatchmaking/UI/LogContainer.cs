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
    public partial class LogContainer : UserControl
    {
        public string containerTitle { get; set; } = "Event Logs";
        public StringFormat textFormat { get; set; } = new StringFormat();
        public Brush backgroundBrush { get; set; } = new SolidBrush(Color.FromArgb(35, 5, 20));
        public Brush backgroundOutlineBrush { get; set; } = new SolidBrush(Color.FromArgb(55, 21, 30));
        public Brush titleBrush { get; set; } = new SolidBrush(Color.White);
        public Brush logEntryBrush { get; set; } = new SolidBrush(Color.Gray);
        public Font titleFont { get; set; } = new Font("Consolas", 9);

        //Shit way needs to change
        public List<string> logElements { get; set; } = new List<string> { "Random UI Log", "-----------UI Log-----------", "Deleting Valorant", "Fake Log", "Kinda long test string that isnt so long", "Yikes", "Test String 11", "Test String 11", "Test String 11", "Test String 11", "Test String 11" };
        public List<DateTime> logTimes { get; set; } = new List<DateTime> { DateTime.Now };
        public int maxVisibleElements { get; set; } = 7;

        public LogContainer()
        {
            InitializeComponent();
            textFormat.Alignment = StringAlignment.Center;
        }

        private void LogContainer_Paint(object sender, PaintEventArgs e)
        {
            Rectangle background = new Rectangle() { X = 2, Y = 2, Height = this.Height - 4, Width = this.Width - 4 };
            Rectangle backgroundOutline = new Rectangle() { X = 0, Y = 0, Height = this.Height, Width = this.Width };

            e.Graphics.FillRectangle(backgroundOutlineBrush, backgroundOutline);
            e.Graphics.FillRectangle(backgroundBrush, background);

            e.Graphics.DrawString(containerTitle, titleFont, titleBrush, this.Width / 2, titleFont.Size, textFormat);

            if (logElements.Count() > maxVisibleElements)
            {
               logElements.RemoveAt(0);
            }

            for(int x = 0; x <= logElements.Count() - 1; x++)
            {
                e.Graphics.DrawString(logElements[x], titleFont, logEntryBrush, this.Width / 2, titleFont.Size + ((x + 1) * 15), textFormat);
            }
        }
    }
}
