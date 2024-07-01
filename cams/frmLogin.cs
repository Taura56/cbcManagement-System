using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cams
{
    public partial class frmLogin : Form
    {
        String query;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ensure all fields are filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {

                MessageBox.Show("Ensure all fields are filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                query = "SELECT * FROM instructor WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "' AND STATUS= 1";
                connector con = new connector();
                if (con.openconnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    MySqlDataReader myDataReader = cmd.ExecuteReader();

                    if (myDataReader.Read())
                    {
                        MDIParent1 mdi = new MDIParent1();
                        mdi.Visible = true;
                        this.Hide();
                    }
                    else
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        MessageBox.Show("Invalid Login");
                        txtUsername.Focus();
                    }
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
