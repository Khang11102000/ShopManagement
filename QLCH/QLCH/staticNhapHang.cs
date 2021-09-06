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
    public partial class staticNhapHang : Form
    {
        public staticNhapHang()
        {
            InitializeComponent();
        }

        private void staticNhapHang_Load(object sender, EventArgs e)
        {
            MY_DB con = new MY_DB();
            SqlDataAdapter ad = new SqlDataAdapter("select TenSP, sum(SoLuong) as SoLuong from NhapHang Group by TenSP", con.getConnection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên Sản Phẩm";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng ";
            chart1.Series["Series1"].XValueMember = "TenSP";
            chart1.Series["Series1"].YValueMembers = "SoLuong";
        }
    }
}
