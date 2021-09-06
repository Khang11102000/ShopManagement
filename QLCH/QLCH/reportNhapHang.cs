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
    public partial class reportNhapHang : Form
    {
        public reportNhapHang()
        {
            InitializeComponent();
        }

        private void reportNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHDataSet6.NhapHang' table. You can move, or remove it, as needed.
            this.NhapHangTableAdapter.Fill(this.QLCHDataSet5.NhapHang);
            this.reportViewer1.RefreshReport();
        }
    }
}
