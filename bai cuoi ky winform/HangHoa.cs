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
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtHangHoaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ThemLoaiHang f = new ThemLoaiHang();
            f.ShowDialog();
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            panel_form.Enabled = true;
            this.Enabled = true;


            DisablePageControls(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void DisablePageControls(bool status)

        {

            foreach (Control c in this.Controls)

            {

                foreach (Control ctrl in c.Controls)

                {

                    if (ctrl is TextBox)

                        ((TextBox)ctrl).Enabled = status;

                    else if (ctrl is Button)

                        ((Button)ctrl).Enabled = status;

                    else if (ctrl is RadioButton)

                        ((RadioButton)ctrl).Enabled = status;

                    

                }

            }

        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
