namespace TicTacToe
{
    partial class TicTactoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTactoe));
            tile1 = new Button();
            tile2 = new Button();
            tile3 = new Button();
            tile6 = new Button();
            tile5 = new Button();
            tile4 = new Button();
            tile9 = new Button();
            tile8 = new Button();
            tile7 = new Button();
            newGameBtn = new Button();
            turnLabel = new Label();
            backBtn = new Button();
            helpLink = new LinkLabel();
            SuspendLayout();
            // 
            // tile1
            // 
            tile1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile1.Location = new Point(43, 89);
            tile1.Name = "tile1";
            tile1.Size = new Size(70, 63);
            tile1.TabIndex = 0;
            tile1.UseVisualStyleBackColor = true;
            tile1.Click += tile1Btn_Click;
            // 
            // tile2
            // 
            tile2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile2.Location = new Point(133, 89);
            tile2.Name = "tile2";
            tile2.Size = new Size(70, 63);
            tile2.TabIndex = 1;
            tile2.UseVisualStyleBackColor = true;
            tile2.Click += tile2Btn_Click;
            // 
            // tile3
            // 
            tile3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile3.Location = new Point(224, 89);
            tile3.Name = "tile3";
            tile3.Size = new Size(70, 63);
            tile3.TabIndex = 2;
            tile3.UseVisualStyleBackColor = true;
            tile3.Click += tile3Btn_Click;
            // 
            // tile6
            // 
            tile6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile6.Location = new Point(224, 177);
            tile6.Name = "tile6";
            tile6.Size = new Size(70, 63);
            tile6.TabIndex = 5;
            tile6.UseVisualStyleBackColor = true;
            tile6.Click += tile6Btn_Click;
            // 
            // tile5
            // 
            tile5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile5.Location = new Point(133, 177);
            tile5.Name = "tile5";
            tile5.Size = new Size(70, 63);
            tile5.TabIndex = 4;
            tile5.UseVisualStyleBackColor = true;
            tile5.Click += tile5Btn_Click;
            // 
            // tile4
            // 
            tile4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile4.Location = new Point(43, 177);
            tile4.Name = "tile4";
            tile4.Size = new Size(70, 63);
            tile4.TabIndex = 3;
            tile4.UseVisualStyleBackColor = true;
            tile4.Click += tile4Btn_Click;
            // 
            // tile9
            // 
            tile9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile9.Location = new Point(224, 270);
            tile9.Name = "tile9";
            tile9.Size = new Size(70, 63);
            tile9.TabIndex = 8;
            tile9.UseVisualStyleBackColor = true;
            tile9.Click += tile9Btn_Click;
            // 
            // tile8
            // 
            tile8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile8.Location = new Point(133, 270);
            tile8.Name = "tile8";
            tile8.Size = new Size(70, 63);
            tile8.TabIndex = 7;
            tile8.UseVisualStyleBackColor = true;
            tile8.Click += tile8Btn_Click;
            // 
            // tile7
            // 
            tile7.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile7.Location = new Point(43, 270);
            tile7.Name = "tile7";
            tile7.Size = new Size(70, 63);
            tile7.TabIndex = 6;
            tile7.UseVisualStyleBackColor = true;
            tile7.Click += tile7Btn_Click;
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = SystemColors.ButtonFace;
            newGameBtn.BackgroundImageLayout = ImageLayout.None;
            newGameBtn.Cursor = Cursors.Hand;
            newGameBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newGameBtn.ForeColor = Color.CornflowerBlue;
            newGameBtn.Location = new Point(116, 339);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(104, 38);
            newGameBtn.TabIndex = 10;
            newGameBtn.Text = "Start Game";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // turnLabel
            // 
            turnLabel.AutoSize = true;
            turnLabel.BackColor = Color.White;
            turnLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            turnLabel.ForeColor = SystemColors.ActiveCaption;
            turnLabel.Location = new Point(129, 348);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(79, 23);
            turnLabel.TabIndex = 11;
            turnLabel.Text = "X's Turn";
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ActiveCaption;
            backBtn.BackgroundImage = PuzzleToe.Properties.Resources.back;
            backBtn.Cursor = Cursors.Hand;
            backBtn.ForeColor = SystemColors.Menu;
            backBtn.Location = new Point(22, 17);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(40, 40);
            backBtn.TabIndex = 12;
            backBtn.Text = "<";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // helpLink
            // 
            helpLink.AutoSize = true;
            helpLink.Location = new Point(243, 18);
            helpLink.Name = "helpLink";
            helpLink.Size = new Size(77, 15);
            helpLink.TabIndex = 13;
            helpLink.TabStop = true;
            helpLink.Text = "How To Play?";
            helpLink.LinkClicked += helpLink_LinkClicked;
            // 
            // TicTactoe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = PuzzleToe.Properties.Resources.tictactoe;
            ClientSize = new Size(334, 397);
            Controls.Add(helpLink);
            Controls.Add(backBtn);
            Controls.Add(newGameBtn);
            Controls.Add(tile9);
            Controls.Add(tile8);
            Controls.Add(tile7);
            Controls.Add(tile6);
            Controls.Add(tile5);
            Controls.Add(tile4);
            Controls.Add(tile3);
            Controls.Add(tile2);
            Controls.Add(tile1);
            Controls.Add(turnLabel);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TicTactoe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            FormClosing += Form1_FormClosing;
            Load += tictactoe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tile1;
        private Button tile2;
        private Button tile3;
        private Button tile6;
        private Button tile5;
        private Button tile4;
        private Button tile9;
        private Button tile8;
        private Button tile7;
        private Button newGameBtn;
        private Label turnLabel;
        private Button backBtn;
        private LinkLabel helpLink;
    }
}