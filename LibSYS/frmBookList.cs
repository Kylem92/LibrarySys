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
    public partial class frmBookList : Form
    {
        public frmBookList()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void frmBookList_Load(object sender, EventArgs e)
        {
            LoadBooks("BookID");
        }   
 
        private void LoadBooks(String sortOrder)
        {
            //Define the connection
            string orcdb = "Data Source=Oracle;User Id=t00174978;Password=n58tqrss;";
            try
            {
                //create an instance of an connection
                OracleConnection conn = new OracleConnection(orcdb);
                String strSQL = "SELECT * FROM Books ORDER BY " + sortOrder;

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                cmd.CommandType = CommandType.Text;

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                grdBook.DataSource = ds.Tables["ss"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void optTitle_Click(object sender, EventArgs e)
        {
            LoadBooks("Title");
        }

        private void optAuthor_Click(object sender, EventArgs e)
        {
            LoadBooks("Author");
        }

        private void optBookID_Click(object sender, EventArgs e)
        {
            LoadBooks("BookId");
        }

        private void grdBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
