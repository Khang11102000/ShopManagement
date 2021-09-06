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
    public partial class NCC : Form
    {
        public NCC()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
        }
        public void fillGrid(string query)
        {
            nhacungcap ncc = new nhacungcap();

            dataGridViewNCC.ReadOnly = true;
            dataGridViewNCC.RowTemplate.Height = 80;
            dataGridViewNCC.DataSource = ncc.getNCC(query);
            dataGridViewNCC.AllowUserToAddRows = false;
            //Dem SV
            labelNCC.Text = ("Total " + dataGridViewNCC.Rows.Count);
        }

        private void NCC_Load(object sender, EventArgs e)
        {
            nhacungcap ncc = new nhacungcap();
            fillGrid("SELECT * FROM NhaCC");
        }

        private void dataGridViewNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewNCC_Click(object sender, EventArgs e)
        {

            txt_mancc.Text =dataGridViewNCC.CurrentRow.Cells[0].Value.ToString();
            txt_tenncc.Text =dataGridViewNCC.CurrentRow.Cells[1].Value.ToString();
        }
        public bool verif()
        {
            if ((txt_tenncc.Text.Trim() == ""))

            {
                return false;
            }
            else
            {
                return true;

            }

        }
        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            nhacungcap ncc = new nhacungcap();

            try
            {
                string masp = txt_mancc.Text;

                if ((MessageBox.Show("Bạn Có Muốn Xóa Nhà Cung Cấp Này Không!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (ncc.deleteLoaiSP(masp))
                    {
                        MessageBox.Show("Xóa Thành Công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_mancc.Text = "";
                        txt_tenncc.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng Chọn Nhà Cung Cấp", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillGrid("SELECT * FROM NhaCC");
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            nhacungcap ncc = new nhacungcap();

            string mancc = txt_mancc.Text;
            string nhacc = txt_tenncc.Text;

            if (verif())
            {
                if (ncc.insertNCC(mancc, nhacc))
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
                MessageBox.Show("Please fill all the empty fields", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fillGrid("SELECT * FROM NhaCC");
        }
    }
}
