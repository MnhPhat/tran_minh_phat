using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_buoi7
{
    internal class KhoaDao
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();
        public DataTable getlist(int? makhoa = null)
        {
            string sql = null;
            if (makhoa == null)
            {
                sql = "SELECT Khoa.MaKhoa, Khoa.TenKhoa, Khoa.GhiChu, " +
                    "Khoa.TenKhoa FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa"; ;
            }
            else
            {
                sql = "SELECT Khoa.MaKhoa, Khoa.TenKhoa, Khoa.GhiChu, " +
                    "Khoa.TenKhoa FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa";
                ;
            }
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int getCount()
        {
            string sql = "SELECT COUNT(Khoa.MaKhoa) FROM SinhVien INNER JOIN Khoa ON KHOA.MAKHOA=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow getRow(string masv)
        {
            string sql = "SELECT Khoa. MaKhoa, Khoa.TenKhoa, Khoa.GhiChu";
            sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaSV='" + masv + "'";
            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];
            return row;
        }
        public void InsertTwo(Khoa k)
        {
            string sql = "INSERT INTO Khoa (MaKhoa, TenKhoa,GhiChu) VALUES (@MAKHOA, @TENKHOA,  @GHICHU)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", k.Makhoa);
            cmd.Parameters.AddWithValue("@TENKHOA", k.Tenkhoa);
            cmd.Parameters.AddWithValue("@DIEMTB", k.Ghichu);
           
            cmd.ExecuteNonQuery();
        }
        public void UpdateTwo(Khoa k)
        {
            string sql = "UPDATE Khoa SET MaKhoa=@MAKHOA, TenKhoa=@TENKHOA, GhiChu=@GHICHU ";
            sql += "WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", k.Makhoa); 
            cmd.Parameters.AddWithValue("@TENKHOA", k.Tenkhoa);  
            cmd.Parameters.AddWithValue("@GhiChu", k.Ghichu);
        }
        public void DeleteTwo(string makhoa)
        {
            string sql = "DELETE FROM Khoa WHERE MaKhoa=@MAKHOA";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKHOA", makhoa);
            cmd.ExecuteNonQuery();
        }

        
    }
}
