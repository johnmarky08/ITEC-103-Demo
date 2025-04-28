namespace ITEC_103_Demo
{
    partial class frmErrorProvider
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtPass = new TextBox();
            btnCheck = new Button();
            epCheckPass = new ErrorProvider(components);
            btnBack = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)epCheckPass).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 79);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Password:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(161, 76);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(173, 23);
            txtPass.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(161, 114);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // epCheckPass
            // 
            epCheckPass.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epCheckPass.ContainerControl = this;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(106, 162);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 28);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F);
            btnNext.Location = new Point(204, 162);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // frmErrorProvider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 213);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(btnCheck);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Name = "frmErrorProvider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorProvider - Demo";
            ((System.ComponentModel.ISupportInitialize)epCheckPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPass;
        private Button btnCheck;
        private ErrorProvider epCheckPass;
        private Button btnBack;
        private Button btnNext;
    }
}