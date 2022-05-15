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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f = new Login();
            f.Show();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNV f = new QLNV();
            this.Hide();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CalamViec f = new CalamViec();
            this.Hide();
            f.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            this.Hide();
;            f.Show();
        }



        private void ádawdaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NHACC f = new NHACC();
            this.Hide();
            f.Show();
        }

        private void billNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillNhapHang f = new BillNhapHang();
            this.Hide();
            f.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
