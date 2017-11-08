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
    public partial class frmBookRemove : Form
    {
        public frmBookRemove()
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
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Books WHERE Title LIKE '" + txtSrhName.Text + "%'";

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
            txtBookId.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtAuthor.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtStatus.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            OracleConnection conn = new OracleConnection(orcdb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            //Define SQL Query (UPDATE)
            string strSQL = "UPDATE Books SET Status = 'U' WHERE BookId = " + txtBookId.Text;


            cmd.CommandText = strSQL;

            //Execute SQL Query
            cmd.ExecuteNonQuery();

            //Close Database
            conn.Close();
            //display confrmation message
            MessageBox.Show("Book Unavailable", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtBookId.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtStatus.Text = "";
            grpMembers.Visible = false;
            dataGrdMem.Visible = false;
            txtSrhName.Text = "";
            txtSrhName.Focus();
        }

        private void dataGrdMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrdMem.Rows[e.RowIndex];
                txtBookId.Text = row.Cells["BookId"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();

            }
        }

    }
}
