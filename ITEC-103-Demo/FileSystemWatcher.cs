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
    public partial class frmFileSystemWatcher : Form
    {
        public frmFileSystemWatcher()
        {
            InitializeComponent();
        }

        private void frmFileSystemWatcher_Load(object sender, EventArgs e)
        {
            fswMain.Path = @"C:\Users\Marky\OneDrive\Desktop";
            fswMain.Filter = "*.txt";

            fswMain.Changed += (s, e) => lblState.Text = "File Changed";
            fswMain.Created += (s, e) => lblState.Text = "File Created";
            fswMain.Deleted += (s, e) => lblState.Text = "File Deleted";
            fswMain.Renamed += (s, e) => lblState.Text = "File Renamed";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmErrorProvider ep = new();

            Close();
            ep.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
