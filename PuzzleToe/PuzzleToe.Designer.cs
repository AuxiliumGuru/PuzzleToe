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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleToe));
            aboutBtn = new Button();
            exitBtn = new Button();
            startBtn = new Button();
            SuspendLayout();
            // 
            // aboutBtn
            // 
            aboutBtn.Cursor = Cursors.Hand;
            aboutBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            aboutBtn.Location = new Point(142, 250);
            aboutBtn.Name = "aboutBtn";
            aboutBtn.Size = new Size(167, 51);
            aboutBtn.TabIndex = 0;
            aboutBtn.Text = "About";
            aboutBtn.UseVisualStyleBackColor = true;
            aboutBtn.Click += aboutBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(142, 320);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(167, 51);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Cursor = Cursors.Hand;
            startBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.Location = new Point(142, 179);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(167, 51);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // PuzzleToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PuzzleToe;
            ClientSize = new Size(448, 450);
            Controls.Add(startBtn);
            Controls.Add(exitBtn);
            Controls.Add(aboutBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PuzzleToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuzzleToe";
            ResumeLayout(false);
        }

        #endregion

        private Button aboutBtn;
        private Button exitBtn;
        private Button startBtn;
    }
}