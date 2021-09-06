using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCH
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        MY_DB connect = new MY_DB();
        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            if(rdbKH.Checked==false & rdbQL.Checked==false)
            {
                MessageBox.Show("Vui Lòng Chọn Quyền Truy Cập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                string user = textBoxDangNhap.Text;
                string pass = textBoxMatKhau.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from DangKy where UserName=@id and PassWord=@pass", connect.getConnection);
                connect.openConnection();
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                adapter.SelectCommand = cmd;
                adapter.Fill(data);
                
                if (data.Rows.Count > 0)
                {
                    if(rdbQL.Checked==true)
                    {
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    DataTable data2 = new DataTable();
                    SqlCommand cmd2 = new SqlCommand("select * from DangKy where UserName=@id and PassWord=@pass", connect.getConnection);
                    connect.openConnection();
                    cmd2.Parameters.Add("@id", SqlDbType.VarChar).Value = user;
                    cmd2.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                    adapter2.SelectCommand = cmd2;
                    adapter2.Fill(data2);
                    Global_Name.SetGlobalName(data2.Rows[0][2].ToString());
                    MainForm mainf = new MainForm();
                        this.Hide();
                        mainf.ShowDialog();
                    }
                    if(rdbKH.Checked==true)
                    {
                        SqlDataAdapter adapter1 = new SqlDataAdapter();
                        DataTable data1 = new DataTable();
                        SqlCommand cmd1 = new SqlCommand("select * from DangKy where UserName=@id and PassWord=@pass", connect.getConnection);
                        connect.openConnection();
                        cmd1.Parameters.Add("@id", SqlDbType.VarChar).Value = user;
                        cmd1.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
                        adapter1.SelectCommand = cmd1;
                        adapter1.Fill(data1);
                        Global_Name.SetGlobalName(data1.Rows[0][2].ToString());
                        Global_Name.SetGlobalUser(data1.Rows[0][0].ToString());
                        Global_Name.SetGlobalPass(data1.Rows[0][1].ToString());
                        Global_Name.SetGlobalSDT(data1.Rows[0][4].ToString());
                    DoiMatKhau dmk = new DoiMatKhau();
                        this.Hide();
                        dmk.ShowDialog();
                    }
                    
                }
                else MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu !");
                connect.closeConnection();
            

        }

        private void buttonCannel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_DangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy reg = new DangKy();
            reg.ShowDialog();
        }
    }
}
