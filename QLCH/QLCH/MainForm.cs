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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customize();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MY_DB conncect = new MY_DB();
            conncect.closeConnection();

            Application.Exit();
        }
        
        //Xử lí giao diện
        ///Đóng Button
        private void customize()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            //...
        }
        private void giaodien()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;

        }
        private void showbtn(Panel menu)
        {
            if (menu.Visible == false)
            {
                giaodien();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }
        ///Hàm Hiển thị form
        private void Hienthiform<MiForm>() where MiForm : Form, new()
        {
            Form newform;
            newform = PnMain.Controls.OfType<MiForm>().FirstOrDefault();
            if (newform == null)
            {
                newform = new MiForm();
                newform.TopLevel = false;
                newform.FormBorderStyle = FormBorderStyle.None;
                newform.Dock = DockStyle.Fill;
                PnMain.Controls.Add(newform);
                PnMain.Tag = newform;
                newform.Show();
                newform.BringToFront();
            }
            else
            {
                newform.BringToFront();
            }
        }
        ///Xử lí Button
        private void btnQuanLi_Click(object sender, EventArgs e)
        {
            showbtn(panel1);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showbtn(panel2);
        }
        //Xử lí Hiển thị
        private void btnQLSanPham_Click_1(object sender, EventArgs e)
        {
            Hienthiform<SanPham>();
        }
        private void btnQLLoaiSanPham_Click_1(object sender, EventArgs e)
        {
            Hienthiform<LoaiSP>();
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
           Hienthiform<BanHang>();
        }
        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            Hienthiform<NhapHang>();
        }
        private void btnQLKhachHang_Click_1(object sender, EventArgs e)
        {
            Hienthiform<KhachHang>();
        }
        private void btnTKDTBH_Click_1(object sender, EventArgs e)
        {
            Hienthiform<BaoCaoBanHang>();
        }
        private void btnTKCPMH_Click_1(object sender, EventArgs e)
        {
            Hienthiform<BaoCaoNhapHang>();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            Hienthiform<NCC>();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap DN = new DangNhap();
            DN.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label2.Text = DateTime.Now.ToString("dd/MM");
            label3.Text = DateTime.Now.ToString("dddd");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            Hienthiform<DoiMatKhau>();
        }
    }
}
