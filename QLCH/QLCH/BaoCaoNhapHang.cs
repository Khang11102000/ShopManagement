using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class BaoCaoNhapHang : Form
    {
        public BaoCaoNhapHang()
        {
            InitializeComponent();
        }
        SanPham1 sp = new SanPham1();
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            reportNhapHang rp = new reportNhapHang();
            rp.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query;
            SqlCommand cmd;
            string d1 = dpTuNgay.Value.ToString("yyyy-MM-dd");
            string d2 = dpDenNgay.Value.ToString("yyyy-MM-dd");
            query = "SELECT * FROM Nhaphang WHERE  NgayNhap BETWEEN '" + d1 + "' AND '" + d2 + "'";
            cmd = new SqlCommand(query);
            fillGrid(query);
        }
        public void fillGrid(string query)
        {
            dataGridViewBaoCao.ReadOnly = true; DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewBaoCao.RowTemplate.Height = 80;
            dataGridViewBaoCao.DataSource = sp.getSanPham(query);
            dataGridViewBaoCao.AllowUserToAddRows = false;
            labelTotal.Text = ("Tổng Số Tiền Nhập Hàng: " + TONGTIENHD2().ToString()+" VNĐ");
        }
        public string TONGTIENHD2()
        {
            int rowcount = dataGridViewBaoCao.Rows.Count;
            if (rowcount == 0)
                return "0";
            double tong = 0;
            for (int i = 0; i < rowcount; i++)
            {
                tong += double.Parse(dataGridViewBaoCao.Rows[i].Cells[6].Value.ToString());
            }
            return tong.ToString();
        }
        public string TONGTIENHD()
        {
            int rowcount = dataGridViewBaoCao.Rows.Count - 1;
            if (rowcount == 0)
                return "0";
            double tong = 0;
            for (int i = 0; i < rowcount; i++)
            {
                tong += double.Parse(dataGridViewBaoCao.Rows[i].Cells[6].Value.ToString());
            }
            return tong.ToString();
        }

        private void BaoCaoNhapHang_Load(object sender, EventArgs e)
        {
            dataGridViewBaoCao.DataSource = sp.getSanPham("select * from NhapHang");
            labelTotal.Text = ("Tổng Số Tiền Nhập Hàng: " + TONGTIENHD().ToString());
        }

        private void dataGridViewBaoCao_Click(object sender, EventArgs e)
        {
           BaoCaoNhapHang_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staticNhapHang nhap = new staticNhapHang();
            nhap.ShowDialog();
        }
    }
}
