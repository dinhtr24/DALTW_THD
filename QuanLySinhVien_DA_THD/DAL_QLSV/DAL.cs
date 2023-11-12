using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLSV
{
    public class DBConnect
    {
        public SqlConnection connection = new SqlConnection("Data Source=PRAIL\\DINH; Initial Catalog=QLSV_DA; User ID=sa; Password=123");
    }

    public class SinhVien
    {
        public string MaSoSinhVien { get; set; }
        public string HoTen { get; set; }
        public string NoiSinh { get; set; }
        public string SoDienThoai { get; set; }

        public SinhVien()
        {

        }

        public SinhVien(string mssv, string ht, string ns, string sdt)
        {
            MaSoSinhVien = mssv;
            HoTen = ht;
            NoiSinh = ns;
            SoDienThoai = sdt;
        }
    }

    public class DAL : DBConnect
    {
        public DataSet layThongTinSV()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SINHVIEN", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds, "SINHVIEN");
            return ds;
        }

        public DataTable layThongTinSV2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM SINHVIEN", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void themSinhVien(SinhVien sv)
        {
            connection.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO SINHVIEN (MaSoSinhVien, HoTen, NoiSinh, SoDienThoai) VALUES (@mssv, @ht, @ns, @sdt)", connection))
            {
                cmd.Parameters.AddWithValue("@mssv", sv.MaSoSinhVien);
                cmd.Parameters.AddWithValue("@ht", sv.HoTen);
                cmd.Parameters.AddWithValue("@ns", sv.NoiSinh);
                cmd.Parameters.AddWithValue("@sdt", sv.SoDienThoai);

                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void suaSinhVien(SinhVien sv, string avlb)
        {
            connection.Open();
            using (SqlCommand cmd = new SqlCommand("UPDATE SINHVIEN SET MaSoSinhVien = @mssv, HoTen = @ht, NoiSinh = @ns, SoDienThoai = @sdt WHERE MaSoSinhVien = @avlb", connection))
            {
                cmd.Parameters.AddWithValue("@mssv", sv.MaSoSinhVien);
                cmd.Parameters.AddWithValue("@ht", sv.HoTen);
                cmd.Parameters.AddWithValue("@ns", sv.NoiSinh);
                cmd.Parameters.AddWithValue("@sdt", sv.SoDienThoai);
                cmd.Parameters.AddWithValue("@avlb", avlb);

                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void xoaSinhVien(string mssv)
        {
            connection.Open();
            using (SqlCommand cmd = new SqlCommand("DELETE FROM SINHVIEN WHERE MaSoSinhVien = @mssv", connection))
            {
                cmd.Parameters.AddWithValue("@mssv", mssv);

                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
