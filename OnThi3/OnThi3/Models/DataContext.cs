using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi3.Models
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


        public int SqlAddCV(CongViecModel congviec)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into CONGVIEC values(@macv, @tencv, @dongia)";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("macv", congviec.MACV);
                cmd.Parameters.AddWithValue("tencv", congviec.TENCV);
                cmd.Parameters.AddWithValue("dongia", congviec.DONGIA);
                return (cmd.ExecuteNonQuery());
            }
        }

        public List<BaoDuongModel> sqlListBDtheoSXe(string SoXe)
        {
            List<BaoDuongModel> list = new List<BaoDuongModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select * from baoduong where SOXE = @SOXE";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("SOXE", SoXe);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BaoDuongModel()
                        {
                            MABD = reader["MABD"].ToString(),
                            NGAYGIONHAN = reader["NGAYGIONHAN"].ToString(),
                            NGAYGIOTRA = reader["NGAYGIOTRA"].ToString(),
                            SOKM = Convert.ToInt32(reader["SOKM"]) ,
                            NOIDUNG = reader["NOIDUNG"].ToString(),
                            SOXE = reader["SOXE"].ToString(),
                        }) ;
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<object> sqlViewInfoBD(string MABD)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select * from BAODUONG BD, CT_BD, CONGVIEC CV
                            where BD.MABD = CT_BD.MABD and CV.MACV = CT_BD.MACV
                            and BD.MABD = @mabd";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mabd", MABD);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            NGAYGIONHAN = reader["NGAYGIONHAN"].ToString(),
                            NGAYGIOTRA = reader["NGAYGIOTRA"].ToString(),
                            DONGIA = Convert.ToInt32(reader["DONGIA"])  ,
                            TENCV = reader["TENCV"].ToString(),
                            MABD = reader["MABD"].ToString(),
                            MACV = reader["MACV"].ToString(),
                        });
                    }
                    reader.Close();
                }
                
            }
            return list;
        }

        public BaoDuongModel sqlEditInfoBD(string MABD)
        {
            BaoDuongModel bd = new BaoDuongModel();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"select * from BAODUONG where MABD = @mabd";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mabd", MABD);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    bd.NGAYGIONHAN = reader["NGAYGIONHAN"].ToString();
                    bd.NGAYGIOTRA = reader["NGAYGIOTRA"].ToString();
                    bd.MABD = reader["MABD"].ToString();
                    bd.SOKM = Convert.ToInt32(reader["SOKM"]);
                    bd.NOIDUNG = reader["NOIDUNG"].ToString();
                    bd.SOXE = reader["SOXE"].ToString();
                }
            }
            return bd;
        }

        public int sqlDeleteCTBD(string mabd, string macv)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"delete from CT_BD where MABD=@mabd and MACV=@macv";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mabd", mabd);
                cmd.Parameters.AddWithValue("macv", macv);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int sqlupdateBD(string mabd, string Ngaygiotra)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = @"update BAODUONG set NGAYGIOTRA = @Ngaygiotra where MABD= @mabd";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mabd", mabd);
                cmd.Parameters.AddWithValue("Ngaygiotra", Ngaygiotra);
                return (cmd.ExecuteNonQuery());
            }
        }
        
    }
}
