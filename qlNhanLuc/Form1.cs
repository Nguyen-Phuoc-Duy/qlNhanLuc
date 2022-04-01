using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlNhanLuc
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            Nhanvien fNhanvien = new Nhanvien();
            //this.Hide();
            fNhanvien.Show(); 
            Visible = false;

        }

        private void btnPhongban_Click(object sender, EventArgs e)
        {
            Phongban fPhongban = new Phongban();
            //this.Hide();
            fPhongban.Show(); 
            Visible = false;
            //toi la duy
        }
    }
}
