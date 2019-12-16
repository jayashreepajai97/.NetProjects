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
    public partial class vendors : Form
    {
      
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbl;

        public object Product_Name { get; private set; }
        public object Product_Type { get; private set; }
        public vendors()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Visible = !dataGridView2.Visible)
            {
                try
                {

                    string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    SqlConnection con = new SqlConnection(str4);


                    con.Open();
                    adap = new SqlDataAdapter("select * from Tbl_Product;", con);
                    ds = new System.Data.DataSet();
                    adap.Fill(ds, "Tbl_Product");
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
            if (txtName.Text != "" || txtPP.Text != "")
            {

                try
                {


                   

                    con.Open();
                    string sql3 = "insert into Tbl_Product(Product_Name,Product_Type,Product_Release_Date,Product_Price)values('" + txtName.Text.ToString() + "','" + prod_com.Text.ToString() + "',  '" + dateTimePicker1.Text.ToString() + "', '" + txtPP.Text.ToString() + "')";


                    SqlCommand cmd;

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
            }
            else
            {
                MessageBox.Show("Please Fill the Record to Submit Values");

            }





        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbl = new SqlCommandBuilder(adap);
                adap.Update(ds, "Tbl_Product");
                MessageBox.Show("Information Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }

        }

        private void txtPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void vendors_Load(object sender, EventArgs e)
        {
            prod_com.SelectedIndex = 0;
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
