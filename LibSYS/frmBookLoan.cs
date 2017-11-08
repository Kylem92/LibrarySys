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
    public partial class frmBookLoan : Form
    {
        public frmBookLoan()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void btnSrhMem_Click(object sender, EventArgs e)
        {
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Members WHERE Surname LIKE '" + txtSrhName.Text + "%' AND Status = 'A' AND NoOfBooks < 1";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();
                     
                da.Fill(ds, "ss");
                dataGrdMem.DataSource = ds.Tables["ss"];
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Records Found");
                }
                else
                {
                    readMemData();
                }    
                
                conn.Close();
            }
           
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            grpMembers.Visible = true;
            dataGrdMem.Visible = true;
            
           
        }

        private void readMemData()
        {
            txtId.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtForename.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtBooksOut.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[10].Value.ToString();
            txtMemStat.Text = dataGrdMem.Rows[dataGrdMem.CurrentCell.RowIndex].Cells[11].Value.ToString();

        }

        private void btnSrhBook_Click(object sender, EventArgs e)
        {
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Books WHERE Title LIKE '" + txtSrhBook.Text + "%' AND Status = 'A'";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                grdBook.DataSource = ds.Tables["ss"];
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Records Found");
                }
                else
                {
                    readBookData();
                }  
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            grpBook.Visible = true;
            grdBook.Visible = true;

            

        }

        private void readBookData()
        {
            txtBookId.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtAuthor.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtGenre.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtStatus.Text = grdBook.Rows[grdBook.CurrentCell.RowIndex].Cells[5].Value.ToString();


        }

        private void dataGrdMem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpMembers.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrdMem.Rows[e.RowIndex];
                txtId.Text = row.Cells["MemId"].Value.ToString();
                txtForename.Text = row.Cells["Forename"].Value.ToString();
                txtSurname.Text = row.Cells["Surname"].Value.ToString();
                txtBooksOut.Text = row.Cells["NoOfBooks"].Value.ToString();
                txtMemStat.Text = row.Cells["Status"].Value.ToString();


            }
        }

        private void grdBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdBook.Rows[e.RowIndex];
                txtBookId.Text = row.Cells["BookId"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                txtGenre.Text = row.Cells["Genre"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();

            }
        }

        private int nextId()
        {
            int last;
            String orcdb = "Data Source=Oracle;User Id = t00174978;Password = n58tqrss;";
            OracleConnection conn = new OracleConnection(orcdb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            String strSQL = "SELECT MAX(RentalId) FROM Rentals";
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

        private void frmBookLoan_Load(object sender, EventArgs e)
        {
            txtRentId.Text = String.Format("{0:0000}", nextId());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtMemStat.Text == "I" || txtStatus.Text == "U")
            {
                MessageBox.Show("This Member cannot loan this book", "Error!");
            }

            if(txtBooksOut.Text == "1")
            {
                MessageBox.Show("This Member cannot loan this book", "Error!");
            }

            try
            {
                //define connection string
                String orcdb = "Data Source=Oracle;User Id = t00174978;Password = n58tqrss;";

                //connect to database
                OracleConnection conn = new OracleConnection(orcdb);

                //define SQL query (update)
                String strSQL = "INSERT INTO Rentals(RentalId, MemId, BookId, Loan_Date, Due_Date) VALUES (" + nextId().ToString() +
                    ",'" + txtId.Text +
                    "','" + txtBookId.Text +
                    "','" + loanDate() +
                    "','" + dueDate() + "')";

                conn.Open();

                OracleCommand cmd = conn.CreateCommand();

                cmd.CommandText = strSQL;

                //execute SQL query
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error with Rental INSERT");
                MessageBox.Show(ex.Message);
            }

            try
            {
                //update member details in Member file
                string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
                OracleConnection conn = new OracleConnection(orcdb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //Define SQL Query (UPDATE)
                string strSQL = "UPDATE Members SET NoOfBooks = 1 WHERE MemId = " + txtId.Text;

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

            try
            {
                //update member details in Member file
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //display confirmation message
            MessageBox.Show("A book has been loaned", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //reset UI
            txtRentId.Text = nextId().ToString();
            txtId.Text = "";
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtMemStat.Text ="";
            txtBooksOut.Text = "";
            txtForename.Text = "";
            txtBookId.Text = "";
            txtStatus.Text = "";
            txtSurname.Text = "";
            txtAuthor.Text = "";

            grpBook.Visible = false;
            grpMembers.Visible = false;
            dataGrdMem.Visible = false;
            txtSrhName.Text = "";
            txtSrhBook.Text = "";
            txtSrhName.Focus();
            

        }

        private string loanDate()
        {
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy");

            return currentDate;
        }

        private string dueDate()
        {
            string dueDate = DateTime.Now.AddDays(7).ToString("dd-MMM-yyyy");

            return dueDate;
;
        }

    }
}
