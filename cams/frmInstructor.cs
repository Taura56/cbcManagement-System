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
    public partial class frmInstructor : Form
    {
        String query;
        public frmInstructor()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmInstructor_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
            pnlSearch.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Ensure Username is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
            else if (txtInstructorCode.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInstructorCode.Focus();
            }
            else if (txtSurname.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
            }
            else if (txtFirstname.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstname.Focus();
            }
            else if (cdoGender.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cdoGender.Focus();
            }
            else if (cdoDesgnation.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cdoDesgnation.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
            }
            else if (txtEmail.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (txtInstructorDetails.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInstructorDetails.Focus();
            }
            else if (cdoPrevillage.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cdoPrevillage.Focus();
            }
            else if (chdStatus.Checked == false)
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                chdStatus.Focus();
            }
            else if (txtPassword.Text == "")
            {

                MessageBox.Show("Ensure Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (txtConfirmPassword.Text == "")
            {

                MessageBox.Show("Ensure Confirm Password is Filled", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {

                MessageBox.Show("Confirm Password ", "CAMS Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                int status;
                if (chdStatus.Checked)
                {
                    status = 1;
                }
                else
                {
                    status = 0;
                }
                query = "INSERT INTO instructor(InstructorCode,Surname,FName,Gender,Designation,PhoneNo,Email,Username,Password,Priviledge,Status,InstructorInitials)VALUES('" + txtInstructorCode.Text + "','" + txtSurname.Text + "','" + txtFirstname.Text + "','" + cdoGender.Text + "','" + cdoDesgnation.Text + "','" + txtPhoneNumber.Text + "','" + txtEmail.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "','" + cdoPrevillage.Text + "'," + status +",'" + txtInstructorDetails.Text+"')";
                connector con = new connector();
                if (con.openconnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, con.connection);
                    cmd.ExecuteNonQuery();
                    clear();
                    MessageBox.Show("Record Successfully saved!", "CAMS Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.closeConnection();

                }
            }
        }
        public void clear()
        {
            txtInstructorCode.Text = "";
            txtSurname.Text = "";
            txtFirstname.Text = "";
            cdoGender.Text = "";
            cdoDesgnation.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtInstructorDetails.Text = "";
            chdStatus.Checked = false;
            cdoPrevillage.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtInstructorCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successful Deleted");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {
            pnlSearch.Left = (this.Width - pnlMain.Width) / 2;
            pnlSearch.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cdoCreteria.Text == "")
            {
                MessageBox.Show("Record Successfully saved!", "CAMS Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cdoCreteria.Focus();

            }
                else if(txtSearch.Text=="")
                {
                    MessageBox.Show("Record Successfully saved!", "CAMS Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Focus();
                }
            else 
            {
               String searchValue = "%" + txtSearch.Text + "%";
               if(cdoCreteria.Text =="Instructor Code")
               {
                   query = "SELECT * FROM instructorview WHERE InstructorCode = '" + searchValue + "' ORDER BY InstructorCode";
               }
               else if (cdoCreteria.Text == "Instructor Name")
               {
                   query = "SELECT * FROM instructorview WHERE InstructorCode = '" + searchValue + "' ORDER BY InstructorCode";
               }
               else if (cdoCreteria.Text == "Phone Number")
               {
                   query = "SELECT * FROM instructorview WHERE InstructorCode = '" + searchValue + "' ORDER BY InstructorCode";
               }
               else if (cdoCreteria.Text == "Gender")
               {
                   query = "SELECT * FROM instructorview WHERE InstructorCode = '" + searchValue + "' ORDER BY InstructorCode";
               }
               else if (cdoCreteria.Text == "All")
               {
                   query = "SELECT * FROM instructorview WHERE InstructorCode = '" + searchValue + "' ORDER BY InstructorCode";
               }
               connector con = new connector();
                    if(con.openconnection())
                    {
                        MySqlCommand cmd = new MySqlCommand(query);
                        MySqlDataReader myDataReader = cmd.ExecuteReader();
                        this.dataGridView1.Rows.Clear();
                        while(myDataReader.Read())
                        {
                            String[] row = new String 

                        }
                    }
            }
        }
    }
}
