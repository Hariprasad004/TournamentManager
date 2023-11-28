namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TournamentNameLbl = new Label();
            RoundDropdown = new ComboBox();
            label4 = new Label();
            UnplayedChckBox = new CheckBox();
            MatchupListBox = new ListBox();
            Team1Lbl = new Label();
            label2 = new Label();
            Team1txtbox = new TextBox();
            Team2txtbox = new TextBox();
            label3 = new Label();
            Team2Lbl = new Label();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(38, 27);
            label1.MaximumSize = new Size(1000, 1000);
            label1.Name = "label1";
            label1.Size = new Size(227, 43);
            label1.TabIndex = 2;
            label1.Text = "Tournament:";
            // 
            // TournamentNameLbl
            // 
            TournamentNameLbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            TournamentNameLbl.ForeColor = SystemColors.MenuHighlight;
            TournamentNameLbl.Location = new Point(271, 27);
            TournamentNameLbl.MaximumSize = new Size(1000, 1000);
            TournamentNameLbl.Name = "TournamentNameLbl";
            TournamentNameLbl.Size = new Size(448, 43);
            TournamentNameLbl.TabIndex = 3;
            TournamentNameLbl.Text = "<none>";
            // 
            // RoundDropdown
            // 
            RoundDropdown.AllowDrop = true;
            RoundDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            RoundDropdown.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RoundDropdown.FormattingEnabled = true;
            RoundDropdown.IntegralHeight = false;
            RoundDropdown.ItemHeight = 35;
            RoundDropdown.Location = new Point(125, 98);
            RoundDropdown.Name = "RoundDropdown";
            RoundDropdown.Size = new Size(308, 43);
            RoundDropdown.TabIndex = 18;
            RoundDropdown.SelectedIndexChanged += RoundDropdown_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(38, 96);
            label4.MaximumSize = new Size(1000, 1000);
            label4.Name = "label4";
            label4.Size = new Size(93, 43);
            label4.TabIndex = 17;
            label4.Text = "Round";
            // 
            // UnplayedChckBox
            // 
            UnplayedChckBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UnplayedChckBox.ForeColor = SystemColors.MenuHighlight;
            UnplayedChckBox.Location = new Point(125, 166);
            UnplayedChckBox.Name = "UnplayedChckBox";
            UnplayedChckBox.Size = new Size(265, 50);
            UnplayedChckBox.TabIndex = 19;
            UnplayedChckBox.Text = "Unplayed Only";
            UnplayedChckBox.UseVisualStyleBackColor = true;
            UnplayedChckBox.CheckedChanged += UnplayedChckBox_CheckedChanged;
            // 
            // MatchupListBox
            // 
            MatchupListBox.ForeColor = SystemColors.MenuHighlight;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 20;
            MatchupListBox.Location = new Point(38, 265);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(354, 264);
            MatchupListBox.TabIndex = 23;
            MatchupListBox.SelectedIndexChanged += MatchupListBox_SelectedIndexChanged;
            // 
            // Team1Lbl
            // 
            Team1Lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Team1Lbl.ForeColor = SystemColors.MenuHighlight;
            Team1Lbl.Location = new Point(490, 166);
            Team1Lbl.MaximumSize = new Size(1000, 1000);
            Team1Lbl.Name = "Team1Lbl";
            Team1Lbl.Size = new Size(176, 43);
            Team1Lbl.TabIndex = 24;
            Team1Lbl.Text = "<Team One>";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(490, 209);
            label2.MaximumSize = new Size(1000, 1000);
            label2.Name = "label2";
            label2.Size = new Size(85, 43);
            label2.TabIndex = 25;
            label2.Text = "Score";
            // 
            // Team1txtbox
            // 
            Team1txtbox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Team1txtbox.Location = new Point(581, 212);
            Team1txtbox.Multiline = true;
            Team1txtbox.Name = "Team1txtbox";
            Team1txtbox.Size = new Size(138, 43);
            Team1txtbox.TabIndex = 26;
            // 
            // Team2txtbox
            // 
            Team2txtbox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Team2txtbox.Location = new Point(581, 400);
            Team2txtbox.Multiline = true;
            Team2txtbox.Name = "Team2txtbox";
            Team2txtbox.Size = new Size(138, 43);
            Team2txtbox.TabIndex = 29;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(490, 397);
            label3.MaximumSize = new Size(1000, 1000);
            label3.Name = "label3";
            label3.Size = new Size(85, 43);
            label3.TabIndex = 28;
            label3.Text = "Score";
            // 
            // Team2Lbl
            // 
            Team2Lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Team2Lbl.ForeColor = SystemColors.MenuHighlight;
            Team2Lbl.Location = new Point(490, 354);
            Team2Lbl.MaximumSize = new Size(1000, 1000);
            Team2Lbl.Name = "Team2Lbl";
            Team2Lbl.Size = new Size(176, 43);
            Team2Lbl.TabIndex = 27;
            Team2Lbl.Text = "<Team Two>";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(598, 289);
            label5.MaximumSize = new Size(1000, 1000);
            label5.Name = "label5";
            label5.Size = new Size(85, 43);
            label5.TabIndex = 30;
            label5.Text = "-VS-";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(757, 279);
            button2.Name = "button2";
            button2.Size = new Size(148, 59);
            button2.TabIndex = 32;
            button2.Text = "Score";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TournamentViewer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(931, 626);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(Team2txtbox);
            Controls.Add(label3);
            Controls.Add(Team2Lbl);
            Controls.Add(Team1txtbox);
            Controls.Add(label2);
            Controls.Add(Team1Lbl);
            Controls.Add(MatchupListBox);
            Controls.Add(UnplayedChckBox);
            Controls.Add(RoundDropdown);
            Controls.Add(label4);
            Controls.Add(TournamentNameLbl);
            Controls.Add(label1);
            Name = "TournamentViewer";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TournamentNameLbl;
        private ComboBox RoundDropdown;
        private Label label4;
        private CheckBox UnplayedChckBox;
        private ListBox MatchupListBox;
        private Label Team1Lbl;
        private Label label2;
        private TextBox Team1txtbox;
        private TextBox Team2txtbox;
        private Label label3;
        private Label Team2Lbl;
        private Label label5;
        private Button button2;
    }
}