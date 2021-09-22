using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPhongKham.Views
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void benhnhan_Click(object sender, EventArgs e)
        {
            thongtinbenhnhan f = new Views.thongtinbenhnhan();
            f.Show();
        }

        private void phieukham_Click(object sender, EventArgs e)
        {
            phieukham f = new Views.phieukham();
            f.Show();
        }

        private void thuoc_Click(object sender, EventArgs e)
        {
            thuoc f = new Views.thuoc();
            f.Show();
        }

        private void toathuoc_Click(object sender, EventArgs e)
        {
            laptoathuoc f = new Views.laptoathuoc();
            f.Show();
        }

        private void hoadon_Click(object sender, EventArgs e)
        {
            HoaDon f = new Views.HoaDon();
            f.Show();
        }
    }
}
