namespace TrackerUI
{
    partial class CreateTeam
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
            TeamNameTxtBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SelectMemberComboBox = new ComboBox();
            label4 = new Label();
            AddTeamBtn = new Button();
            groupBox1 = new GroupBox();
            CreateMemberBtn = new Button();
            PhoneNoTxtBox = new TextBox();
            label7 = new Label();
            EmailTxtBox = new TextBox();
            EmailLbl = new Label();
            LastNameTxtBox = new TextBox();
            label5 = new Label();
            FirstnameTxtBox = new TextBox();
            label2 = new Label();
            TeamMembersListBox = new ListBox();
            CreateTeamBtn = new Button();
            DeleteSelectedBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TeamNameTxtBox
            // 
            TeamNameTxtBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameTxtBox.Location = new Point(43, 125);
            TeamNameTxtBox.Multiline = true;
            TeamNameTxtBox.Name = "TeamNameTxtBox";
            TeamNameTxtBox.Size = new Size(415, 35);
            TeamNameTxtBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(43, 79);
            label3.MaximumSize = new Size(1000, 1000);
            label3.Name = "label3";
            label3.Size = new Size(345, 43);
            label3.TabIndex = 14;
            label3.Text = "Team Name";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(503, 26);
            label1.MaximumSize = new Size(1000, 1000);
            label1.Name = "label1";
            label1.Size = new Size(220, 43);
            label1.TabIndex = 13;
            label1.Text = "Create Team";
            // 
            // SelectMemberComboBox
            // 
            SelectMemberComboBox.AllowDrop = true;
            SelectMemberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectMemberComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectMemberComboBox.FormattingEnabled = true;
            SelectMemberComboBox.IntegralHeight = false;
            SelectMemberComboBox.ItemHeight = 28;
            SelectMemberComboBox.Location = new Point(43, 233);
            SelectMemberComboBox.Name = "SelectMemberComboBox";
            SelectMemberComboBox.Size = new Size(415, 36);
            SelectMemberComboBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(43, 187);
            label4.MaximumSize = new Size(1000, 1000);
            label4.Name = "label4";
            label4.Size = new Size(345, 43);
            label4.TabIndex = 17;
            label4.Text = "Select Team Member";
            // 
            // AddTeamBtn
            // 
            AddTeamBtn.BackColor = SystemColors.Window;
            AddTeamBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddTeamBtn.ForeColor = SystemColors.MenuHighlight;
            AddTeamBtn.Location = new Point(136, 280);
            AddTeamBtn.Name = "AddTeamBtn";
            AddTeamBtn.Size = new Size(207, 53);
            AddTeamBtn.TabIndex = 20;
            AddTeamBtn.Text = "Add Member";
            AddTeamBtn.UseVisualStyleBackColor = false;
            AddTeamBtn.Click += AddTeamBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CreateMemberBtn);
            groupBox1.Controls.Add(PhoneNoTxtBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(EmailTxtBox);
            groupBox1.Controls.Add(EmailLbl);
            groupBox1.Controls.Add(LastNameTxtBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(FirstnameTxtBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(43, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 315);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // CreateMemberBtn
            // 
            CreateMemberBtn.BackColor = SystemColors.Window;
            CreateMemberBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateMemberBtn.ForeColor = SystemColors.MenuHighlight;
            CreateMemberBtn.Location = new Point(93, 243);
            CreateMemberBtn.Name = "CreateMemberBtn";
            CreateMemberBtn.Size = new Size(207, 53);
            CreateMemberBtn.TabIndex = 24;
            CreateMemberBtn.Text = "Create Member";
            CreateMemberBtn.UseVisualStyleBackColor = false;
            CreateMemberBtn.Click += CreateMemberBtn_Click;
            // 
            // PhoneNoTxtBox
            // 
            PhoneNoTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNoTxtBox.Location = new Point(140, 202);
            PhoneNoTxtBox.Multiline = true;
            PhoneNoTxtBox.Name = "PhoneNoTxtBox";
            PhoneNoTxtBox.Size = new Size(249, 35);
            PhoneNoTxtBox.TabIndex = 23;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(0, 202);
            label7.MaximumSize = new Size(1000, 1000);
            label7.Name = "label7";
            label7.Size = new Size(134, 37);
            label7.TabIndex = 22;
            label7.Text = "Phone Num";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTxtBox.Location = new Point(140, 152);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(249, 35);
            EmailTxtBox.TabIndex = 21;
            // 
            // EmailLbl
            // 
            EmailLbl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLbl.ForeColor = SystemColors.MenuHighlight;
            EmailLbl.Location = new Point(0, 155);
            EmailLbl.MaximumSize = new Size(1000, 1000);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(134, 37);
            EmailLbl.TabIndex = 20;
            EmailLbl.Text = "Email";
            // 
            // LastNameTxtBox
            // 
            LastNameTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTxtBox.Location = new Point(140, 106);
            LastNameTxtBox.Multiline = true;
            LastNameTxtBox.Name = "LastNameTxtBox";
            LastNameTxtBox.Size = new Size(249, 35);
            LastNameTxtBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(0, 106);
            label5.MaximumSize = new Size(1000, 1000);
            label5.Name = "label5";
            label5.Size = new Size(134, 37);
            label5.TabIndex = 18;
            label5.Text = "Last Name";
            // 
            // FirstnameTxtBox
            // 
            FirstnameTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            FirstnameTxtBox.Location = new Point(140, 52);
            FirstnameTxtBox.Multiline = true;
            FirstnameTxtBox.Name = "FirstnameTxtBox";
            FirstnameTxtBox.Size = new Size(249, 35);
            FirstnameTxtBox.TabIndex = 17;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(0, 52);
            label2.MaximumSize = new Size(1000, 1000);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 16;
            label2.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.ForeColor = SystemColors.MenuHighlight;
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 20;
            TeamMembersListBox.Location = new Point(552, 125);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(372, 504);
            TeamMembersListBox.TabIndex = 23;
            // 
            // CreateTeamBtn
            // 
            CreateTeamBtn.BackColor = SystemColors.Window;
            CreateTeamBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTeamBtn.ForeColor = SystemColors.MenuHighlight;
            CreateTeamBtn.Location = new Point(475, 660);
            CreateTeamBtn.Name = "CreateTeamBtn";
            CreateTeamBtn.Size = new Size(276, 62);
            CreateTeamBtn.TabIndex = 25;
            CreateTeamBtn.Text = "Create Team";
            CreateTeamBtn.UseVisualStyleBackColor = false;
            CreateTeamBtn.Click += CreateTeamBtn_Click;
            // 
            // DeleteSelectedBtn
            // 
            DeleteSelectedBtn.BackColor = SystemColors.Window;
            DeleteSelectedBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteSelectedBtn.ForeColor = SystemColors.MenuHighlight;
            DeleteSelectedBtn.Location = new Point(967, 310);
            DeleteSelectedBtn.Name = "DeleteSelectedBtn";
            DeleteSelectedBtn.Size = new Size(148, 81);
            DeleteSelectedBtn.TabIndex = 26;
            DeleteSelectedBtn.Text = "Delete Selected";
            DeleteSelectedBtn.UseVisualStyleBackColor = false;
            DeleteSelectedBtn.Click += DeleteSelectedBtn_Click;
            // 
            // CreateTeam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1227, 734);
            Controls.Add(DeleteSelectedBtn);
            Controls.Add(CreateTeamBtn);
            Controls.Add(TeamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(AddTeamBtn);
            Controls.Add(SelectMemberComboBox);
            Controls.Add(label4);
            Controls.Add(TeamNameTxtBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CreateTeam";
            Text = "CreateTeam";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TeamNameTxtBox;
        private Label label3;
        private Label label1;
        private ComboBox SelectMemberComboBox;
        private Label label4;
        private Button AddTeamBtn;
        private GroupBox groupBox1;
        private TextBox FirstnameTxtBox;
        private Label label2;
        private TextBox LastNameTxtBox;
        private Label label5;
        private TextBox PhoneNoTxtBox;
        private Label label7;
        private TextBox EmailTxtBox;
        private Label EmailLbl;
        private Button CreateMemberBtn;
        private ListBox TeamMembersListBox;
        private Button CreateTeamBtn;
        private Button DeleteSelectedBtn;
    }
}