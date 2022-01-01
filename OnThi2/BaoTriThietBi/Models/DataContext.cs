using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace BaoTriThietBi.Models
{
    public class DataContext
    {
        public String ConnectionString { get; set; }

        public DataContext(String connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /*SQL CANHO*/
        public int SqlInsertCanHo(CanHoModel canho)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into CanHo values(@macanho, @tenchuho)";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macanho", canho.MaCanHo);
                cmd.Parameters.AddWithValue("tenchuho", canho.TenChuHo);
                return (cmd.ExecuteNonQuery());
            }
        }

        /* -----------------------------
        *  SQL TABLE QUANLYNHANVIEN
        *--------------------------------*/
        public List<object> sqlListByTimeNhanVien(int solan)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select NV.TenNhanVien, NV.SoDienThoai, count(*) AS SoLan
                            from NHANVIEN NV join NV_BT on  NV.MaNhanVien = NV_BT.MaNhanVien
                            group by NV.TenNhanVien, NV.SoDienThoai
                            having count(*) >= @SoLanInput";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("SoLanInput", solan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            TenNV = reader["TenNhanVien"].ToString(),
                            SoDT = reader["SoDienThoai"].ToString(),
                            SoLan = Convert.ToInt32(reader["SoLan"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<NhanVienModel> sqlLietKeNV()
        {
            List<NhanVienModel> list = new List<NhanVienModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"Select * from NHANVIEN";
                SqlCommand cmd = new SqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienModel()
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            TenNhanVien = reader["TenNhanVien"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            GioiTinh = Convert.ToBoolean(reader["GioiTinh"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        
        public List<NVBTModel> sqlGetNVBT(string mnv)
        {
            List<NVBTModel> list = new List<NVBTModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select * from NV_BT where MaNhanVien=@manhanvien";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manhanvien", mnv);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NVBTModel()
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            MaThietBi = reader["MaThietBi"].ToString(),
                            MaCanHo = reader["MaCanHo"].ToString(),
                            LanThu = Convert.ToInt32(reader["LanThu"]),
                            NgayBaoTri = Convert.ToDateTime(reader["NgayBaoTri"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public int XoaTB(string manv, int lanthu)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"delete from NV_BT where MaNhanVien=@manv and LanThu=@lanthu";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", manv);
                cmd.Parameters.AddWithValue("lanthu", lanthu);
                return (cmd.ExecuteNonQuery());
            }
        }

        public NVBTModel sqlViewThietBi(string manv, int lanthu)
        {
            NVBTModel nvbt = new NVBTModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select * from NV_BT where MaNhanVien=@manv and LanThu=@lanthu";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", manv);
                cmd.Parameters.AddWithValue("lanthu", lanthu);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    nvbt.MaThietBi = reader["MaThietBi"].ToString();
                    nvbt.MaCanHo = reader["MaCanHo"].ToString();
                    nvbt.LanThu = Convert.ToInt32(reader["LanThu"]);
                    nvbt.NgayBaoTri = Convert.ToDateTime(reader["NgayBaoTri"]);
                }
                conn.Close();
            }
            return nvbt;
        }
    }






}
