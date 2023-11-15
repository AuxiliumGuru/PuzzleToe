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
            equationLabel = new Label();
            inputTxt = new TextBox();
            label2 = new Label();
            confirmBtn = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // equationLabel
            // 
            equationLabel.AutoSize = true;
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
            inputTxt.Location = new Point(87, 173);
            inputTxt.Multiline = true;
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(265, 45);
            inputTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(111, 41);
            label2.Name = "label2";
            label2.Size = new Size(209, 21);
            label2.TabIndex = 2;
            label2.Text = "Fix the Arithmetic Expression";
            // 
            // confirmBtn
            // 
            confirmBtn.Cursor = Cursors.Hand;
            confirmBtn.Location = new Point(178, 243);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(75, 29);
            confirmBtn.TabIndex = 3;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(equationLabel);
            panel1.Location = new Point(108, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 50);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // CalcuFix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 331);
            Controls.Add(confirmBtn);
            Controls.Add(label2);
            Controls.Add(inputTxt);
            Controls.Add(panel1);
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
        private Label label2;
        private Button confirmBtn;
        private Panel panel1;
    }
}