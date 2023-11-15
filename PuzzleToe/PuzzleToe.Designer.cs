namespace PuzzleToe
{
    partial class PuzzleToe
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
            aboutBtn = new Button();
            exitBtn = new Button();
            startBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // aboutBtn
            // 
            aboutBtn.Cursor = Cursors.Hand;
            aboutBtn.Location = new Point(129, 266);
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(167, 51);
            aboutBtn.TabIndex = 0;
            aboutBtn.Text = "About";
            aboutBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Location = new Point(129, 336);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(167, 51);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            startBtn.Cursor = Cursors.Hand;
            startBtn.Location = new Point(129, 195);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(167, 51);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 63);
            label1.Name = "label1";
            label1.Size = new Size(358, 77);
            label1.TabIndex = 3;
            label1.Text = "PuzzleToe";
            // 
            // PuzzleToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(label1);
            Controls.Add(startBtn);
            Controls.Add(exitBtn);
            Controls.Add(aboutBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PuzzleToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuzzleToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button aboutBtn;
        private Button exitBtn;
        private Button startBtn;
        private Label label1;
    }
}