using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ValorantMatchmaking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializationButton_Click(object sender, EventArgs e)
        {
            SDK.GameData.GetVersionData();
            PanelDataContainer.Refresh();
        }
    }
}
