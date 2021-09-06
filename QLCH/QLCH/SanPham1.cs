using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH
{
    class SanPham1
    {
        MY_DB mydb = new MY_DB();
        public bool inserSanPham(string masp,string tensp, int gia,string ncc,string loai,int soluong,string donvidoluong, MemoryStream picture )
        {
            SqlCommand command = new SqlCommand("INSERT INTO SanPham (MaSP, TenSP, Gia, NCC, LoaiSP, SoLuong, Donvidoluong, Picture) VALUES (@masp, @tensp, @gia, @ncc, @loai, @soluong, @donvidoluong,@pic)", mydb.getConnection);
            command.Parameters.Add("@masp", SqlDbType.VarChar).Value = masp;
            command.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = tensp;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@ncc", SqlDbType.NVarChar).Value =ncc;
            command.Parameters.Add("@loai", SqlDbType.NVarChar).Value = loai;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@donvidoluong", SqlDbType.NVarChar).Value = donvidoluong;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getSanPham(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool SanphamScpreExist(string masp)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SanPham WHERE MaSP=@sid", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = masp;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
        public bool deleteSSP(string id)
        {
            SqlCommand cmd = new SqlCommand("delete from SanPham where MaSP = @masp", mydb.getConnection);
            cmd.Parameters.Add("@masp", SqlDbType.VarChar).Value = id;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool EditSP(string id, string ten, string giatien, string soluong, string nhacungcap, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("update SanPham set TenSP=@ten, Gia=@gia, NCC=@ncc, SoLuong=@soluong, Picture=@pic WHERE MaSP=@id ", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("@gia", SqlDbType.Int).Value = giatien;
            cmd.Parameters.Add("@ncc", SqlDbType.NVarChar).Value = nhacungcap;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool insertHD( string tenkh, string sdt, string masp, string tensp, string loaisp, int soluong, int dongia, DateTime ngaylap)
        {
            SqlCommand command = new SqlCommand("INSERT INTO BanHang ( TenKH, SDT, MaSP, TenSP, LoaiSP, SoLuong, DonGia, NgayLap) VALUES (@tenkh,@sdt,@masp,@tensp,@loaisp,@soluong,@dongia,@ngaylap)", mydb.getConnection);
         //   command.Parameters.Add("@hd", SqlDbType.VarChar).Value = hoadon;
            command.Parameters.Add("@tenkh", SqlDbType.NVarChar).Value = tenkh;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@masp", SqlDbType.NChar).Value = masp;
            command.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = tensp;
            command.Parameters.Add("@loaisp", SqlDbType.NVarChar).Value = loaisp;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@dongia", SqlDbType.Int).Value = dongia;
            command.Parameters.Add("@ngaylap", SqlDbType.DateTime).Value = ngaylap;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool insertNhapHang( string tenNguoiNhap, string masp, string tensp, string ncc, int soluong, int dongia, DateTime ngaylap)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhapHang ( NguoiNhap, MaSP, TenSP, NhaCungCap, SoLuong, DonGia, NgayNhap) VALUES (@nguoinhap, @masp, @tensp, @ncc, @sl, @dongia, @ngaynhap)", mydb.getConnection);
            command.Parameters.Add("@nguoinhap", SqlDbType.NVarChar).Value = tenNguoiNhap;
            command.Parameters.Add("@masp", SqlDbType.NChar).Value = masp;
            command.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = tensp;
            command.Parameters.Add("@ncc", SqlDbType.NVarChar).Value = ncc;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@dongia", SqlDbType.Int).Value = dongia;
            command.Parameters.Add("@ngaynhap", SqlDbType.DateTime).Value = ngaylap;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
    }
}
