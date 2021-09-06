using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class SanPhamDaMua : Form
    {
        public SanPhamDaMua()
        {
            InitializeComponent();
        }
        SanPham1 sp = new SanPham1();
        public void fillGrid(string query)
        {
            
            

        }

        private void SanPhamDaMua_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sp.getSanPham("select * from BanHang where TenKH LIKE N'%" + Global_Name.GlobalName + "%'");
        }
    }
}
