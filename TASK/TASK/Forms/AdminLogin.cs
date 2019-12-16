using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string str6 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(str6);
            SqlCommand cmd;
            string sql6 = "insert into  login(Email_ID,Password)values('" + txtEmailLog.Text.ToString() + "','" + txtPassword.Text.ToString() + "')";


            try
            {
                con.Open();


                cmd = new SqlCommand(sql6, con);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                con.Close();
                MessageBox.Show("login Successfully !!!");


                       Admin a = new Admin();

                        a.Show();

                 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {

                    con.Close();
                }

            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void txtEmailLog_Leave(object sender, EventArgs e)
        {

            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtEmailLog.Text, pattern))
            {

                // MessageBox.Show("Valid Email address ");
            }
            else
            {

                MessageBox.Show("Invalid Email Address ");
                return;
            }
        }
    }
}
