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
    public partial class LoaiSP : Form
    {
        public LoaiSP()
        {
            InitializeComponent();
        }

        private void LoaiSP_Load(object sender, EventArgs e)
        {
            LoaiSanPham loaisp = new LoaiSanPham();

            fillGrid("SELECT * FROM LoaiSP");
        }
        public void fillGrid(string query)
        {
            LoaiSanPham loaisp = new LoaiSanPham();
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = loaisp.getLoaiSP(query);
            dataGridView1.AllowUserToAddRows = false;
            labelSP.Text = ("Total " + dataGridView1.Rows.Count);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_MaLoaiSP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_LoaiSP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        public bool verif()
        {
            if ((txt_LoaiSP.Text.Trim() == ""))
            
                {
                    return false;
                }
            else
            {
                    return true;
                
            }
           
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaisp = new LoaiSanPham();
            
            string masp =  txt_MaLoaiSP.Text;
            string tensp = txt_LoaiSP.Text;
            if (loaisp.checkMaSP(masp))
            {
                if (verif())
                {
                    if (loaisp.insertLoaiSP(masp, tensp))
                    {
                        MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
          else
            {
                MessageBox.Show("Mã Sản Phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fillGrid("SELECT * FROM LoaiSP");
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {                   
            if (verif())
            {
                try
                {
                    LoaiSanPham loaisp = new LoaiSanPham();
                    string masp = txt_MaLoaiSP.Text;
                    string tensp = txt_LoaiSP.Text;

                    if ((loaisp.updateLoaiSP(masp, tensp)))
                    {
                        MessageBox.Show("Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Dữ Liệu Trống", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            fillGrid("SELECT * FROM LoaiSP");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            LoaiSanPham loaisp = new LoaiSanPham();

            try
            {
                string masp = txt_MaLoaiSP.Text;

                if ((MessageBox.Show("Bạn Có Muốn Xóa Sản Phẩm Không!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (loaisp.deleteLoaiSP(masp))
                    {
                        MessageBox.Show("Xóa Thành Công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaLoaiSP.Text = "";
                        txt_LoaiSP.Text = "";
                        

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
            fillGrid("SELECT * FROM LoaiSP");
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LoaiSP where CONCAT(TenSP,MaSP) LIKE N'%"+ txt_timnhanh.Text +"%'";
            fillGrid(query);
        }
    }
}
