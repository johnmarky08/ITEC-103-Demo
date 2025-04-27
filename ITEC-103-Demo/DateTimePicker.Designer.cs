namespace ITEC_103_Demo
{
    partial class frmDateTimePicker
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
            btnExit = new Button();
            btnBack = new Button();
            dtpBirthday = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.Location = new Point(188, 169);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 28);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(91, 169);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 28);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(82, 68);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(148, 106);
            button1.Name = "button1";
            button1.Size = new Size(69, 25);
            button1.TabIndex = 10;
            button1.Text = "Get Age";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmDateTimePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 258);
            Controls.Add(button1);
            Controls.Add(dtpBirthday);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Name = "frmDateTimePicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DateTimePicker - Demo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnBack;
        private DateTimePicker dtpBirthday;
        private Button button1;
    }
}