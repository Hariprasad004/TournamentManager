namespace TrackerUI
{
    partial class CreatePrize
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
            PrizePercentTxtBox = new TextBox();
            label7 = new Label();
            PrizeAmountTxtBox = new TextBox();
            EmailLbl = new Label();
            PlaceNameTxtBox = new TextBox();
            label5 = new Label();
            PlaceNumTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CreatePrizeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(184, 31);
            label1.MaximumSize = new Size(1000, 1000);
            label1.Name = "label1";
            label1.Size = new Size(222, 43);
            label1.TabIndex = 2;
            label1.Text = "Create Prize";
            // 
            // PrizePercentTxtBox
            // 
            PrizePercentTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PrizePercentTxtBox.Location = new Point(247, 308);
            PrizePercentTxtBox.Multiline = true;
            PrizePercentTxtBox.Name = "PrizePercentTxtBox";
            PrizePercentTxtBox.Size = new Size(249, 35);
            PrizePercentTxtBox.TabIndex = 32;
            PrizePercentTxtBox.Text = "0";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(42, 308);
            label7.MaximumSize = new Size(1000, 1000);
            label7.Name = "label7";
            label7.Size = new Size(184, 37);
            label7.TabIndex = 31;
            label7.Text = "Prize Percentage";
            // 
            // PrizeAmountTxtBox
            // 
            PrizeAmountTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeAmountTxtBox.Location = new Point(247, 202);
            PrizeAmountTxtBox.Multiline = true;
            PrizeAmountTxtBox.Name = "PrizeAmountTxtBox";
            PrizeAmountTxtBox.Size = new Size(249, 35);
            PrizeAmountTxtBox.TabIndex = 30;
            PrizeAmountTxtBox.Text = "0";
            // 
            // EmailLbl
            // 
            EmailLbl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLbl.ForeColor = SystemColors.MenuHighlight;
            EmailLbl.Location = new Point(42, 202);
            EmailLbl.MaximumSize = new Size(1000, 1000);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(199, 37);
            EmailLbl.TabIndex = 29;
            EmailLbl.Text = "Prize Amount";
            // 
            // PlaceNameTxtBox
            // 
            PlaceNameTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceNameTxtBox.Location = new Point(247, 150);
            PlaceNameTxtBox.Multiline = true;
            PlaceNameTxtBox.Name = "PlaceNameTxtBox";
            PlaceNameTxtBox.Size = new Size(249, 35);
            PlaceNameTxtBox.TabIndex = 28;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(42, 153);
            label5.MaximumSize = new Size(1000, 1000);
            label5.Name = "label5";
            label5.Size = new Size(184, 37);
            label5.TabIndex = 27;
            label5.Text = "Place Name";
            // 
            // PlaceNumTxtBox
            // 
            PlaceNumTxtBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceNumTxtBox.Location = new Point(247, 101);
            PlaceNumTxtBox.Multiline = true;
            PlaceNumTxtBox.Name = "PlaceNumTxtBox";
            PlaceNumTxtBox.Size = new Size(249, 35);
            PlaceNumTxtBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(42, 99);
            label2.MaximumSize = new Size(1000, 1000);
            label2.Name = "label2";
            label2.Size = new Size(184, 37);
            label2.TabIndex = 25;
            label2.Text = "Place Number";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(199, 255);
            label3.MaximumSize = new Size(1000, 1000);
            label3.Name = "label3";
            label3.Size = new Size(134, 37);
            label3.TabIndex = 33;
            label3.Text = "-or-";
            // 
            // CreatePrizeBtn
            // 
            CreatePrizeBtn.BackColor = SystemColors.Window;
            CreatePrizeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePrizeBtn.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeBtn.Location = new Point(152, 383);
            CreatePrizeBtn.Name = "CreatePrizeBtn";
            CreatePrizeBtn.Size = new Size(286, 70);
            CreatePrizeBtn.TabIndex = 34;
            CreatePrizeBtn.Text = "Create Prize";
            CreatePrizeBtn.UseVisualStyleBackColor = false;
            CreatePrizeBtn.Click += CreatePrizeBtn_Click;
            // 
            // CreatePrize
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(591, 534);
            Controls.Add(CreatePrizeBtn);
            Controls.Add(label3);
            Controls.Add(PrizePercentTxtBox);
            Controls.Add(label7);
            Controls.Add(PrizeAmountTxtBox);
            Controls.Add(EmailLbl);
            Controls.Add(PlaceNameTxtBox);
            Controls.Add(label5);
            Controls.Add(PlaceNumTxtBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreatePrize";
            Text = "CreatePrize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PrizePercentTxtBox;
        private Label label7;
        private TextBox PrizeAmountTxtBox;
        private Label EmailLbl;
        private TextBox PlaceNameTxtBox;
        private Label label5;
        private TextBox PlaceNumTxtBox;
        private Label label2;
        private Label label3;
        private Button CreatePrizeBtn;
    }
}