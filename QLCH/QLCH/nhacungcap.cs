using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH
{
    class nhacungcap
    {
        MY_DB mydb = new MY_DB();

        public bool insertNCC(string mancc, string ncc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhaCC (MaNCC, NCC) VALUES (@mancc, @ncc)", mydb.getConnection);
            command.Parameters.Add("@mancc", SqlDbType.VarChar).Value = mancc;
            command.Parameters.Add("@ncc", SqlDbType.NVarChar).Value = ncc;

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
        //public bool updateNCC(string mancc, string ncc)
        //{
        //    SqlCommand command = new SqlCommand("UPDATE NhaCC SET  NCC=@ncc WHERE MaNCC=@mancc", mydb.getConnection);
        //    command.Parameters.Add("@mancc", SqlDbType.VarChar).Value = mancc;
        //    command.Parameters.Add("@ncc", SqlDbType.NVarChar).Value = ncc;
        //    mydb.openConnection();
        //    if (command.ExecuteNonQuery() == 1)
        //    {
        //        mydb.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        mydb.closeConnection();
        //        return false;
        //    }
        //}
        public bool deleteLoaiSP(string masp)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NhaCC WHERE MaNCC=@mancc", mydb.getConnection);
            command.Parameters.Add("@mancc", SqlDbType.VarChar).Value = masp;
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
        public DataTable getNCC(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getNCCByMaNCC(string masp)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NhaCC WHERE MaNCC=@mancc", mydb.getConnection);
            command.Parameters.Add("@mancc", SqlDbType.VarChar).Value = masp;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkNCC(string ncc, int mancc = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NhaCC WHERE NCC=@ncc And MaNCC<>@mancc", mydb.getConnection);
            command.Parameters.Add("@ncc", SqlDbType.NVarChar).Value = ncc;
            command.Parameters.Add("@mancc", SqlDbType.VarChar).Value = mancc;
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
        public string totalNCC()
        {
            return execCount("SELECT COUNT(*) FROM NhaCC");
        }
    }
}
