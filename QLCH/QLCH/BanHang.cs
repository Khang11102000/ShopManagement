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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            cbb_masp.DataSource = loaisp.getLoaiSP("select * from LoaiSP");
            cbb_masp.DisplayMember = "MaSP";
            fillGrid("select * from SanPham");
            dateTimePicker1.Value = DateTime.Now;
        }
        LoaiSanPham loaisp = new LoaiSanPham();
        SanPham1 sp = new SanPham1();
        MY_DB connect = new MY_DB();
        public void fillGrid(string query)
        {
            SanPham1 sanpham = new SanPham1();
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = sanpham.getSanPham(query);
            dataGridView1.AllowUserToAddRows = false;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                cbb_masp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_tensp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_dongia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_loaisp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_soluongcon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            fillGrid("select * from SanPham");
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            string NguoiMua = Global_Name.GlobalName;
            string sdt = Global_Name.GlobalSDT;
            if (soluong >= int.Parse(txtsoluongban.Text))
            {
                if (soluong > 0)
                {
                    SqlCommand cmd = new SqlCommand("update SanPham set SoLuong=@sl WHERE MaSP = @id", connect.getConnection);
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = cbb_masp.Text;
                    cmd.Parameters.Add("@sl", SqlDbType.Int).Value = (soluong -= int.Parse(txtsoluongban.Text));
                    connect.openConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        if (sp.insertHD(NguoiMua, sdt, cbb_masp.Text, txt_tensp.Text, txt_loaisp.Text, int.Parse(txtsoluongban.Text), int.Parse(txt_dongia.Text) * int.Parse(txtsoluongban.Text), dateTimePicker1.Value))
                        {
                            MessageBox.Show("Thanh Toán Thành Công");
                        }
                        else MessageBox.Show("Đã Có Lỗi Xảy Ra");
                    }
                    //      else MessageBox.Show("Đã Có Lỗi Xảy Ra");
                    connect.closeConnection();
                }
            }
            else MessageBox.Show("Số Lượng Không Đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connect.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SanPham where CONCAT(TenSP,LoaiSP) LIKE N'%" + txtSearch.Text + "%'";
            fillGrid(query);
        }
    }
}
