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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmDataGridView dgv = new();

            Close();
            dgv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birthday = dtpBirthday.Value;
            DateTime today = DateTime.Now;

            TimeSpan age = today - birthday;

            int years = age.Days / 365;
            int months = (age.Days % 365) / 30;
            int days = (age.Days % 365) % 30;
            int hours = (int)age.TotalHours % 24;
            int minutes = (int)age.TotalMinutes % 60;
            int seconds = (int)age.TotalSeconds % 60;

            MessageBox.Show($"You are {years} years, {months} months, {days} days, {hours} hours, {minutes} minutes, and {seconds} seconds old.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmDomainUpDown dud = new();

            Close();
            dud.Show();
        }
    }
}
