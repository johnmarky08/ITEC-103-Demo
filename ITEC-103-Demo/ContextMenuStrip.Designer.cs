namespace ITEC_103_Demo
{
    partial class frmContextMenuStrip
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
            btnBack = new Button();
            btnNext = new Button();
            txtSample = new TextBox();
            cmsRightClick = new ContextMenuStrip(components);
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            lblCms = new Label();
            cmsMain = new ContextMenuStrip(components);
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            labelToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            yellowToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            cmsRightClick.SuspendLayout();
            cmsMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(230, 190);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 28);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 10F);
            btnNext.Location = new Point(328, 190);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 28);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtSample
            // 
            txtSample.ContextMenuStrip = cmsRightClick;
            txtSample.Font = new Font("Segoe UI", 12F);
            txtSample.Location = new Point(201, 142);
            txtSample.Name = "txtSample";
            txtSample.Size = new Size(233, 29);
            txtSample.TabIndex = 8;
            // 
            // cmsRightClick
            // 
            cmsRightClick.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            cmsRightClick.Name = "cmsRightClick";
            cmsRightClick.Size = new Size(103, 70);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(102, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(102, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(102, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // lblCms
            // 
            lblCms.AutoSize = true;
            lblCms.Font = new Font("Segoe UI", 18F);
            lblCms.Location = new Point(204, 60);
            lblCms.Name = "lblCms";
            lblCms.Size = new Size(222, 32);
            lblCms.TabIndex = 9;
            lblCms.Text = "Context Menu Strip";
            // 
            // cmsMain
            // 
            cmsMain.Items.AddRange(new ToolStripItem[] { backgroundToolStripMenuItem, labelToolStripMenuItem, resetToolStripMenuItem });
            cmsMain.Name = "cmsMain";
            cmsMain.Size = new Size(181, 92);
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, blueToolStripMenuItem, greenToolStripMenuItem });
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(180, 22);
            backgroundToolStripMenuItem.Text = "Background";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(105, 22);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(105, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(105, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // labelToolStripMenuItem
            // 
            labelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blackToolStripMenuItem, whiteToolStripMenuItem, yellowToolStripMenuItem });
            labelToolStripMenuItem.Name = "labelToolStripMenuItem";
            labelToolStripMenuItem.Size = new Size(180, 22);
            labelToolStripMenuItem.Text = "Label";
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(180, 22);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(180, 22);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // yellowToolStripMenuItem
            // 
            yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            yellowToolStripMenuItem.Size = new Size(180, 22);
            yellowToolStripMenuItem.Text = "Yellow";
            yellowToolStripMenuItem.Click += yellowToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(180, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // frmContextMenuStrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 297);
            ContextMenuStrip = cmsMain;
            Controls.Add(lblCms);
            Controls.Add(txtSample);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Name = "frmContextMenuStrip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContextMenuStrip - Demo";
            cmsRightClick.ResumeLayout(false);
            cmsMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnNext;
        private TextBox txtSample;
        private Label lblCms;
        private ContextMenuStrip cmsRightClick;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ContextMenuStrip cmsMain;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem labelToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}