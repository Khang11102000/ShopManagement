using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH
{
    class LoaiSanPham
    {
        MY_DB mydb = new MY_DB();

        public bool insertLoaiSP(string masp, string tensp )
        {
            SqlCommand command = new SqlCommand("INSERT INTO LoaiSP (MaSP, TenSP) VALUES (@masp, @tensp)", mydb.getConnection);
            command.Parameters.Add("@masp", SqlDbType.VarChar).Value =masp;
            command.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = tensp;
        
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
        public bool updateLoaiSP(string masp, string tensp)
        {
            SqlCommand command = new SqlCommand("UPDATE LoaiSP SET  TenSP=@tensp WHERE MaSP=@masp", mydb.getConnection);
            command.Parameters.Add("@masp", SqlDbType.VarChar).Value = masp;
            command.Parameters.Add("@tensp", SqlDbType.NVarChar).Value = tensp;
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
        public bool deleteLoaiSP(string masp)
        {
            SqlCommand command = new SqlCommand("DELETE FROM LoaiSP WHERE MaSP=@masp", mydb.getConnection);
            command.Parameters.Add("@masp", SqlDbType.VarChar).Value = masp;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        public DataTable getLoaiSP(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
      
        public DataTable getLoaiSPByMaSP(string masp)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoaiSP WHERE MaSP=@masp", mydb.getConnection);
            command.Parameters.Add("@masp", SqlDbType.VarChar).Value = masp;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkMaSP(string MaSP)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoaiSP WHERE MaSP=@masp", mydb.getConnection);
            command.Parameters.Add("@masp", SqlDbType.NVarChar).Value = MaSP;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
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
        public string totalCourse()
        {
            return execCount("SELECT COUNT(*) FROM LoaiSP");
        }
    }
}
