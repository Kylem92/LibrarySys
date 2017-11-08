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
    public partial class frmLateNotice : Form
    {
        public frmLateNotice()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void frmLateNotice_Load(object sender, EventArgs e)
        {
            //Define the connection
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Rentals WHERE Return_Date > Due_Date ORDER BY ASC";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Records Found");
                }
                else
                {
                    da.Fill(ds, "ss");
                    grdOverdue.DataSource = ds.Tables["ss"];
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            readData();
        }

        private void readData()
        {
            txtRentalId.Text = grdOverdue.Rows[grdOverdue.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtMemId.Text = grdOverdue.Rows[grdOverdue.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtBookId.Text = grdOverdue.Rows[grdOverdue.CurrentCell.RowIndex].Cells[2].Value.ToString();

        }

        private void grdOverdue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdOverdue.Rows[e.RowIndex];
                txtRentalId.Text = row.Cells["RentalId"].Value.ToString();
                txtMemId.Text = row.Cells["MemId"].Value.ToString();
                txtBookId.Text = row.Cells["BookId"].Value.ToString();


            }

            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Members WHERE MemId = '" + txtMemId.Text + "'";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                OracleDataReader read = (null);



                read = cmd.ExecuteReader();

                if (read.HasRows)
                {

                    txtForename.Text = (read["Forename"].ToString());
                    txtSurname.Text = (read["Surname"].ToString());
                    txtAdd1.Text = (read["Address1"].ToString());
                    txtAdd2.Text = (read["Address2"].ToString());
                    txtAdd3.Text = (read["Address3"].ToString());
                    txtEmail.Text = (read["Email"].ToString());
                }
                else
                {
                    MessageBox.Show("Could not find details");
                }


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find member");
                MessageBox.Show(ex.Message);
            }

            string orcldb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcldb);
                String strSQL = "SELECT * FROM Rentals WHERE RentalId = '" + txtRentalId.Text + "'";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                OracleDataReader read = (null);

                read = cmd.ExecuteReader();

                if (read.HasRows)
                {
                    txtDate.Text = (read["Due_Date"].ToString());
                    txtCurrent.Text = currentDate();
                }
                else
                {
                    MessageBox.Show("Could not find rental record");
                }
               



                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find rental record");
                MessageBox.Show(ex.Message);
            }

        }

        private string currentDate()
        {
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy");

            return currentDate;
        }
    }   
}
