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
using ValorantMatchmaking.SDK;
using System.IO;

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
            SDK.LocalData.VerifyAPICache();

            if (GameData.IsRunning())
            {
                SDK.LocalData.GetLockfileData();
                SDK.LocalData.GetTokens();
                SDK.GameData.GetUserAccountData();
                SDK.LocalData.GetRegion();
                SDK.GameData.GetSeason();
                SDK.GameData.GetMatchIdentifier();
            }
            else
            {
                EventLogContainer.AddLogElement("Error: Valorant isnt Running.");
                Logger.Instance.Error("Application failed to initialize | Game isnt running.");
            }

            PanelDataContainer.Refresh();
            
           
        }
    }
}
