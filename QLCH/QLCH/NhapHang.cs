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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        LoaiSanPham loaisp = new LoaiSanPham();
        SanPham1 sp = new SanPham1();
        MY_DB connect = new MY_DB();
        public void fillGrid(string query)
        {
            SanPham1 sanpham = new SanPham1();
            dataGridViewNhap.ReadOnly = true;
            dataGridViewNhap.RowTemplate.Height = 80;
            dataGridViewNhap.DataSource = sanpham.getSanPham(query);
            dataGridViewNhap.AllowUserToAddRows = false;

        }
        private void cbbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void NhapHang_Click(object sender, EventArgs e)
        {
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(dataGridViewNhap.CurrentRow.Cells[4].Value.ToString());
            string NguoiNhap = Global_Name.GlobalName;
            if (soluong > 0)
            {
                SqlCommand cmd = new SqlCommand("update SanPham set SoLuong=@sl  WHERE MaSP = @id", connect.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value=txtMaSP.Text;
                cmd.Parameters.Add("@sl", SqlDbType.Int).Value = (soluong += int.Parse(txtSoLuongNhap.Text));
                connect.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    if (sp.insertNhapHang(NguoiNhap, txtMaSP.Text, txtTenSP.Text, txtNhaCungCap.Text, int.Parse(txtSoLuongNhap.Text), int.Parse(txtGianhap.Text) * int.Parse(txtSoLuongNhap.Text), dateTimePicker1.Value))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        fillGrid("select * from SanPham");
                    }
                    else MessageBox.Show("Đã Có Lỗi Xảy Ra");
                }
                connect.closeConnection();
            }
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            fillGrid("select * from SanPham");
            dateTimePicker1.Value = DateTime.Now;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridViewNhap_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewNhap.Rows.Count > 0)
            {
                txtMaSP.Text = dataGridViewNhap.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dataGridViewNhap.CurrentRow.Cells[1].Value.ToString();
                txtNhaCungCap.Text = dataGridViewNhap.CurrentRow.Cells[3].Value.ToString();
                txtSlTon.Text = dataGridViewNhap.CurrentRow.Cells[5].Value.ToString();
            }
            fillGrid("select MaSP, TenSP, NCC, LoaiSP, SoLuong, Donvidoluong from SanPham");
        }
    }
}
