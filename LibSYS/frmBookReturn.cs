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
    public partial class frmBookReturn : Form
    {
        
        public frmBookReturn()
        {
            InitializeComponent();
        }

       

        private void btnSrhMem_Click(object sender, EventArgs e)
        {
            
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Rentals WHERE RentalId LIKE '" + txtSrhRent.Text + "%'";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                dataGrdRent.DataSource = ds.Tables["ss"];
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Records Found");
                }
                else
                {
                    readRentData();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            grpRentals.Visible = true;
            dataGrdRent.Visible = true;

            
        }

        private void readRentData()
        {

            txtRentalId.Text = dataGrdRent.Rows[dataGrdRent.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtMemId.Text = dataGrdRent.Rows[dataGrdRent.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtBookId.Text = dataGrdRent.Rows[dataGrdRent.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtLoan.Text = dataGrdRent.Rows[dataGrdRent.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtDue.Text = dataGrdRent.Rows[dataGrdRent.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtReturn.Text = dataGrdRent.Rows[dataGrdRent.CurrentCell.RowIndex].Cells[5].Value.ToString();

        }

      
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Return();
            UpdateB();            
        }

        private void dataGrdRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private String returnDate()
        {
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy");

            return currentDate;
        }

        private void frmBookReturn_Load(object sender, EventArgs e)
        {
            txtReturn.Text = returnDate(); 

        }
        private void Return() 
        {
            try
            {
                //define connection string
                String orcdb = "Data Source=Oracle;User Id = t00174978;Password = n58tqrss;";

                //connect to database
                OracleConnection conn = new OracleConnection(orcdb);
                conn.Open();

                OracleCommand cmd = conn.CreateCommand();
                //define SQL query (update)
                String strSQL = "UPDATE Rentals SET Return_Date = '" + txtReturn.Text  +
                    "' WHERE RentalId = '" + txtRentalId.Text + "'";  


                cmd.CommandText = strSQL;

                //execute SQL query
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Update Rentals");
                MessageBox.Show(ex.Message);
            }
            
        }
        private void UpdateB() 
        {
            try
            {
                //update member details in Member file
                string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
                OracleConnection conn = new OracleConnection(orcdb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //Define SQL Query (UPDATE)
                string strSQL = "UPDATE Members SET NoOfBooks = 0 WHERE MemId = '" + txtMemId.Text + "'";

                cmd.CommandText = strSQL;

                //Execute SQL Query
                cmd.ExecuteNonQuery();

                //Close Database
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                MessageBox.Show(ex.Message);
            }

            try
            {
                //update book details in book file
                string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
                OracleConnection conn = new OracleConnection(orcdb);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();

                //Define SQL Query (UPDATE)
                string strSQL = "UPDATE Books SET Status = 'A' WHERE BookId = '" + txtBookId.Text + "'";

                cmd.CommandText = strSQL;

                //Execute SQL Query
                cmd.ExecuteNonQuery();

                //Close Database
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1");
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("A book has been returned by member" + txtMemId.Text, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpRentals.Visible = false;
            dataGrdRent.Visible = false;
            txtRentalId.Text = "";
            txtMemId.Text = "";
            txtBookId.Text = "";
            txtLoan.Text = "";
            txtDue.Text ="";
            txtReturn.Text = "";
            txtSrhRent.Text = "";
            txtSrhRent.Focus();


        }

        private void dataGrdRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpRentals.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGrdRent.Rows[e.RowIndex];
                txtRentalId.Text = row.Cells["RentalId"].Value.ToString();
                txtMemId.Text = row.Cells["MemId"].Value.ToString();
                txtBookId.Text = row.Cells["BookId"].Value.ToString();
                txtLoan.Text = row.Cells["Loan_Date"].Value.ToString();
                txtDue.Text = row.Cells["Due_Date"].Value.ToString();
                txtReturn.Text = returnDate();


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Close();

        }
    }
}
