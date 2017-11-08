using System;
using System.Windows.Forms;

namespace LibSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        
        private void mnuMemNew_Click(object sender, EventArgs e)
        {
            new frmMemReg().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuMembers_Click(object sender, EventArgs e)
        {

        }

        private void mnuMemAmd_Click(object sender, EventArgs e)
        {
            new frmMemAm().Show();
            this.Hide();
        }

        private void mnuMemDereg_Click(object sender, EventArgs e)
        {
            new frmMemDel().Show();
            this.Hide();
        }

        private void mnuMemList_Click(object sender, EventArgs e)
        {
            new frmMemList().Show();
            this.Hide();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuNewBook_Click(object sender, EventArgs e)
        {
            new frmBookNew().Show();
            this.Hide();
        }

        private void toolStripMenuAmend_Click(object sender, EventArgs e)
        {
            new frmBookAmend().Show();
            this.Hide();
        }

        private void toolStripMenuRemove_Click(object sender, EventArgs e)
        {
            new frmBookRemove().Show();
            this.Hide();
        }

        private void toolStripMenuList_Click(object sender, EventArgs e)
        {
            new frmBookList().Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmBookLoan().Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new frmBookReturn().Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new frmOverdue().Show();
            this.Hide();
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuLate_Click(object sender, EventArgs e)
        {
            new frmLateNotice().Show();
            this.Hide();
        }

        private void toolStripMenuAnalysis_Click(object sender, EventArgs e)
        {
            new frmMemAnalysis().Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new frmBookAnalysis().Show();
            this.Hide();
        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
