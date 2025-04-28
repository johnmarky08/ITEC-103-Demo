namespace ITEC_103_Demo
{
    partial class frmFileSystemWatcher
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
            fswMain = new FileSystemWatcher();
            lblState = new Label();
            btnBack = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)fswMain).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(49, 76);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 0;
            label1.Text = "Watching State of Desktop:";
            // 
            // fswMain
            // 
            fswMain.EnableRaisingEvents = true;
            fswMain.SynchronizingObject = this;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(105, 110);
            lblState.Name = "lblState";
            lblState.Size = new Size(75, 15);
            lblState.TabIndex = 1;
            lblState.Text = "No Changes.";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(49, 156);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 28);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F);
            btnNext.Location = new Point(147, 156);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabIndex = 12;
            btnNext.Text = "Exit";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // frmFileSystemWatcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 255);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(lblState);
            Controls.Add(label1);
            Name = "frmFileSystemWatcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileSystemWatcher - Demo";
            Load += frmFileSystemWatcher_Load;
            ((System.ComponentModel.ISupportInitialize)fswMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FileSystemWatcher fswMain;
        private Label lblState;
        private Button btnBack;
        private Button btnNext;
    }
}