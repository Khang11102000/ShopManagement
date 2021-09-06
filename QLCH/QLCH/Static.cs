
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
    public partial class Static : Form
    {
        public Static()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=khang\sqlexpress;Initial Catalog=QLCH;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("select TenSP, sum(DonGia) as DonGia from BanHang Group by TenSP", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên Sản Phẩm";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Đơn Giá (VNĐ)";
            chart1.Series["Đơn Giá"].XValueMember = "TenSP";
            chart1.Series["Đơn Giá"].YValueMembers = "DonGia";

        }

        private void Static_Load(object sender, EventArgs e)
        {
            MY_DB con = new MY_DB();
            SqlDataAdapter ad = new SqlDataAdapter("select TenKH, sum(DonGia) as DonGia from BanHang Group by TenKH", con.getConnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên Khách Hàng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số Tiền Thanh Toán (VNĐ)";
            chart1.Series["Đơn Giá"].XValueMember = "TenKH";
            chart1.Series["Đơn Giá"].YValueMembers = "DonGia";
        }
    }
}
