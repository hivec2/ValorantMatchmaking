namespace ValorantMatchmaking
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat2 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat3 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat4 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat5 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat6 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat7 = new System.Drawing.StringFormat();
            this.background1 = new ValorantMatchmaking.UI.Background();
            this.PanelDataContainer = new ValorantMatchmaking.UI.PanelDataContainer();
            this.InitializationButton = new ValorantMatchmaking.UI.Button();
            this.QuitApplicationButton = new ValorantMatchmaking.UI.Button();
            this.EventLogContainer = new ValorantMatchmaking.UI.LogContainer();
            this.button3 = new ValorantMatchmaking.UI.Button();
            this.button2 = new ValorantMatchmaking.UI.Button();
            this.button1 = new ValorantMatchmaking.UI.Button();
            this.playerDataContainer10 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer9 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer8 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer7 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer6 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer5 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer4 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer3 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer2 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.playerDataContainer1 = new ValorantMatchmaking.UI.PlayerDataContainer();
            this.background1.SuspendLayout();
            this.SuspendLayout();
            // 
            // background1
            // 
            this.background1.colorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.background1.colorTop = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.background1.Controls.Add(this.PanelDataContainer);
            this.background1.Controls.Add(this.InitializationButton);
            this.background1.Controls.Add(this.QuitApplicationButton);
            this.background1.Controls.Add(this.EventLogContainer);
            this.background1.Controls.Add(this.button3);
            this.background1.Controls.Add(this.button2);
            this.background1.Controls.Add(this.button1);
            this.background1.Controls.Add(this.playerDataContainer10);
            this.background1.Controls.Add(this.playerDataContainer9);
            this.background1.Controls.Add(this.playerDataContainer8);
            this.background1.Controls.Add(this.playerDataContainer7);
            this.background1.Controls.Add(this.playerDataContainer6);
            this.background1.Controls.Add(this.playerDataContainer5);
            this.background1.Controls.Add(this.playerDataContainer4);
            this.background1.Controls.Add(this.playerDataContainer3);
            this.background1.Controls.Add(this.playerDataContainer2);
            this.background1.Controls.Add(this.playerDataContainer1);
            this.background1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background1.Location = new System.Drawing.Point(0, 0);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(1055, 686);
            this.background1.TabIndex = 0;
            this.background1.Text = "z";
            // 
            // PanelDataContainer
            // 
            this.PanelDataContainer.dataFont = new System.Drawing.Font("Consolas", 7F);
            this.PanelDataContainer.Location = new System.Drawing.Point(213, 530);
            this.PanelDataContainer.Name = "PanelDataContainer";
            this.PanelDataContainer.Size = new System.Drawing.Size(311, 135);
            this.PanelDataContainer.TabIndex = 16;
            this.PanelDataContainer.titleFont = new System.Drawing.Font("Consolas", 9F);
            stringFormat1.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.PanelDataContainer.titleFormat = stringFormat1;
            // 
            // InitializationButton
            // 
            this.InitializationButton.Location = new System.Drawing.Point(22, 12);
            this.InitializationButton.Name = "InitializationButton";
            this.InitializationButton.Size = new System.Drawing.Size(112, 33);
            this.InitializationButton.TabIndex = 15;
            this.InitializationButton.Text = "Initialize";
            this.InitializationButton.textFont = new System.Drawing.Font("Consolas", 11F);
            stringFormat2.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat2.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat2.Trimming = System.Drawing.StringTrimming.Character;
            this.InitializationButton.textFormat = stringFormat2;
            this.InitializationButton.UseVisualStyleBackColor = true;
            this.InitializationButton.Click += new System.EventHandler(this.InitializationButton_Click);
            // 
            // QuitApplicationButton
            // 
            this.QuitApplicationButton.Location = new System.Drawing.Point(1007, 12);
            this.QuitApplicationButton.Name = "QuitApplicationButton";
            this.QuitApplicationButton.Size = new System.Drawing.Size(25, 25);
            this.QuitApplicationButton.TabIndex = 14;
            this.QuitApplicationButton.Text = "x";
            this.QuitApplicationButton.textFont = new System.Drawing.Font("Consolas", 11F);
            stringFormat3.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat3.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat3.Trimming = System.Drawing.StringTrimming.Character;
            this.QuitApplicationButton.textFormat = stringFormat3;
            this.QuitApplicationButton.UseVisualStyleBackColor = true;
            this.QuitApplicationButton.Click += new System.EventHandler(this.QuitApplicationButton_Click);
            // 
            // EventLogContainer
            // 
            this.EventLogContainer.containerTitle = "Event Logs";
            this.EventLogContainer.Location = new System.Drawing.Point(530, 530);
            this.EventLogContainer.maxVisibleElements = 7;
            this.EventLogContainer.Name = "EventLogContainer";
            this.EventLogContainer.Size = new System.Drawing.Size(502, 135);
            this.EventLogContainer.TabIndex = 13;
            stringFormat4.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat4.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat4.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat4.Trimming = System.Drawing.StringTrimming.Character;
            this.EventLogContainer.textFormat = stringFormat4;
            this.EventLogContainer.titleFont = new System.Drawing.Font("Consolas", 9F);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 624);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Scan Core-Game Lobby";
            this.button3.textFont = new System.Drawing.Font("Consolas", 11F);
            stringFormat5.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat5.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat5.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat5.Trimming = System.Drawing.StringTrimming.Character;
            this.button3.textFormat = stringFormat5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Scan Pre-Game Lobby";
            this.button2.textFont = new System.Drawing.Font("Consolas", 11F);
            stringFormat6.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat6.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat6.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat6.Trimming = System.Drawing.StringTrimming.Character;
            this.button2.textFormat = stringFormat6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Scan Queue Lobby";
            this.button1.textFont = new System.Drawing.Font("Consolas", 11F);
            stringFormat7.Alignment = System.Drawing.StringAlignment.Center;
            stringFormat7.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat7.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat7.Trimming = System.Drawing.StringTrimming.Character;
            this.button1.textFormat = stringFormat7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // playerDataContainer10
            // 
            this.playerDataContainer10.Location = new System.Drawing.Point(22, 434);
            this.playerDataContainer10.Name = "playerDataContainer10";
            this.playerDataContainer10.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Viper;
            this.playerDataContainer10.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer10.playerElo = 820;
            this.playerDataContainer10.playerName = "Icicle#1736";
            this.playerDataContainer10.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer10.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Silver1;
            this.playerDataContainer10.playerRankedRating = 72;
            this.playerDataContainer10.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer10.TabIndex = 9;
            // 
            // playerDataContainer9
            // 
            this.playerDataContainer9.Location = new System.Drawing.Point(530, 434);
            this.playerDataContainer9.Name = "playerDataContainer9";
            this.playerDataContainer9.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Jett;
            this.playerDataContainer9.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer9.playerElo = 820;
            this.playerDataContainer9.playerName = "hyDra#Papi";
            this.playerDataContainer9.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer9.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Diamond3;
            this.playerDataContainer9.playerRankedRating = 72;
            this.playerDataContainer9.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer9.TabIndex = 8;
            // 
            // playerDataContainer8
            // 
            this.playerDataContainer8.Location = new System.Drawing.Point(22, 338);
            this.playerDataContainer8.Name = "playerDataContainer8";
            this.playerDataContainer8.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Sage;
            this.playerDataContainer8.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer8.playerElo = 820;
            this.playerDataContainer8.playerName = "Jake#2134";
            this.playerDataContainer8.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer8.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Platinum3;
            this.playerDataContainer8.playerRankedRating = 72;
            this.playerDataContainer8.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer8.TabIndex = 7;
            // 
            // playerDataContainer7
            // 
            this.playerDataContainer7.Location = new System.Drawing.Point(530, 338);
            this.playerDataContainer7.Name = "playerDataContainer7";
            this.playerDataContainer7.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Fade;
            this.playerDataContainer7.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer7.playerElo = 820;
            this.playerDataContainer7.playerName = "hyDra2#Baby";
            this.playerDataContainer7.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer7.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Immortal3;
            this.playerDataContainer7.playerRankedRating = 72;
            this.playerDataContainer7.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer7.TabIndex = 6;
            // 
            // playerDataContainer6
            // 
            this.playerDataContainer6.Location = new System.Drawing.Point(530, 242);
            this.playerDataContainer6.Name = "playerDataContainer6";
            this.playerDataContainer6.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Killjoy;
            this.playerDataContainer6.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer6.playerElo = 820;
            this.playerDataContainer6.playerName = "PoppyStealer#2549";
            this.playerDataContainer6.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer6.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Platinum1;
            this.playerDataContainer6.playerRankedRating = 72;
            this.playerDataContainer6.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer6.TabIndex = 5;
            // 
            // playerDataContainer5
            // 
            this.playerDataContainer5.Location = new System.Drawing.Point(22, 242);
            this.playerDataContainer5.Name = "playerDataContainer5";
            this.playerDataContainer5.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Neon;
            this.playerDataContainer5.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer5.playerElo = 820;
            this.playerDataContainer5.playerName = "Test#Long";
            this.playerDataContainer5.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer5.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Radiant;
            this.playerDataContainer5.playerRankedRating = 72;
            this.playerDataContainer5.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer5.TabIndex = 4;
            // 
            // playerDataContainer4
            // 
            this.playerDataContainer4.Location = new System.Drawing.Point(530, 146);
            this.playerDataContainer4.Name = "playerDataContainer4";
            this.playerDataContainer4.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Skye;
            this.playerDataContainer4.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer4.playerElo = 820;
            this.playerDataContainer4.playerName = "Tafiisgoated#5376";
            this.playerDataContainer4.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer4.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Bronze2;
            this.playerDataContainer4.playerRankedRating = 72;
            this.playerDataContainer4.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer4.TabIndex = 3;
            // 
            // playerDataContainer3
            // 
            this.playerDataContainer3.Location = new System.Drawing.Point(22, 146);
            this.playerDataContainer3.Name = "playerDataContainer3";
            this.playerDataContainer3.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Breach;
            this.playerDataContainer3.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer3.playerElo = 820;
            this.playerDataContainer3.playerName = "ExWolf#WOLF";
            this.playerDataContainer3.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer3.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Platinum1;
            this.playerDataContainer3.playerRankedRating = 72;
            this.playerDataContainer3.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer3.TabIndex = 2;
            // 
            // playerDataContainer2
            // 
            this.playerDataContainer2.Location = new System.Drawing.Point(530, 50);
            this.playerDataContainer2.Name = "playerDataContainer2";
            this.playerDataContainer2.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Yoru;
            this.playerDataContainer2.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer2.playerElo = 820;
            this.playerDataContainer2.playerName = "Kimeriarin#RU1";
            this.playerDataContainer2.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer2.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Iron3;
            this.playerDataContainer2.playerRankedRating = 52;
            this.playerDataContainer2.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer2.TabIndex = 1;
            // 
            // playerDataContainer1
            // 
            this.playerDataContainer1.Location = new System.Drawing.Point(22, 50);
            this.playerDataContainer1.Name = "playerDataContainer1";
            this.playerDataContainer1.playerAgent = ValorantMatchmaking.SDK.PlayerData.Agent.Cypher;
            this.playerDataContainer1.playerDataFont = new System.Drawing.Font("Consolas", 9F);
            this.playerDataContainer1.playerElo = 820;
            this.playerDataContainer1.playerName = "TenZ#FAKE";
            this.playerDataContainer1.playerNameFont = new System.Drawing.Font("Consolas", 11F);
            this.playerDataContainer1.playerRank = ValorantMatchmaking.SDK.PlayerData.Rank.Gold2;
            this.playerDataContainer1.playerRankedRating = 72;
            this.playerDataContainer1.Size = new System.Drawing.Size(502, 90);
            this.playerDataContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 686);
            this.Controls.Add(this.background1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "+";
            this.background1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Background background1;
        private UI.PlayerDataContainer playerDataContainer1;
        private UI.PlayerDataContainer playerDataContainer2;
        private UI.PlayerDataContainer playerDataContainer10;
        private UI.PlayerDataContainer playerDataContainer9;
        private UI.PlayerDataContainer playerDataContainer8;
        private UI.PlayerDataContainer playerDataContainer7;
        private UI.PlayerDataContainer playerDataContainer6;
        private UI.PlayerDataContainer playerDataContainer5;
        private UI.PlayerDataContainer playerDataContainer4;
        private UI.PlayerDataContainer playerDataContainer3;
        private UI.Button button1;
        private UI.Button button3;
        private UI.Button button2;
        private UI.LogContainer EventLogContainer;
        private UI.Button QuitApplicationButton;
        private UI.Button InitializationButton;
        private UI.PanelDataContainer PanelDataContainer;
    }
}

