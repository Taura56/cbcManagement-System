using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cams
{
    public partial class frmSubjectAllocation : Form
    {
        public frmSubjectAllocation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Saved");
            txtAllocationCode.Text = "";
            txtGradeCode.Text = "";
            txtAccademicYear.Text = "";
            cdoTerm.Text = "";
            txtSubject1.Text = "";
            txtSubject2.Text = "";
            txtSubject3.Text = "";
            txtSubject4.Text = "";
            txtSubject5.Text = "";
            txtSubject6.Text = "";
            txtSubject7.Text = "";
            txtSubject8.Text = "";
            txtSubject11.Text = "";
            txtSubject9.Text = "";
            txtSubject10.Text = "";
            txtSubject12.Text = "";
            txtSubject13.Text = "";
            txtSubject14.Text = "";
            txtSubject15.Text = "";
            txtSubject16.Text = "";
            txtSubject17.Text = "";
            txtSubject18.Text = "";
            txtSubject19.Text = "";
            txtSubject20.Text = "";
            txtAllocationCode.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Deleted");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAllocationCode.Text = "";
            txtGradeCode.Text = "";
            txtAccademicYear.Text = "";
            cdoTerm.Text = "";
            txtSubject1.Text = "";
            txtSubject2.Text = "";
            txtSubject3.Text = "";
            txtSubject4.Text = "";
            txtSubject5.Text = "";
            txtSubject6.Text = "";
            txtSubject7.Text = "";
            txtSubject8.Text = ""; 
            txtSubject11.Text = "";
            txtSubject9.Text = "";
            txtSubject10.Text = "";
            txtSubject12.Text = "";
            txtSubject13.Text = "";
            txtSubject14.Text = "";
            txtSubject15.Text = "";
            txtSubject16.Text = "";
            txtSubject17.Text = "";
            txtSubject18.Text = "";
            txtSubject19.Text = "";
            txtSubject20.Text = "";
            txtAllocationCode.Focus();
        }
    }
}
