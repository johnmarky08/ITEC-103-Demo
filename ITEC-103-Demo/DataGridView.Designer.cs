namespace ITEC_103_Demo
{
    partial class frmDataGridView
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
            drvMain = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnBack = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)drvMain).BeginInit();
            SuspendLayout();
            // 
            // drvMain
            // 
            drvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drvMain.Columns.AddRange(new DataGridViewColumn[] { Name, Age });
            drvMain.Location = new Point(26, 95);
            drvMain.Name = "drvMain";
            drvMain.Size = new Size(243, 177);
            drvMain.TabIndex = 0;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 61);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Age:";
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 23);
            txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(74, 53);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(195, 23);
            txtAge.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(311, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(311, 66);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(111, 288);
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
            btnNext.Location = new Point(209, 288);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // frmDataGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 337);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(drvMain);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataGridView - Demo";
            ((System.ComponentModel.ISupportInitialize)drvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView drvMain;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Age;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAge;
        private Button button1;
        private Button button2;
        private Button btnBack;
        private Button btnNext;
    }
}