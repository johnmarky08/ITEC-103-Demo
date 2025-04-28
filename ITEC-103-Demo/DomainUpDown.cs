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
    public partial class frmDomainUpDown : Form
    {
        public frmDomainUpDown()
        {
            InitializeComponent();
        }

        private void frmDomainUpDown_Load(object sender, EventArgs e)
        {
            string[] sections = { "BSINFO 1A", "BSINFO 1B", "BSINFO 1C", "BSINFO 1D", "BSCS 1A", "BSCS 1B" };
            
            dudMain.Items.AddRange(sections);
        }

        private void btnGetSection_Click(object sender, EventArgs e)
        {
            string section = dudMain.Text;

            lblSection.Text = section;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDateTimePicker dtp = new();

            Close();
            dtp.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmErrorProvider ep = new();

            Close();
            ep.Show();
        }
    }
}
