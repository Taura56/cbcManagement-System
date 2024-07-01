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
    public partial class frmSplash : Form
    {
        int counter;
        public frmSplash()
        {
            InitializeComponent();
            counter = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter +=50;
            if (counter <= 100){
                lblProgress.Text = "progress ..." + counter + "%";
                progressBar1.Value = counter;
            }
            if(counter == 100){
                frmLogin Login = new frmLogin();
                Login.Visible = true;
                this.Hide();
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
