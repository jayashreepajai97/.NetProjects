using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class extra_code
    {



        /* 
         * 
         * first way
         * 
         private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
         SqlConnection con = new SqlConnection(str4);
         if (e.ColumnIndex == 5)
         {

             MessageBox.Show("Update successsfully");

             DataTable table = new DataTable();


           //  if (txtName.Text != "  " && prod_com.Text != "   " && dateTimePicker1.Text != "   " && txtPP.Text != "   ")
          //   {

                try
                 {
                     con.Open();
                     SqlCommand cmd = new SqlCommand("update Tbl_Product set Product_Name=@Product_Name,Product_Type=@Product_Type,Product_Release_Date=@Product_Release_Date,Product_Price=@Product_Price where Product_Id=@Product_Id", con);

                 //  cmd.Parameters.AddWithValue("@Product_Name", txtName.Text);
                 //  cmd.Parameters.AddWithValue("@Product_Type", prod_com.Text);
                 //  cmd.Parameters.AddWithValue("@Product_Release_Date", dateTimePicker1.Text);
                 //  cmd.Parameters.AddWithValue("@Product_Price", txtPP.Text);


                 DataGridViewRow newDataRow = dataGridView2.Rows[indexRow];
                 newDataRow.Cells[0].Value = txtName.Text;
                 newDataRow.Cells[1].Value = prod_com.Text;
                 newDataRow.Cells[2].Value = dateTimePicker1.Text;
                 newDataRow.Cells[3].Value = txtPP.Text;


                 cmd.ExecuteNonQuery();
                     MessageBox.Show("Record Updated Successfully");
                     con.Close();
                     DisplayData();
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
                 MessageBox.Show("Please Select Record to Update");
             }

         }
         
           void DisplayData()
        {
            string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str4);
            SqlCommand cmd = new SqlCommand("select * from Tbl_Product;", con);
            try
            {
                con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Tbl_Product", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
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
         
         
         
         second way

        
                    int columnIndex = 5;
                     foreach (DataGridViewRow row in dataGridView2.Rows)
                      {
                                row.Cells[columnIndex].ToolTipText = "New Value";
                      }
                  
         
         
         
         
         
         
         third method

         
          private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
       

        DataGridViewRow row = new DataGridViewRow();

        row = dataGridView2.Rows[selectedRowIndex];

      
        string Product_Name = Interaction.InputBox("Enter The New Product_Name", "Update Data", row.Cells[1].Value.ToString(), -1, -1);
        string Product_Type = Interaction.InputBox("Enter The New Product_Type", "Update Data", row.Cells[2].Value.ToString(), -1, -1);
       // string Product_Release_Date = Interaction.InputBox("Enter The New Product_Release_Date", "Update Data", row.Cells[3].Value.ToString(), -1, -1);
        string Product_Price = Interaction.InputBox("Enter The New  Product_Price", "Update Data", row.Cells[4].Value.ToString(), -1, -1);


            row.Cells[1].Value = Product_Name;
             row.Cells[2].Value = Product_Type;
          //  row.Cells[3].Value = Product_Release_Date;
            row.Cells[4].Value = Product_Price;



        }

         private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRowIndex = e.RowIndex;
            try
            {
                int indexRow;
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = dataGridView2.Rows[indexRow];

            txtName.Text = row.Cells[0].Value.ToString();
            prod_com.Text = row.Cells[1].Value.ToString();
         //   dateTimePicker1.Text = row.Cells[2].Value.ToString();
            txtPP.Text = row.Cells[3].Value.ToString();
             }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

        }



          private void ProductDetails_A_cs_Load(object sender, EventArgs e)
        {
          
            table.Columns.Add("Product_Name", typeof(String));
            table.Columns.Add("Product_Type", typeof(String));
          //  table.Columns.Add("Product_Release_Date", typeof(DateTimePicker));
            table.Columns.Add("Product_Price", typeof(int));


           // table.Rows.Add(1, "AAA", "BBB","2019-1-03",350);
            

            dataGridView2.DataSource = table;
        }




             ProductDetails_A_cs p = new ProductDetails_A_cs();
            p.txtName.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            p.prod_com.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            p.txtPP.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            p.ShowDialog();



















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
using Microsoft.VisualBasic;

namespace Task
{
    public partial class ProductDetails_A_cs : Form
    {
        DataTable table = new DataTable();
       
        

        public object Product_Name { get; private set; }
        public object Product_Type { get; private set; }
      

        public ProductDetails_A_cs()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void txtPP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            string str3 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str3);
            SqlCommand cmd;
            string sql3 = "insert into Tbl_Product(Product_Name,Product_Type,Product_Release_Date,Product_Price)values('" + txtName.Text.ToString() + "','" + prod_com.Text.ToString() + "',  '" + dateTimePicker1.Text.ToString() + "', '" + txtPP.Text.ToString() + "')";

            try
            {
                con.Open();


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

        private void btnShow_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Visible = !dataGridView2.Visible)
            {
                string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(str4);
                SqlCommand cmd = new SqlCommand("select * from Tbl_Product;", con);

                try
                {
                    con.Open();


                    SqlDataAdapter sdr = new SqlDataAdapter
                    {
                        SelectCommand = cmd
                    };
                    DataTable dba = new DataTable();
                    sdr.Fill(dba);
                    BindingSource bs = new BindingSource
                    {
                        DataSource = dba
                    };

                    dataGridView2.DataSource = bs;
                    //  dba.Columns.Add("Update", typeof(string));
                    //  dba.Columns.Add("Delete", typeof(string));


                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn
                    {
                        HeaderText = "  ",
                        Text = "Update",
                        Name = "btnClick",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridView2.Columns.Add(bcol);



                    sdr.Update(dba);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    con.Close();



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
        }

        private void prod_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

       
            
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str4);
            if (e.ColumnIndex == 5)
            {
                try
                {
                    con.Open();
                    ProductDetails_A_cs p = new ProductDetails_A_cs();

                    p.txtName.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    p.prod_com.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    p.txtPP.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
                   // p.ShowDialog();
                   
                    SqlCommand cmd = new SqlCommand("update Tbl_Product set Product_Name=p.txtName.Text,Product_Type=p.prod_com.Text,Product_Price=p.txtPP.Text where this.Product_Id=@Product_Id", con);
                    MessageBox.Show("Update successsfully");

                   
                    

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    con.Close();


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
                MessageBox.Show("Please Select Record to Update");
            }




        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetails_A_cs_Load(object sender, EventArgs e)
        {
          

           
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

    
   private void MetaBtn_Click(object sender, EventArgs e)
        {

          /*  try
            {


                Assembly asm = Assembly.LoadFile(@"C:\Users\Jayashree\source\repos\VMSSupport\VMSSupport\bin\Debug\netcoreapp3.0\VMSSupport.exe");
                Type[] typeinfo = asm.GetTypes();
                foreach (Type typ in typeinfo)
                {
                    if (typ.Name == " User")
                    {
                        MethodInfo[] minfo = typ.GetMethods();
                        foreach (MethodInfo m in minfo)
                        {
                            if (m.Name == "display")
                            {
                                ConstructorInfo[] cinfo = typ.GetConstructors();
                                object obj = cinfo[0].Invoke(null);
                                Object[] values = { " User" };
                                m.Invoke(obj, values);
                            }
                            if (m.Name == "show")
                            {
                                ConstructorInfo[] cinfo = typ.GetConstructors();
                                object obj = cinfo[0].Invoke(null);
                                FieldInfo[] finfo = typ.GetFields();
                                foreach (FieldInfo f in finfo)
                                {
                                    if (f.Name == "strname")
                                    {
                                        f.SetValue(obj, "People");
                                    }
                                }
                                m.Invoke(obj, null);
                            }
                            if (m.Name == "display")
                            {
                                ParameterInfo[] pinfo = m.GetParameters();
                                foreach (ParameterInfo p in pinfo)
                                {
                                    listBox1.Items.Add("parameter Name is" + " " + p.Name);
                                    listBox1.Items.Add("Return type is" + " " + m.ReturnType);
                                }
                                MemberInfo[] meinfo = typ.GetMembers();
                                foreach (MemberInfo mi in meinfo)
                                {
                                    listBox1.Items.Add(mi.Name);
                                    listBox1.Items.Add(mi.MemberType);
                                }
                            }
                        }
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Exception exSub in ex.LoaderExceptions)
                {
                    sb.AppendLine(exSub.Message);
                    FileNotFoundException exFileNotFound = exSub as FileNotFoundException;
                    if (exFileNotFound != null)
                    {
                        if (!string.IsNullOrEmpty(exFileNotFound.FusionLog))
                        {
                            sb.AppendLine("Fusion Log:");
                            sb.AppendLine(exFileNotFound.FusionLog);
                        }
                    }
                    sb.AppendLine();
                }
                string errorMessage = sb.ToString();
                //Display or log the error based on your application.
            }



        //update code
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
    public partial class Form2 : Form
    {
      
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbl;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbl = new SqlCommandBuilder(adap);
                adap.Update(ds, "Tbl_Product");
                MessageBox.Show("information updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {

            string str4 = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(str4);
          

            con.Open();
                adap = new SqlDataAdapter("select * from Tbl_Product;", con);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "Tbl_Product");
                dataGridView3.DataSource=ds.Tables[0]; 

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           



        }
    }
}













       */

    }
}
