using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task;

namespace VMSUnitTests
{
    [TestClass]
    public class AdminTest
    {
        [TestMethod]
        public void ShowRecord()
        {
            var a = new Admin();
            //  Assert.AreEqual(true,true);
            string s = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ConnectionDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(s);

            SqlCommand cmd;
            SqlDataReader rd;
            string sql = "select * from ProductDetailsAdmin";
            try
            {
                con.Open();
                MessageBox.Show("Connection is active");

                cmd = new SqlCommand(sql, con);
                rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    MessageBox.Show(rd.GetValue(1) + "    " + rd.GetValue(2));
                }

                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
      
    }
}
