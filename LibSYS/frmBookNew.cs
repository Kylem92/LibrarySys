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
    public partial class frmBookNew : Form
    {
        public frmBookNew()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void frmBookNew_Load(object sender, EventArgs e)
        {
            txtBookId.Text = String.Format("{0:0000}", nextId());
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //validate input
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

            try
            {
                //define connection string
                String orcdb = "Data Source=Oracle;User Id = t00174978;Password = n58tqrss;";

                //connect to database
                OracleConnection conn = new OracleConnection(orcdb);

                //define SQL query (update)
                String strSQL = "INSERT INTO Books(BookId, Title, Author, genre, ISBN) VALUES (" + nextId().ToString() +
                    ",'" + txtTitle.Text +
                    "','" + txtAuthor.Text +
                    "','" + txtGenre.Text +
                    "','" + txtISBN.Text + "')";

                conn.Open();

                OracleCommand cmd = conn.CreateCommand();

                cmd.CommandText = strSQL;

                //execute SQL query
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //display confirmation message
            MessageBox.Show("A new book has been added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //reset UI
            txtBookId.Text = nextId().ToString();
            txtAuthor.Text = "";
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtISBN.Text = "";

        }

        private int nextId()
        {
            int last;
            String orcdb = "Data Source=Oracle;User Id = t00174978;Password = n58tqrss;";
            OracleConnection conn = new OracleConnection(orcdb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            String strSQL = "SELECT MAX(BookId) FROM Books";
            cmd.CommandText = strSQL;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[0] == DBNull.Value) 
                last = 1;
            else
                last = Convert.ToInt32(dr[0]) + 1;
            conn.Close();
            return last;
        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
