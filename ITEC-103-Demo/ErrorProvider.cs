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
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            const string correctPass = "Group2_CS1A";
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                epCheckPass.SetError(txtPass, "Password cannot be empty.");
            }
            else if (txtPass.Text != correctPass)
            {
                epCheckPass.SetError(txtPass, "Password is incorrect.");
            }
            else
            {
                epCheckPass.SetError(txtPass, "");
                MessageBox.Show("Password is correct.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDomainUpDown dud = new();

            Close();
            dud.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmFileSystemWatcher fsw = new();

            Close();
            fsw.Show();
        }
    }
}
