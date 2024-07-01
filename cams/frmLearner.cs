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
    public partial class frmLearner : Form
    {
        public frmLearner()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Saved");
            txtAdmNo.Text = "";
            txtSurname.Text = "";
            txtFirstName.Text = "";
            txtGradeCode.Text = "";
            txtYearOfAdmission.Text = "";
            txtGradeCode.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            cdoGender.Text = "";
            cdoTerm.Text = "";
            txtAccademicYear.Text = "";
            chdStatus.Checked = false;
            txtAdmNo.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAdmNo.Text = "";
            txtSurname.Text = "";
            txtFirstName.Text = "";
            txtGradeCode.Text = "";
            txtLearneMode.Text = "";
            txtYearOfAdmission.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            cdoGender.Text = "";
            cdoTerm.Text = "";
            txtAccademicYear.Text = "";
            chdStatus.Checked = false;
            txtAdmNo.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Deleted");
        }
    }
}
