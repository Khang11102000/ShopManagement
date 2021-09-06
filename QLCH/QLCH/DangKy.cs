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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        MY_DB connect = new MY_DB();
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string name = txt_hoten.Text;
            string user = txt_tendangnhap.Text;
            string pass = txt_matkhau.Text;
            DateTime dob = (DateTime)date_ngaysinh.Value;
            string phone = txt_sdt.Text;
            string diachi = txt_diachi.Text;
            string sex = "";
            if (radio_nam.Checked)
            {
                sex = "Male";
            }
            else sex = "Female";
            string email = txt_email.Text;
            SqlCommand cmd = new SqlCommand("insert into DangKy (NameOfUser, UserName, PassWord, DateOfBirth, Phone, Address, Sex, Email) values (@name, @user, @pass, @dob, @phone, @address, @sex, @email)", connect.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = dob;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = diachi;
            cmd.Parameters.Add("@sex", SqlDbType.NVarChar).Value = sex;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            connect.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connect.closeConnection();
        }
        public bool deleteKhachHang(string KH)
        {
            SqlCommand command = new SqlCommand("DELETE FROM DangKy WHERE UserName=@user", connect.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = KH;
            connect.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                connect.closeConnection();
                return true;
            }
            else
            {
                connect.closeConnection();
                return false;
            }
        }

        private void btn_huydangky_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
