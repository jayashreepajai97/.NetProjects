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
    public partial class Registration : Form
    {



        public Registration()
        {
            InitializeComponent();

        }


        private void btnReg_Click(object sender, EventArgs e)
        {
          


            try
            {
                string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(str4);
                SqlCommand cmd;

                SqlDataAdapter da = new SqlDataAdapter("select Email_Id from Tbl_Registration where Email_Id='" + txtEmail.Text.ToString() + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string sql3 = "insert into Tbl_Registration(Name,Password,Email_ID,Mob_No,Designation)values('" + txtName.Text.ToString() + "','" + txtPassword.Text.ToString() + "',  '" + txtEmail.Text.ToString() + "', '" + txtMob.Text.ToString() + "','" + com.Text.ToString() + "')";


                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("email already exits");

                }
                else
                {

                    con.Open();

                    cmd = new SqlCommand(sql3, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Register Successfully");
                   

                    if (com.Text.ToString() == "Admin")
                    {
                        AdminLogin a = new AdminLogin();

                        a.Show();

                    }
                    else if (com.Text.ToString() == "Vendors")
                    {
                        VendorLogin v = new VendorLogin();
                        v.Show();
                    }
                    else if (com.Text.ToString() == "User")
                    {
                        UserLogin u = new UserLogin();
                        u.Show();
                    }

                    //  loginportal l = new loginportal();
                    // l.Show();
                }




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
             
            

           


        }

            private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
              
             // MessageBox.Show("Valid Email address ");
            }
            else
            {
                
                MessageBox.Show("Not a valid Email address[Used @symbol] ");
                return;
            }



        }

        private void txtMob_TextChanged(object sender, EventArgs e)
        {
            
           // if txtMob.Text.Length = 11 then
                //    MessageBox.Show("OK");
            


        }

        private void txtMob_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8  && ch != 46)
            {
                e.Handled = true;
            }

        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {

           
           

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            
           
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch)&&!char.IsControl(ch))
            {
                e.Handled = true;
            }

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Enter Your Name")
            {
                txtName.Text = " ";
                txtName.ForeColor = Color.Black;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            com.SelectedIndex = 0;
        }
    }
}


