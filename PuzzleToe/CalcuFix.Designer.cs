namespace BracketQuest
{
    partial class CalcuFix

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcuFix));
            equationLabel = new Label();
            inputTxt = new TextBox();
            confirmBtn = new Button();
            panel1 = new Panel();
            helpLink = new LinkLabel();
            attemptLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // equationLabel
            // 
            equationLabel.AutoSize = true;
            equationLabel.BackColor = Color.White;
            equationLabel.Dock = DockStyle.Fill;
            equationLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            equationLabel.Location = new Point(0, 0);
            equationLabel.Name = "equationLabel";
            equationLabel.Size = new Size(221, 40);
            equationLabel.TabIndex = 0;
            equationLabel.Text = "a-b*(c /d)+f = 0";
            equationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // inputTxt
            // 
            inputTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            inputTxt.Location = new Point(102, 167);
            inputTxt.Multiline = true;
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(265, 45);
            inputTxt.TabIndex = 1;
            // 
            // confirmBtn
            // 
            confirmBtn.Cursor = Cursors.Hand;
            confirmBtn.Location = new Point(188, 226);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 29);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(equationLabel);
            panel1.Location = new Point(123, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 50);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // helpLink
            // 
            helpLink.AutoSize = true;
            helpLink.Location = new Point(339, 25);
            helpLink.Name = "helpLink";
            helpLink.Size = new Size(77, 15);
            helpLink.TabIndex = 5;
            helpLink.TabStop = true;
            helpLink.Text = "How To Play?";
            helpLink.LinkClicked += helpLink_LinkClicked;
            // 
            // attemptLabel
            // 
            attemptLabel.AutoSize = true;
            attemptLabel.BackColor = Color.White;
            attemptLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            attemptLabel.Location = new Point(110, 260);
            attemptLabel.Name = "attemptLabel";
            attemptLabel.Size = new Size(241, 25);
            attemptLabel.TabIndex = 6;
            attemptLabel.Text = "Number Of Attempts Left: 0";
            // 
            // CalcuFix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = PuzzleToe.Properties.Resources.calcufix1;
            ClientSize = new Size(459, 331);
            Controls.Add(attemptLabel);
            Controls.Add(helpLink);
            Controls.Add(confirmBtn);
            Controls.Add(inputTxt);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalcuFix";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalcuFix";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label equationLabel;
        private TextBox inputTxt;
        private Button confirmBtn;
        private Panel panel1;
        private LinkLabel helpLink;
        private Label attemptLabel;
    }
}