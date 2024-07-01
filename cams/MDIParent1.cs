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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.MdiParent = this;
            main.Height = this.Height;
            main.Width = this.Width;
            main.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Visible = true;
            this.Dispose();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstructor instructor = new frmInstructor();
            instructor.Height = this.Height;
            instructor.Width = this.Width;
            instructor.Visible = true;
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrade grade = new frmGrade();
            grade.Height = this.Height;
            grade.Width = this.Width;
            grade.Visible = true;
        }

        private void learnnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLearner learner = new frmLearner();
            learner.Height = this.Height;
            learner.Width = this.Width;
            learner.Visible = true;
        }

        private void subjectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectDetails sujectDetails = new frmSubjectDetails();
            sujectDetails.Height = this.Height;
            sujectDetails.Width = this.Width;
            sujectDetails.Visible = true;
        }

        private void subjectAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSubjectAllocation sujectAllocation = new frmSubjectAllocation();
            sujectAllocation.Height = this.Height;
            sujectAllocation.Width = this.Width;
            sujectAllocation.Visible = true;
        }

        private void subjectGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectGrade subjectGrade = new frmSubjectGrade();
            subjectGrade.Height = this.Height;
            subjectGrade.Width = this.Width;
            subjectGrade.Visible = true;
        }

        private void assesmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssesmentDetails assesmentDetails = new frmAssesmentDetails();
            assesmentDetails.Height = this.Height;
            assesmentDetails.Width = this.Width;
            assesmentDetails.Visible = true;
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
