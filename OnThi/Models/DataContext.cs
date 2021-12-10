using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using OnThi.Models;

namespace OnThi.Models
{
    public class DataContext
    {
        public string ConnectionString { get; set; } // Biến thành viên

        public DataContext(string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /* -----------------------------
         *  SQL TABLE Diem Cach Ly
         *--------------------------------*/
        public int sqlInsertDCL(DiemCachLyModel dcl)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into diemcachly values(@madiemcachly, @tendiemcachly, @diachi)";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("madiemcachly", dcl.MaDiemCachLy);
                cmd.Parameters.AddWithValue("tendiemcachly", dcl.TenDiemCachLy);
                cmd.Parameters.AddWithValue("diachi", dcl.DiaChi);
                return (cmd.ExecuteNonQuery());
            }
        }

        public List<object> sqlListCNbyNum(int soTC)
        {
            List<object> list = new List<object>();
            using(SqlConnection conn =  GetConnection())
            {
                conn.Open();
                var str = @"Select CN.TenCongNhan, CN.NamSinh, CN.NuocVe ,Count(*) AS SoTC
                            From CongNhan CN, CN_TC 
                            Where CN.MaCongNhan = CN_TC.MaCongNhan
                            Group by CN.TenCongNhan, CN.NamSinh, CN.NuocVe
                            Having count(*) >= @SoTCinput";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("SoTCinput", soTC);
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            tenCN = reader["TenCongNhan"].ToString(),
                            NamSinh = Convert.ToInt32(reader["NamSinh"]),
                            Nuocve = reader["NuocVe"].ToString(),
                            SoTC = Convert.ToInt32(reader["SoTC"])
                        }); 
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<DiemCachLyModel> sqlListDCL()
        {
            List<DiemCachLyModel> list = new List<DiemCachLyModel>();
            using(SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select * from DIEMCACHLY";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DiemCachLyModel() {
                            MaDiemCachLy = reader["MaDiemCachLy"].ToString(),
                            TenDiemCachLy = reader["TenDiemCachLy"].ToString(),
                            DiaChi = reader["DiaChi"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<CongNhanModel> sqlLietKeCNtheoDCL( string mdcl)
        {
            List<CongNhanModel> list = new List<CongNhanModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select * from CONGNHAN where MaDiemCachLy = @MaDCL";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaDCL", mdcl);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CongNhanModel()
                        {
                            MaCongNhan = reader["MaCongNhan"].ToString(),
                            TenCongNhan = reader["TenCongNhan"].ToString(),
                            GioiTinh = Convert.ToBoolean(reader["GioiTinh"]),
                            NamSinh = Convert.ToInt32(reader["NamSinh"]),
                            NuocVe = reader["NuocVe"].ToString(),
                            MaDiemCachLy = reader["MaDiemCachLy"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
    }
}
