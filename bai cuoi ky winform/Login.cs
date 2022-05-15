using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_cuoi_ky_winform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            var confirmResult = MessageBox.Show("Are you sure to delete?",
                                      "Confirm Delete!!",
                                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
               
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            MENU f = new MENU();
            f.Show();
            
        }

        private void txtbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
