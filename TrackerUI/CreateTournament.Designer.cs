namespace TrackerUI
{
    partial class CreateTournamentForm
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
            label1 = new Label();
            TournamentNameTxtBox = new TextBox();
            label3 = new Label();
            EntryFeeTxtBox = new TextBox();
            label2 = new Label();
            SelectTeamComboBox = new ComboBox();
            label4 = new Label();
            CreateNewLinkLbl = new LinkLabel();
            AddTeamBtn = new Button();
            CreatePrizeBtn = new Button();
            label5 = new Label();
            SelectedTeamListbox = new ListBox();
            button2 = new Button();
            DeletePrizeBtn = new Button();
            PrizesList = new ListBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(393, 34);
            label1.MaximumSize = new Size(1000, 1000);
            label1.Name = "label1";
            label1.Size = new Size(328, 43);
            label1.TabIndex = 1;
            label1.Text = "Create Tournament";
            // 
            // TournamentNameTxtBox
            // 
            TournamentNameTxtBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameTxtBox.Location = new Point(52, 145);
            TournamentNameTxtBox.Multiline = true;
            TournamentNameTxtBox.Name = "TournamentNameTxtBox";
            TournamentNameTxtBox.Size = new Size(345, 35);
            TournamentNameTxtBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(52, 99);
            label3.MaximumSize = new Size(1000, 1000);
            label3.Name = "label3";
            label3.Size = new Size(345, 43);
            label3.TabIndex = 11;
            label3.Text = "Tournament Name";
            // 
            // EntryFeeTxtBox
            // 
            EntryFeeTxtBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EntryFeeTxtBox.Location = new Point(184, 206);
            EntryFeeTxtBox.Multiline = true;
            EntryFeeTxtBox.Name = "EntryFeeTxtBox";
            EntryFeeTxtBox.Size = new Size(138, 43);
            EntryFeeTxtBox.TabIndex = 14;
            EntryFeeTxtBox.Text = "0";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(52, 206);
            label2.MaximumSize = new Size(1000, 1000);
            label2.Name = "label2";
            label2.Size = new Size(158, 43);
            label2.TabIndex = 13;
            label2.Text = "Entry fee";
            // 
            // SelectTeamComboBox
            // 
            SelectTeamComboBox.AllowDrop = true;
            SelectTeamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectTeamComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamComboBox.FormattingEnabled = true;
            SelectTeamComboBox.IntegralHeight = false;
            SelectTeamComboBox.ItemHeight = 35;
            SelectTeamComboBox.Location = new Point(52, 322);
            SelectTeamComboBox.Name = "SelectTeamComboBox";
            SelectTeamComboBox.Size = new Size(345, 43);
            SelectTeamComboBox.TabIndex = 16;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(52, 276);
            label4.MaximumSize = new Size(1000, 1000);
            label4.Name = "label4";
            label4.Size = new Size(237, 43);
            label4.TabIndex = 15;
            label4.Text = "Select Team";
            // 
            // CreateNewLinkLbl
            // 
            CreateNewLinkLbl.Location = new Point(301, 288);
            CreateNewLinkLbl.Name = "CreateNewLinkLbl";
            CreateNewLinkLbl.Size = new Size(96, 25);
            CreateNewLinkLbl.TabIndex = 17;
            CreateNewLinkLbl.TabStop = true;
            CreateNewLinkLbl.Text = "Create New";
            CreateNewLinkLbl.LinkClicked += CreateNewLinkLbl_LinkClicked;
            // 
            // AddTeamBtn
            // 
            AddTeamBtn.BackColor = SystemColors.Window;
            AddTeamBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddTeamBtn.ForeColor = SystemColors.MenuHighlight;
            AddTeamBtn.Location = new Point(139, 394);
            AddTeamBtn.Name = "AddTeamBtn";
            AddTeamBtn.Size = new Size(168, 53);
            AddTeamBtn.TabIndex = 19;
            AddTeamBtn.Text = "Add Team";
            AddTeamBtn.UseVisualStyleBackColor = false;
            AddTeamBtn.Click += AddTeamBtn_Click;
            // 
            // CreatePrizeBtn
            // 
            CreatePrizeBtn.BackColor = SystemColors.Window;
            CreatePrizeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePrizeBtn.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeBtn.Location = new Point(139, 478);
            CreatePrizeBtn.Name = "CreatePrizeBtn";
            CreatePrizeBtn.Size = new Size(168, 53);
            CreatePrizeBtn.TabIndex = 20;
            CreatePrizeBtn.Text = "Create Prize";
            CreatePrizeBtn.UseVisualStyleBackColor = false;
            CreatePrizeBtn.Click += CreatePrizeBtn_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(539, 99);
            label5.MaximumSize = new Size(1000, 1000);
            label5.Name = "label5";
            label5.Size = new Size(223, 43);
            label5.TabIndex = 21;
            label5.Text = "Teams/Players";
            // 
            // SelectedTeamListbox
            // 
            SelectedTeamListbox.ForeColor = SystemColors.MenuHighlight;
            SelectedTeamListbox.FormattingEnabled = true;
            SelectedTeamListbox.ItemHeight = 20;
            SelectedTeamListbox.Location = new Point(539, 145);
            SelectedTeamListbox.Name = "SelectedTeamListbox";
            SelectedTeamListbox.Size = new Size(354, 144);
            SelectedTeamListbox.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(915, 178);
            button2.Name = "button2";
            button2.Size = new Size(148, 81);
            button2.TabIndex = 23;
            button2.Text = "Delete Selected";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DeletePrizeBtn
            // 
            DeletePrizeBtn.BackColor = SystemColors.Window;
            DeletePrizeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeletePrizeBtn.ForeColor = SystemColors.MenuHighlight;
            DeletePrizeBtn.Location = new Point(915, 403);
            DeletePrizeBtn.Name = "DeletePrizeBtn";
            DeletePrizeBtn.Size = new Size(148, 81);
            DeletePrizeBtn.TabIndex = 26;
            DeletePrizeBtn.Text = "Delete Selected";
            DeletePrizeBtn.UseVisualStyleBackColor = false;
            DeletePrizeBtn.Click += DeletePrizeBtn_Click;
            // 
            // PrizesList
            // 
            PrizesList.ForeColor = SystemColors.MenuHighlight;
            PrizesList.FormattingEnabled = true;
            PrizesList.ItemHeight = 20;
            PrizesList.Location = new Point(539, 370);
            PrizesList.Name = "PrizesList";
            PrizesList.Size = new Size(354, 144);
            PrizesList.TabIndex = 25;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(539, 324);
            label6.MaximumSize = new Size(1000, 1000);
            label6.Name = "label6";
            label6.Size = new Size(223, 43);
            label6.TabIndex = 24;
            label6.Text = "Prizes";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(414, 554);
            button1.Name = "button1";
            button1.Size = new Size(286, 70);
            button1.TabIndex = 27;
            button1.Text = "Create Tournament";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1115, 669);
            Controls.Add(button1);
            Controls.Add(DeletePrizeBtn);
            Controls.Add(PrizesList);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(SelectedTeamListbox);
            Controls.Add(label5);
            Controls.Add(CreatePrizeBtn);
            Controls.Add(AddTeamBtn);
            Controls.Add(CreateNewLinkLbl);
            Controls.Add(SelectTeamComboBox);
            Controls.Add(label4);
            Controls.Add(EntryFeeTxtBox);
            Controls.Add(label2);
            Controls.Add(TournamentNameTxtBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CreateTournamentForm";
            Text = "CreateTournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TournamentNameTxtBox;
        private Label label3;
        private TextBox EntryFeeTxtBox;
        private Label label2;
        private ComboBox SelectTeamComboBox;
        private Label label4;
        private LinkLabel CreateNewLinkLbl;
        private Button AddTeamBtn;
        private Button CreatePrizeBtn;
        private Label label5;
        private ListBox SelectedTeamListbox;
        private Button button2;
        private Button DeletePrizeBtn;
        private ListBox PrizesList;
        private Label label6;
        private Button button1;
    }
}