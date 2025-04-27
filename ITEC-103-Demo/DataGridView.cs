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
    public partial class frmDataGridView : Form
    {
        public frmDataGridView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drvMain.Rows.Add(txtName.Text, txtAge.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drvMain.Rows.Remove(drvMain.SelectedRows[0]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmContextMenuStrip cms = new();

            Close();
            cms.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmDateTimePicker dtp = new();

            Close();
            dtp.Show();
        }
    }
}
