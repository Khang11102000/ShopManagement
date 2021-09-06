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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        SanPham1 sanpham = new SanPham1();
        nhacungcap ncc = new nhacungcap();
        LoaiSanPham loaisp = new LoaiSanPham();


        private void SanPham_Load(object sender, EventArgs e)
        {
            fillGrid("select * from SanPham");
            cbbmasp.DataSource = loaisp.getLoaiSP("select * from LoaiSP");
            cbbmasp.DisplayMember = "MaSP";
            cbb_NCC.DataSource = ncc.getNCC("select * from NhaCC");
            cbb_NCC.DisplayMember = "NCC";
            DanhDauSoLuong();
    
            this.reportViewer1.RefreshReport();
        }
        public void fillGrid(string query)
        {
            SanPham1 sanpham = new SanPham1();
            dataGridViewSanPham.ReadOnly = true;
            dataGridViewSanPham.RowTemplate.Height = 80;
            dataGridViewSanPham.DataSource =sanpham.getSanPham(query);
            dataGridViewSanPham.AllowUserToAddRows = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham1 SP = new SanPham1();
                string masp = cbbmasp.Text;
                string loaisp = txtLoaiSanPham.Text;
                string mancc = cbb_NCC.Text;
                int giatien = Convert.ToInt32(txt_giatien.Text);
                int soluong = int.Parse(num_soluong.Value.ToString());
                MemoryStream picture = new MemoryStream();
                pictureBox1.Image.Save(picture, pictureBox1.Image.RawFormat);
                string tensp = txt_tenSP.Text;
                string donvidoluong = cbb_donvidoluong.Text;


                if (SP.SanphamScpreExist(masp))
                {
                    
                    if (SP.inserSanPham(masp, tensp, giatien, mancc, loaisp, soluong, donvidoluong,picture))
                    {
                        MessageBox.Show("Thêm Thành Công", "Them San Pham", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra", "Them San Pham", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mã Sản Phẩm Đã Tồn Tại", "Them San Pham", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
            fillGrid("SELECT * FROM SanPham");

        }

        private void dataGridViewSanPham_Click(object sender, EventArgs e)
        {
            if (dataGridViewSanPham.Rows.Count > 0)
            {
                txt_tenSP.Text = dataGridViewSanPham.CurrentRow.Cells[1].Value.ToString();
                txt_giatien.Text = dataGridViewSanPham.CurrentRow.Cells[2].Value.ToString();
                num_soluong.Value = int.Parse(dataGridViewSanPham.CurrentRow.Cells[5].Value.ToString());
           
                cbb_NCC.Text = dataGridViewSanPham.CurrentRow.Cells[3].Value.ToString();
                cbbmasp.Text = dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString();
                cbb_donvidoluong.Text = dataGridViewSanPham.CurrentRow.Cells[6].Value.ToString();
                byte[] pic;
                pic = (byte[])dataGridViewSanPham.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }
            fillGrid("SELECT * FROM SanPham");
            DanhDauSoLuong();
          
        }

        private void cbbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = loaisp.getLoaiSPByMaSP(cbbmasp.Text);
            if (dt.Rows.Count>0)
            {
                DataRow row = dt.Rows[0];
                txtLoaiSanPham.Text = row["TenSP"].ToString();
            }           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sanpham.deleteSSP(cbbmasp.Text))
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else MessageBox.Show("Đã Có Lỗi Xảy Ra");
            fillGrid("SELECT * FROM SanPham");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MemoryStream picture = new MemoryStream();
            pictureBox1.Image.Save(picture, pictureBox1.Image.RawFormat);
            string tensp = txt_tenSP.Text;
            if (sanpham.EditSP(cbbmasp.Text, txt_tenSP.Text, txt_giatien.Text, num_soluong.Text, cbb_NCC.Text, picture))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra");
            }
            fillGrid("SELECT * FROM SanPham");
        }

        public void DanhDauSoLuong()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.White;
            style.ForeColor = Color.Red;
            int rc = dataGridViewSanPham.RowCount;
            for (int i = 0; i < rc; i++)
            {
                int sluong = int.Parse(dataGridViewSanPham.Rows[i].Cells[5].Value.ToString());
                if (sluong < 5)
                {
                    dataGridViewSanPham.Rows[i].DefaultCellStyle = style;
                    richTbTrinhTrangDh.Visible = true;
                }
            }
        }



        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SanPham where CONCAT(TenSP,LoaiSP) LIKE N'%" + txt_TimTheoTen.Text + "%'";
            fillGrid(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
