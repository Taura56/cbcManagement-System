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
    public partial class frmSubjectDetails : Form
    {
        public frmSubjectDetails()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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
            txtSubjectCode.Text = "";
            txtPPCode.Text = "";
            txtPPGrade.Text = "";
            txtPPName.Text = "";
            txtLPCode.Text = "";
            txtLPGrade.Text = "";
            txtLPName.Text = "";
            txtUPCode.Text = "";
            txtUPGrade.Text = "";
            txtUPName.Text = "";
            txtJSSCode.Text = "";
            txtJSSGrade.Text = "";
            txtJSSName.Text = "";
            txtSubjectCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Deleted");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSubjectCode.Text = "";
            txtPPCode.Text = "";
            txtPPGrade.Text = "";
            txtPPName.Text = "";
            txtLPCode.Text = "";
            txtLPGrade.Text = "";
            txtLPName.Text = "";
            txtUPCode.Text = "";
            txtUPGrade.Text = "";
            txtUPName.Text = "";
            txtJSSCode.Text = "";
            txtJSSGrade.Text = "";
            txtJSSName.Text = "";
            chdStatus.Checked = false;
            txtSubjectCode.Focus();

        }
    }
}
