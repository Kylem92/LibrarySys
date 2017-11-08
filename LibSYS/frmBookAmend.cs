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
    public partial class frmBookAmend : Form
    {
        public frmBookAmend()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void FillGrid(string sortOrder)
        {
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                OracleConnection conn = new OracleConnection(orcdb);

                //define SQL query
                string strSQL = "SELECT BookId, Title, Author, Genre, ISBN FROM Books ORDER BY " + sortOrder;

                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                grdBook.DataSource = ds.Tables["ss"];
                //grdBook.DataBind();
                conn.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            readData();
        }

        private void readData()
        {
            txtBookId.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtAuthor.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtGenre.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtISBN.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[4].Value.ToString();
            //txtStatus.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[5].Value.ToString();
            

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            //validate input
            if (txtAuthor.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }

            //validate input
            if (txtGenre.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenre.Focus();
                return;
            }

            if (txtISBN.Text == "")
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISBN.Focus();
                return;
            }

            //Connect to Database
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            OracleConnection conn = new OracleConnection(orcdb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();

            //Define SQL Query (UPDATE)
             string strSQL = "UPDATE Books SET Title = '" + txtTitle.Text +
                "', Author = '" + txtAuthor.Text +
                "', Genre = '" + txtGenre.Text + 
                "', ISBN = '" + txtISBN.Text + "' WHERE BookId = " + txtBookId.Text;

            cmd.CommandText = strSQL;

            //Execute SQL Query
            cmd.ExecuteNonQuery();

            //Close Database
            conn.Close();

            //Display confirmation message
            MessageBox.Show("Book Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGrid("BookID");
            //Clear the form
            txtBookId.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtGenre.Text = "";
            txtISBN.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdBook.Rows[e.RowIndex];
                txtBookId.Text = row.Cells["BookId"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                txtGenre.Text = row.Cells["Genre"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                //txtStatus.Text = row.Cells["Status"].Value.ToString();
                
            }
        }

        private void frmBookAmend_Load(object sender, EventArgs e)
        {
            FillGrid("BookId");
        }

        private void radBtnId_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid("BookId");
        }

        private void radBtnTitle_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid("Title");
        }

        private void radBtnAuthor_CheckedChanged(object sender, EventArgs e)
        {
            FillGrid("Author");
        }


    }
}
