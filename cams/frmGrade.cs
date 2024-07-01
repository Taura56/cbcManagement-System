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
    public partial class frmGrade : Form
    {
        public frmGrade()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGrade_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Saved");
            txtGradeCode.Text = "";
            txtInstructorCode.Text = "";
            txtGradeName.Text = "";
            txtCapacity.Text = "";
            txtGradeCode.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGradeCode.Text = "";
            txtInstructorCode.Text = "";
            txtGradeName.Text = "";
            txtCapacity.Text = "";
            txtGradeCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Deleted");
        }
    }
}
