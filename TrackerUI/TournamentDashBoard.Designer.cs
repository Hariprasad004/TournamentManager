namespace TrackerUI
{
    partial class TournamentDashBoard
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
            LoadExTournamentComboBox = new ComboBox();
            label4 = new Label();
            LoadTournamentBtn = new Button();
            CreateTournamentBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(200, 42);
            label1.MaximumSize = new Size(1000, 1000);
            label1.Name = "label1";
            label1.Size = new Size(400, 43);
            label1.TabIndex = 3;
            label1.Text = "Tournament Dashboard";
            // 
            // LoadExTournamentComboBox
            // 
            LoadExTournamentComboBox.AllowDrop = true;
            LoadExTournamentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadExTournamentComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoadExTournamentComboBox.FormattingEnabled = true;
            LoadExTournamentComboBox.IntegralHeight = false;
            LoadExTournamentComboBox.ItemHeight = 35;
            LoadExTournamentComboBox.Location = new Point(196, 150);
            LoadExTournamentComboBox.Name = "LoadExTournamentComboBox";
            LoadExTournamentComboBox.Size = new Size(409, 43);
            LoadExTournamentComboBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(239, 104);
            label4.MaximumSize = new Size(1000, 1000);
            label4.Name = "label4";
            label4.Size = new Size(322, 43);
            label4.TabIndex = 17;
            label4.Text = "Load Existing Tournament";
            // 
            // LoadTournamentBtn
            // 
            LoadTournamentBtn.BackColor = SystemColors.Window;
            LoadTournamentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoadTournamentBtn.ForeColor = SystemColors.MenuHighlight;
            LoadTournamentBtn.Location = new Point(257, 210);
            LoadTournamentBtn.Name = "LoadTournamentBtn";
            LoadTournamentBtn.Size = new Size(286, 70);
            LoadTournamentBtn.TabIndex = 35;
            LoadTournamentBtn.Text = "Load Tournament";
            LoadTournamentBtn.UseVisualStyleBackColor = false;
            LoadTournamentBtn.Click += LoadTournamentBtn_Click;
            // 
            // CreateTournamentBtn
            // 
            CreateTournamentBtn.BackColor = SystemColors.Window;
            CreateTournamentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentBtn.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentBtn.Location = new Point(245, 306);
            CreateTournamentBtn.Name = "CreateTournamentBtn";
            CreateTournamentBtn.Size = new Size(311, 70);
            CreateTournamentBtn.TabIndex = 36;
            CreateTournamentBtn.Text = "Create Tournament";
            CreateTournamentBtn.UseVisualStyleBackColor = false;
            CreateTournamentBtn.Click += CreateTournamentBtn_Click;
            // 
            // TournamentDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateTournamentBtn);
            Controls.Add(LoadTournamentBtn);
            Controls.Add(LoadExTournamentComboBox);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "TournamentDashBoard";
            Text = "TournamentDashBoard";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox LoadExTournamentComboBox;
        private Label label4;
        private Button LoadTournamentBtn;
        private Button CreateTournamentBtn;
    }
}