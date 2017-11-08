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
    public partial class frmMemList : Form
    {
        public frmMemList()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMemList_Load(object sender, EventArgs e)
        {
            LoadMembers("MemId");
        }

        private void LoadMembers(String sortOrder)
        {
            //Define the connection
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Members ORDER BY " + sortOrder;

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                GrdMemList.DataSource = ds.Tables["ss"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void optMemId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optMemId_Click(object sender, EventArgs e)
        {
            LoadMembers("MemId");
        }

        private void optSurname_Click(object sender, EventArgs e)
        {
            LoadMembers("Surname");
        }

        private void optForename_Click(object sender, EventArgs e)
        {
            LoadMembers("Forename");
        }

        private void optDate_Click(object sender, EventArgs e)
        {
            LoadMembers("RegDate");
        }
    }
}
