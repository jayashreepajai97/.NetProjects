using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class User : Form
    {
      
        SqlDataAdapter adap;
        DataSet ds;
        

        public User()
        {
            InitializeComponent();
        }




        private void btnShow_Click(object sender, EventArgs e)
        {
            if (prod_com1.Text.ToString() == "Telecommunications Services")
            {


                ProductPicturs p = new ProductPicturs();
                p.Show();



            }




        }

        private void Showbtn_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Visible = !dataGridView2.Visible)
            {
                try
                {

                    string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    SqlConnection con = new SqlConnection(str4);


                    con.Open();
                    adap = new SqlDataAdapter("select * from UserData;", con);
                    ds = new System.Data.DataSet();
                    adap.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

            private void btnInsert_Click(object sender, EventArgs e)
        {
            

            string str3 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str3);

            if (txtPP1.Text != "")
            {
                try
                {
                    con.Open();

                    SqlCommand cmd;
                    string sql3 = "insert into UserData(Product_Type,Product_Release_Date,Product_Price)values('" + prod_com1.Text.ToString() + "',  '" + dateTimePicker2.Text.ToString() + "', '" + txtPP1.Text.ToString() + "')";
                    cmd = new SqlCommand(sql3, con);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    con.Close();
                    MessageBox.Show("Record Inserted");


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
            else
            {
                MessageBox.Show("Please Fill the Record to Submit Values");

            }




        }

        private void User_Load(object sender, EventArgs e)
        {
            prod_com1.SelectedIndex = 0;
        }

        private void txtPP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPP1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
















