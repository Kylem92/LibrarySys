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
    public partial class frmOverdue : Form
    {
        public frmOverdue()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void frmOverdue_Load(object sender, EventArgs e)
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

                da.Fill(ds, "ss");

                grdOverdue.DataSource = ds.Tables["ss"];
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No Records Found");
                }
                else
                {
                    readData();
                }    

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
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
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is a problem with the printer", "Error!");
        }
    }
}
