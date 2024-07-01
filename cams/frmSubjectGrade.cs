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
    public partial class frmSubjectGrade : Form
    {
        public frmSubjectGrade()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Deleted");
            txtSubjectGradeCode.Text = "";
            txtRemarkCode.Text = "";
            txtRemark.Text = "";
            txtMinimumScore.Text = "";
            txtMaximumScore.Text = "";
            chdStatus.Checked = false;
            txtSubjectGradeCode.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSubjectGradeCode.Text = "";
            txtRemarkCode.Text = "";
            txtRemark.Text = "";
            txtMinimumScore.Text = "";
            txtMaximumScore.Text = "";
            chdStatus.Checked = false;
            txtSubjectGradeCode.Focus();
        }
    }
}
