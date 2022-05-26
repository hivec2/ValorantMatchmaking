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
        private List<string> _logElements { get; set; } = new List<string> { "Welcome to ValorantMatchmaking", "Press Initialize to get started" };
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

            if (_logElements.Count() > maxVisibleElements)
                _logElements.RemoveAt(0);

            for(int x = 0; x < _logElements.Count(); x++)
            {
                e.Graphics.DrawString(_logElements[x], titleFont, logEntryBrush, this.Width / 2, titleFont.Size + ((x + 1) * 15), textFormat);
            }
        }

        public void AddLogElement(string input)
        {
            _logElements.Add(input);
            this.Refresh();
        }
    }
}
