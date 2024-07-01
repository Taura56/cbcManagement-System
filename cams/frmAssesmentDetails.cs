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
    public partial class frmAssesmentDetails : Form
    {
        public frmAssesmentDetails()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Saved");
            txtAssesmentCode.Text = "";
            txtAccademicYear.Text = "";
            txtAssesmentDescription.Text = "";
            txtAssessor.Text = "";
            cboTerm.Text = "";
            chdStatus.Checked = false;
            txtAssesmentCode.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Deleted");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAssesmentCode.Text = "";
            txtAccademicYear.Text = "";
            txtAssesmentDescription.Text = "";
            txtAssessor.Text = "";
            cboTerm.Text = "";
            chdStatus.Checked = false;
            txtAssesmentCode.Focus();
        }
    }
}
