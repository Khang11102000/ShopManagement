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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        //BanHang bh = new BanHang();
        SanPham1 sp = new SanPham1();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            fillGrid("select UserName,PassWord,NameOfUser , DateOfBirth,Phone,Address,Sex from DangKy");
        }
        public void fillGrid(string query)
        {
            dataGridViewKhachHang.ReadOnly = true;
            dataGridViewKhachHang.RowTemplate.Height = 80;
            dataGridViewKhachHang.DataSource = sp.getSanPham(query);
            dataGridViewKhachHang.AllowUserToAddRows = false;
        }

        private void dataGridViewKhachHang_Click(object sender, EventArgs e)
        {
            if (dataGridViewKhachHang.Rows.Count > 0)
            {
                txtTDN.Text= dataGridViewKhachHang.CurrentRow.Cells[0].Value.ToString();
                txt_tenKH.Text = dataGridViewKhachHang.CurrentRow.Cells[2].Value.ToString();
                txt_SDT.Text = dataGridViewKhachHang.CurrentRow.Cells[4].Value.ToString();
                txt_tongtien.Text = dataGridViewKhachHang.CurrentRow.Cells[5].Value.ToString();            
            }          
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT UserName,PassWord,NameOfUser , DateOfBirth,Phone,Address,Sex FROM DangKy where NameOfUser LIKE N'%" + txtSearch.Text + "%'";
            fillGrid(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();

            try
            {
                string TDN = txtTDN.Text;

                if ((MessageBox.Show("Bạn Có Muốn Xóa Sản Phẩm Không!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (dk.deleteKhachHang(TDN))
                    {
                        MessageBox.Show("Xóa Thành Công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTDN.Text = "";
                        txt_tenKH.Text = "";
                        txt_SDT.Text = "";
                        txt_tongtien.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Chọn Sản Phẩm", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid("select UserName,PassWord,NameOfUser , DateOfBirth,Phone,Address,Sex from DangKy");
        }
    }
}
