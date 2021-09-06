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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHDataSet2.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.QLCHDataSet2.SanPham);
            // TODO: This line of code loads data into the 'QLCHDataSet1.BanHang' table. You can move, or remove it, as needed.
            this.BanHangTableAdapter.Fill(this.QLCHDataSet1.BanHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
