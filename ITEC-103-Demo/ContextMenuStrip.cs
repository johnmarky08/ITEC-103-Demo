using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_103_Demo
{
    public partial class frmContextMenuStrip : Form
    {
        public frmContextMenuStrip()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new();

            Close();
            main.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmDataGridView dgv = new();

            Close();
            dgv.Show();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSample.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSample.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSample.Paste();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCms.ForeColor = Color.Black;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCms.ForeColor = Color.White;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblCms.ForeColor = Color.Yellow;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
            lblCms.ForeColor = SystemColors.ControlText;
        }
    }
}
