using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace LibSYS
{
    public partial class frmMemDel : Form
    {
        public frmMemDel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void frmMemDel_Load(object sender, EventArgs e)
        {

        }

        private void txtSrhName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            //display members with matching surname
            //Define the connection
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Members WHERE Surname LIKE '" + txtSrhName.Text + "%'";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                dataGrdMem.DataSource = ds.Tables["ss"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your search did not match any records");
                MessageBox.Show(ex.Message);
            }

            grpMembers.Visible = true;
            dataGrdMem.Visible = true;
            readData();
        }

        private void readData()
        {
            txtId.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtRegDate.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[9].Value.ToString();
            txtStatus.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[11].Value.ToString();
            
        }

       

        private void grpSearch_Enter(object sender, EventArgs e)
        {

        }

        private void dataGrdMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrdMem.Rows[e.RowIndex];
                txtId.Text = row.Cells["MemId"].Value.ToString();
                txtRegDate.Text = row.Cells["RegDate"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();

            }
        }

        private void grpMembers_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtRegDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update member details in Member file
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            OracleConnection conn = new OracleConnection(orcdb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            //Define SQL Query (UPDATE)
            string strSQL = "UPDATE Members SET Status = 'I' WHERE MemId = " + txtId.Text;
              

            cmd.CommandText = strSQL;

            //Execute SQL Query
            cmd.ExecuteNonQuery();

            //Close Database
            conn.Close();
            //display confrmation message
            MessageBox.Show("Member Inactivated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtId.Text = "";
            txtRegDate.Text = "";
            txtStatus.Text = "";
            grpMembers.Visible = false;
            dataGrdMem.Visible = false;
            txtSrhName.Text = "";
            txtSrhName.Focus();
        }
    }
}
