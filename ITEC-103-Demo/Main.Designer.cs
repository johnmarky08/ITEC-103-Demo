namespace ITEC_103_Demo
{
    partial class frmMain
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
            btnStart = new Button();
            lblMain = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 10F);
            btnStart.Location = new Point(325, 157);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(80, 28);
            btnStart.TabIndex = 2;
            btnStart.Text = "Begin";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI", 25F);
            lblMain.Location = new Point(159, 81);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(321, 46);
            lblMain.TabIndex = 4;
            lblMain.Text = "Group 2 - Reporting";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.Location = new Point(227, 157);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 28);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 285);
            Controls.Add(btnExit);
            Controls.Add(lblMain);
            Controls.Add(btnStart);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private frmContextMenuStrip cmsRightClick;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private Button btnStart;
        private Label lblCms;
        private Label lblMain;
        private Button btnExit;
    }
}
