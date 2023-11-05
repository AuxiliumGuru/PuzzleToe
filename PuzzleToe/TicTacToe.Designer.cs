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
            tile1Btn = new Button();
            tile2Btn = new Button();
            tile3Btn = new Button();
            tile6Btn = new Button();
            tile5Btn = new Button();
            tile4Btn = new Button();
            tile9Btn = new Button();
            tile8Btn = new Button();
            tile7Btn = new Button();
            label1 = new Label();
            newGameBtn = new Button();
            SuspendLayout();
            // 
            // tile1Btn
            // 
            tile1Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile1Btn.Location = new Point(43, 74);
            tile1Btn.Name = "tile1Btn";
            tile1Btn.Size = new Size(70, 63);
            tile1Btn.TabIndex = 0;
            tile1Btn.UseVisualStyleBackColor = true;
            tile1Btn.Click += tile1Btn_Click;
            // 
            // tile2Btn
            // 
            tile2Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile2Btn.Location = new Point(133, 74);
            tile2Btn.Name = "tile2Btn";
            tile2Btn.Size = new Size(70, 63);
            tile2Btn.TabIndex = 1;
            tile2Btn.UseVisualStyleBackColor = true;
            tile2Btn.Click += tile2Btn_Click;
            // 
            // tile3Btn
            // 
            tile3Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile3Btn.Location = new Point(224, 74);
            tile3Btn.Name = "tile3Btn";
            tile3Btn.Size = new Size(70, 63);
            tile3Btn.TabIndex = 2;
            tile3Btn.UseVisualStyleBackColor = true;
            tile3Btn.Click += tile3Btn_Click;
            // 
            // tile6Btn
            // 
            tile6Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile6Btn.Location = new Point(224, 162);
            tile6Btn.Name = "tile6Btn";
            tile6Btn.Size = new Size(70, 63);
            tile6Btn.TabIndex = 5;
            tile6Btn.UseVisualStyleBackColor = true;
            tile6Btn.Click += tile6Btn_Click;
            // 
            // tile5Btn
            // 
            tile5Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile5Btn.Location = new Point(133, 162);
            tile5Btn.Name = "tile5Btn";
            tile5Btn.Size = new Size(70, 63);
            tile5Btn.TabIndex = 4;
            tile5Btn.UseVisualStyleBackColor = true;
            tile5Btn.Click += tile5Btn_Click;
            // 
            // tile4Btn
            // 
            tile4Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile4Btn.Location = new Point(43, 162);
            tile4Btn.Name = "tile4Btn";
            tile4Btn.Size = new Size(70, 63);
            tile4Btn.TabIndex = 3;
            tile4Btn.UseVisualStyleBackColor = true;
            tile4Btn.Click += tile4Btn_Click;
            // 
            // tile9Btn
            // 
            tile9Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile9Btn.Location = new Point(224, 255);
            tile9Btn.Name = "tile9Btn";
            tile9Btn.Size = new Size(70, 63);
            tile9Btn.TabIndex = 8;
            tile9Btn.UseVisualStyleBackColor = true;
            tile9Btn.Click += tile9Btn_Click;
            // 
            // tile8Btn
            // 
            tile8Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile8Btn.Location = new Point(133, 255);
            tile8Btn.Name = "tile8Btn";
            tile8Btn.Size = new Size(70, 63);
            tile8Btn.TabIndex = 7;
            tile8Btn.UseVisualStyleBackColor = true;
            tile8Btn.Click += tile8Btn_Click;
            // 
            // tile7Btn
            // 
            tile7Btn.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tile7Btn.Location = new Point(43, 255);
            tile7Btn.Name = "tile7Btn";
            tile7Btn.Size = new Size(70, 63);
            tile7Btn.TabIndex = 6;
            tile7Btn.UseVisualStyleBackColor = true;
            tile7Btn.Click += tile7Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(109, 22);
            label1.Name = "label1";
            label1.Size = new Size(119, 29);
            label1.TabIndex = 9;
            label1.Text = "Tic Tac Toe";
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = Color.LightSteelBlue;
            newGameBtn.BackgroundImageLayout = ImageLayout.None;
            newGameBtn.ForeColor = SystemColors.ButtonHighlight;
            newGameBtn.Location = new Point(126, 341);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(85, 29);
            newGameBtn.TabIndex = 10;
            newGameBtn.Text = "Start Game";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // TicTactoe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(334, 397);
            Controls.Add(newGameBtn);
            Controls.Add(label1);
            Controls.Add(tile9Btn);
            Controls.Add(tile8Btn);
            Controls.Add(tile7Btn);
            Controls.Add(tile6Btn);
            Controls.Add(tile5Btn);
            Controls.Add(tile4Btn);
            Controls.Add(tile3Btn);
            Controls.Add(tile2Btn);
            Controls.Add(tile1Btn);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TicTactoe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            FormClosing += Form1_FormClosing;
            Load += tictactoe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tile1Btn;
        private Button tile2Btn;
        private Button tile3Btn;
        private Button tile6Btn;
        private Button tile5Btn;
        private Button tile4Btn;
        private Button tile9Btn;
        private Button tile8Btn;
        private Button tile7Btn;
        private Label label1;
        private Button newGameBtn;
    }
}