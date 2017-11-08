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
    public partial class frmMemReg : Form
    {
        public frmMemReg()
        {
            InitializeComponent();
        }

        private void txtAdd3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMemReg_Load(object sender, EventArgs e)
        {
            txtRegDate.Text = regDate();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate data
            if(txtForename.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }

            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            if (comGender.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comGender.Focus();
                return;
            }

            if (txtAdd1.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd1.Focus();
                return;
            }

            if (txtAdd2.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd2.Focus();
                return;
            }

            if (txtAdd3.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd3.Focus();
                return;
            }


            //save data in Member file
            try
            {
                //define connection string
                String orcdb = "Data Source=Oracle;User Id = t00174978;Password = n58tqrss;";

                //connect to database
                OracleConnection conn = new OracleConnection(orcdb);

                //define SQL query (update)
                String strSQL = "INSERT INTO Members(MemId, Forename, Surname, Gender, Address1, Address2, Address3, TelNo, email, regDate) VALUES (" + nextId().ToString() + ",'" + txtForename.Text + "','" + txtSurname.Text + "','" +
                    comGender.Text + "','" + txtAdd1.Text + "','" + txtAdd2.Text + "','" + txtAdd3.Text + "','" + txtTel.Text + "','" + txtEmail.Text + "','" + regDate() + "')";

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
            MessageBox.Show("A new member has been added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //reset UI
            txtId.Text = nextId().ToString();
            txtForename.Text = "";
            txtSurname.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtAdd3.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtRegDate.Text = regDate();
        }

        private int nextId()
        {
            int last;
            String orcdb = "Data Source=Oracle;User Id = t00174978;Password = n58tqrss;";
            OracleConnection conn = new OracleConnection(orcdb);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            String strSQL = "SELECT MAX(MemId) FROM Members";
            cmd.CommandText = strSQL;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr[0] == DBNull.Value) last = 1;
            else last = Convert.ToInt32(dr[0]) + 1;
            conn.Close();
            return last;
        }

        private string regDate()
        {
            string currentDate = DateTime.Now.ToString("dd-MMM-yyyy");
           
            return currentDate;
        }

        private void txtRegDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBooksOut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
