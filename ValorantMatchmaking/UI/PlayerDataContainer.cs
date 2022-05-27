using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValorantMatchmaking.SDK;

namespace ValorantMatchmaking.UI
{
    public partial class PlayerDataContainer : UserControl
    {
        public string playerName { get; set; } = "placeholder#1000";
        public PlayerData.Agent playerAgent { get; set; } = PlayerData.Agent.Jett;
        public PlayerData.Rank playerRank { get; set; } = PlayerData.Rank.Radiant;
        public int playerRankedRating { get; set; } = 50;
        public int playerElo { get; set; } = 820;

        public Brush backgroundBrush { get; set; } = new SolidBrush(Color.FromArgb(35, 5, 20));
        public Brush backgroundOutlineBrush { get; set; } = new SolidBrush(Color.FromArgb(55, 21, 30));
        public Brush playerNameBrush { get; set; } = new SolidBrush(Color.FromArgb(255, 255, 255));
        public Brush playerDataBrush { get; set; } = new SolidBrush(Color.FromArgb(255, 255, 255));
        public Brush playerRankProgressBrush { get; set; } = new SolidBrush(Color.FromArgb(145, 0, 0));
        public Brush playerRankProgressOutlineBrush { get; set; } = new SolidBrush(Color.FromArgb(45, 45, 45));

        public Font playerNameFont { get; set; } = new Font("Consolas", 11);
        public Font playerDataFont { get; set; } = new Font("Consolas", 9);

        public PlayerDataContainer()
        {
            InitializeComponent();
        }

        private void PlayerDataContainer_Paint(object sender, PaintEventArgs e)
        {
            //TODO: Update all ValorantAPICache paths to work entirely from app data instead of my current hardcoded paths for images etc
            //TODO v2: PlayerDataContainer actually needs to handle player data instead of the current hardcoded data  that was used for UI design
            //Edit: theres actually alot i need todo in terms of non hardcoded shit, widths heights positions overall

            Rectangle background = new Rectangle() { X = 2, Y = 2, Height = this.Height - 4, Width = this.Width - 4};
            Rectangle backgroundOutline = new Rectangle() { X = 0, Y = 0, Height = this.Height, Width = this.Width };
            Rectangle agentImage = new Rectangle() { X = 10, Y = this.Height / 2 - 40, Height = 80, Width = 80 };
            Rectangle rankImage = new Rectangle() { X = 100, Y = this.Height / 2  + 2, Height = 40, Width = 40 };
            Rectangle rankProgress = new Rectangle() { X = 105, Y = 31, Height = 3, Width = (int)((playerRankedRating / 100f) * 368f) };
            Rectangle rankProgressOutline = new Rectangle() { X = 104, Y = 30, Height = 5, Width = 370 };

            e.Graphics.FillRectangle(backgroundOutlineBrush, backgroundOutline);
            e.Graphics.FillRectangle(backgroundBrush, background);

            e.Graphics.FillRectangle(playerRankProgressOutlineBrush, rankProgressOutline);
            e.Graphics.FillRectangle(playerRankProgressBrush, rankProgress);

            e.Graphics.DrawImage(Image.FromFile($"A:\\Valorant\\Valorant\\bin\\Debug\\ValorantAPICache\\AgentIcons\\{PlayerData.GetUUID(playerAgent)}.png"), agentImage);
            e.Graphics.DrawImage(Image.FromFile($"A:\\Valorant\\Valorant\\bin\\Debug\\ValorantAPICache\\RankIcons\\{(int)playerRank}.png"), rankImage);

            e.Graphics.DrawString(playerName, playerNameFont, playerNameBrush,  100, 10);

            e.Graphics.DrawString($"Elo: {playerElo}", playerDataFont, playerDataBrush, 145, 45);
            e.Graphics.DrawString($"WR: 82%", playerDataFont, playerDataBrush, 145, 65);

            e.Graphics.DrawString($"RR: {playerRankedRating}", playerDataFont, playerDataBrush, 225, 45);
            e.Graphics.DrawString($"SC: 22%", playerDataFont, playerDataBrush, 225, 65);

            e.Graphics.DrawString($"Wins: 12", playerDataFont, playerDataBrush, 305, 45);
            e.Graphics.DrawString($"Loses: 2", playerDataFont, playerDataBrush, 305, 65);

            e.Graphics.DrawString($"VP: 1200", playerDataFont, playerDataBrush, 385, 45);
            e.Graphics.DrawString($"RP: 240", playerDataFont, playerDataBrush, 385, 65);
        }
    }
}
