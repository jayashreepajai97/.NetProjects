using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Admin : Form
    {
       


        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbl;
        public Admin()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
                                                                                                  
            string str5 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str5);

            if (txtName.Text != "" || txtPP.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd;
                    string sql5 = "insert into ProductDetailsAdmin(Product_Name,Product_Type,Product_Release_Date,Product_Price,Pieces_Sold,Total_Price,Schedule_Current_Date,Schedule_CheckIn,Schedule_CheckOut)values( '" + txtName.Text.ToString() + "','" + prod_com.Text.ToString() + "',  '" + dateTimePicker1.Text.ToString() + "', '" + txtPP.Text.ToString() + "','" + txtPriceSold.Text.ToString() + "','" + txtPrice.Text.ToString() + "','" + dateTimePicker2.Text.ToString() + "','" + dateTimePicker3.Text.ToString() + "','" + dateTimePicker4.Text.ToString() + "')";


                    cmd = new SqlCommand(sql5, con);

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

        private void btnShow_Click(object sender, EventArgs e)
        {

            if (dataGridView3.Visible = !dataGridView3.Visible)
            {
                try
                {

                    string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    SqlConnection con = new SqlConnection(str4);


                    con.Open();
                    adap = new SqlDataAdapter("select * from ProductDetailsAdmin;", con);
                    ds = new System.Data.DataSet();
                    adap.Fill(ds, "ProductDetailsAdmin");
                    dataGridView3.DataSource = ds.Tables[0];



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
          

            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

            try
            {
                cmdbl = new SqlCommandBuilder(adap);
                adap.Update(ds, "ProductDetailsAdmin");
                MessageBox.Show("Information Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrice.Text = (float.Parse(txtPP.Text) * float.Parse(txtPriceSold.Text)).ToString();
            }
            catch
            {

            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
