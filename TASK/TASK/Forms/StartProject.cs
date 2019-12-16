using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class StartProject : Form
    {
        public StartProject()
        {
            InitializeComponent();
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void aDDUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Registration r = new Registration();
            r.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
         
                UserLogin u = new UserLogin();
                u.Show();
          
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                AdminLogin a = new AdminLogin();

                a.Show();

           
        }

        private void vendorLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                VendorLogin v = new VendorLogin();
                v.Show();
           
        }
    }
}
