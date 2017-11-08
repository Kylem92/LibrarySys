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
    public partial class frmMemAm : Form
    {
        public frmMemAm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
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
                MessageBox.Show(ex.Message);
            }

            grpMembers.Visible = true;
            dataGrdMem.Visible = true;
            
            readData();
            
        }

        private void readData()
        {
            txtId.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtForename.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[2].Value.ToString();
            comGender.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtAdd1.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtAdd2.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtAdd3.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtTel.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txtEmail.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[8].Value.ToString();
            txtRegDate.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[9].Value.ToString();
            txtBooksOut.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[10].Value.ToString();
            txtStatus.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[11].Value.ToString();
            
        }

        private void dataGrdMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpMem.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrdMem.Rows[e.RowIndex];
                txtId.Text = row.Cells["MemId"].Value.ToString();
                txtForename.Text = row.Cells["Forename"].Value.ToString();
                txtSurname.Text = row.Cells["Surname"].Value.ToString();
                comGender.Text = row.Cells["Gender"].Value.ToString();
                txtAdd1.Text = row.Cells["Address1"].Value.ToString();
                txtAdd2.Text = row.Cells["Address2"].Value.ToString();
                txtAdd3.Text = row.Cells["Address3"].Value.ToString();
                txtTel.Text = row.Cells["TelNo"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
               

            }
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            //validate the data
            if (txtForename.Text == "")
            {
                MessageBox.Show("Forename must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                txtForename.Focus();
            }

            
            if (txtSurname.Text == "")
            {
                MessageBox.Show("Surname must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                txtSurname.Focus();
            }

            
            if (comGender.Text == "")
            {
                MessageBox.Show("Gender must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                comGender.Focus();
            }

            if (txtAdd1.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                txtAdd1.Focus();
            }

            if (txtAdd2.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                txtAdd2.Focus();
            }

            if (txtAdd3.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                txtAdd3.Focus();
            }

            if (txtTel.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                txtTel.Focus();
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                txtEmail.Focus();
            }


            try{
            //update member details in Member file
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            OracleConnection conn = new OracleConnection(orcdb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            //Define SQL Query (UPDATE)
            string strSQL = "UPDATE Members SET Forename = '" + txtForename.Text +
               "', Surname = '" + txtSurname.Text +
               "', Gender = '" + comGender.Text +
               "', Address1 = '" + txtAdd1.Text +
               "', Address2 = '" + txtAdd2.Text +
               "', Address3 = '" + txtAdd3.Text +
               "', TelNo = '" + txtTel.Text +
               "', Email = '" + txtEmail.Text + "'WHERE MemId = " + txtId.Text;

            cmd.CommandText = strSQL;

            //Execute SQL Query
            cmd.ExecuteNonQuery();

            //Close Database
            conn.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //display confrmation message
            MessageBox.Show("Member Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpMem.Visible = false;
            grpMembers.Visible = false;
            dataGrdMem.Visible = false;
            txtSrhName.Text = "";
            txtSrhName.Focus();
        }

        private void grpMem_Enter(object sender, EventArgs e)
        {

        }

        private void grpMembers_Enter(object sender, EventArgs e)
        {

        }

        private void frmMemAm_Load(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void grpSearch_Enter(object sender, EventArgs e)
        {

        }

        private void txtRegDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
