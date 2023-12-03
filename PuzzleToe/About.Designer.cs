namespace PuzzleToe
{
    partial class About
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
            aboutTxt = new TextBox();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 1;
            label1.Text = "About";
            // 
            // aboutTxt
            // 
            aboutTxt.Location = new Point(39, 56);
            aboutTxt.Multiline = true;
            aboutTxt.Name = "aboutTxt";
            aboutTxt.ReadOnly = true;
            aboutTxt.ScrollBars = ScrollBars.Vertical;
            aboutTxt.Size = new Size(259, 284);
            aboutTxt.TabIndex = 2;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(125, 358);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 404);
            Controls.Add(closeBtn);
            Controls.Add(aboutTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            Load += About_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox aboutTxt;
        private Button closeBtn;
    }
}