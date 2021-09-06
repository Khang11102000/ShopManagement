using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
        }
        MY_DB mydb = new MY_DB();
        private void button1_Click(object sender, EventArgs e)
        {
            SanPhamDaMua sp = new SanPhamDaMua();
            sp.ShowDialog();
        }
    }
}
