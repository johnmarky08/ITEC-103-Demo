namespace ITEC_103_Demo
{
    partial class frmDomainUpDown
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
            dudMain = new DomainUpDown();
            btnGetSection = new Button();
            label1 = new Label();
            lblSection = new Label();
            btnBack = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // dudMain
            // 
            dudMain.Font = new Font("Segoe UI", 12F);
            dudMain.Location = new Point(138, 60);
            dudMain.Name = "dudMain";
            dudMain.Size = new Size(120, 29);
            dudMain.TabIndex = 0;
            dudMain.Text = "Select Section";
            // 
            // btnGetSection
            // 
            btnGetSection.Location = new Point(148, 106);
            btnGetSection.Name = "btnGetSection";
            btnGetSection.Size = new Size(105, 23);
            btnGetSection.TabIndex = 1;
            btnGetSection.Text = "Change Section";
            btnGetSection.UseVisualStyleBackColor = true;
            btnGetSection.Click += btnGetSection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(86, 29);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 2;
            label1.Text = "Alezer is from";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 15F);
            lblSection.Location = new Point(208, 29);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(112, 28);
            lblSection.TabIndex = 3;
            lblSection.Text = "BSINFO 1A.";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(110, 162);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 28);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F);
            btnNext.Location = new Point(208, 162);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // frmDomainUpDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 219);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(lblSection);
            Controls.Add(label1);
            Controls.Add(btnGetSection);
            Controls.Add(dudMain);
            Name = "frmDomainUpDown";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DomainUpDown - Demo";
            Load += frmDomainUpDown_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown dudMain;
        private Button btnGetSection;
        private Label label1;
        private Label lblSection;
        private Button btnBack;
        private Button btnNext;
    }
}