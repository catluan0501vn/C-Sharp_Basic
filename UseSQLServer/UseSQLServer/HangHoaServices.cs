using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseSQLServer
{
    class HangHoaServices: AdapterSQLServer
    {
        public List<HangHoa> GetAll()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["UseSQLServer.Properties.Settings.MyeStoreConnectionString"].ConnectionString;

            // Provide the query string with a parameter placeholder.
            List<HangHoa> hh = new List<HangHoa>();
            string queryString = "Select *  from HangHoa";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    hh.Add(new HangHoa
                    {
                        MaHH = int.Parse(reader[0].ToString()),
                        TenHH = reader[1].ToString(),
                        MaLoai = int.Parse(reader[2].ToString()),
                        MoTaDonVi = reader[3].ToString(),
                        DonGia = float.Parse(reader[4].ToString()),
                        Hinh = reader[5].ToString(),
                        NgaySx = DateTime.Parse(reader[6].ToString()),
                        GiamGia = float.Parse(reader[7].ToString()),
                        SoLanXem = int.Parse(reader[8].ToString()),
                        MoTa = reader[9].ToString(),
                        MaNCC = reader[10].ToString(),

                    });
                }
                reader.Close();

                return hh;
            }

        }

        public List<HangHoa> GetHangHoaByName(string tenHH)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["UseSQLServer.Properties.Settings.MyeStoreConnectionString"].ConnectionString;

            // Provide the query string with a parameter placeholder.
            List<HangHoa> hh = new List<HangHoa>();
            string queryString = "Select *  from HangHoa where TenHH like @TenHH Or MaHH like @TenHH";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.Parameters.AddWithValue("@TenHH", "%"+tenHH+"%");
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    hh.Add(new HangHoa
                    {
                        MaHH = int.Parse(reader[0].ToString()),
                        TenHH = reader[1].ToString(),
                        MaLoai = int.Parse(reader[2].ToString()),
                        MoTaDonVi = reader[3].ToString(),
                        DonGia = float.Parse(reader[4].ToString()),
                        Hinh = reader[5].ToString(),
                        NgaySx = DateTime.Parse(reader[6].ToString()),
                        GiamGia = float.Parse(reader[7].ToString()),
                        SoLanXem = int.Parse(reader[8].ToString()),
                        MoTa = reader[9].ToString(),
                        MaNCC = reader[10].ToString(),

                    });
                }
                reader.Close();

                return hh;
            }
        }

        public List<HangHoa> GetHangHoaByMaLoai(string loaiHH)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["UseSQLServer.Properties.Settings.MyeStoreConnectionString"].ConnectionString;

            // Provide the query string with a parameter placeholder.
            List<HangHoa> hh = new List<HangHoa>();
            string queryString = "Select *  from HangHoa where MaLoai = @MaLoai";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.Parameters.AddWithValue("@MaLoai", loaiHH);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    hh.Add(new HangHoa
                    {
                        MaHH = int.Parse(reader[0].ToString()),
                        TenHH = reader[1].ToString(),
                        MaLoai = int.Parse(reader[2].ToString()),
                        MoTaDonVi = reader[3].ToString(),
                        DonGia = float.Parse(reader[4].ToString()),
                        Hinh = reader[5].ToString(),
                        NgaySx = DateTime.Parse(reader[6].ToString()),
                        GiamGia = float.Parse(reader[7].ToString()),
                        SoLanXem = int.Parse(reader[8].ToString()),
                        MoTa = reader[9].ToString(),
                        MaNCC = reader[10].ToString(),

                    });
                }
                reader.Close();

                return hh;
            }
        }

        public void Add(HangHoa hh)
        {
            string queryString = @"INSERT HangHoa
                                (MaHH, TenHH, MaLoai, MoTaDonVi, DonGia, Hinh, NgaySx, GiamGia, SoLanXem, MoTa, MaNCC)
                                VALUES(@MaHH, @TenHH, @MaLoai, @MoTaDonVi, @DonGia, @Hinh, @NgaySx, @GiamGia, @SoLanXem, @MoTa, @MaNCC)";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@TenHH", hh.TenHH);
                command.Parameters.AddWithValue("@MaLoai", hh.MaLoai);
                command.Parameters.AddWithValue("@MoTaDonVi", hh.MoTaDonVi);
                command.Parameters.AddWithValue("@DonGia", hh.DonGia);
                command.Parameters.AddWithValue("@Hinh", hh.Hinh);
                command.Parameters.AddWithValue("@NgaySx", hh.NgaySx);
                command.Parameters.AddWithValue("@GiamGia", hh.GiamGia);
                command.Parameters.AddWithValue("@SoLanXem", hh.SoLanXem);
                command.Parameters.AddWithValue("@MoTa", hh.MoTa);
                command.Parameters.AddWithValue("@MaNCC", hh.MaNCC);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Edit(HangHoa hh)
        {
            string queryString = @"Update HangHoa
                                set
                                TenHH = @TenHH,
                                MaLoai = @MaLoai, MoTaDonVi = @MoTaDonVi,
                                DonGia = @DonGia, Hinh = @Hinh,
                                NgaySx = @NgaySx, GiamGia = @GiamGia, 
                                SoLanXem = @SoLanXem, MoTa = @MoTa, MaNCC = @MaNCC
                                Where MaHH = @MaHH";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaHH", hh.MaHH);
                command.Parameters.AddWithValue("@TenHH", hh.TenHH);
                command.Parameters.AddWithValue("@MaLoai", hh.MaLoai);
                command.Parameters.AddWithValue("@MoTaDonVi", hh.MoTaDonVi);
                command.Parameters.AddWithValue("@DonGia", hh.DonGia);
                command.Parameters.AddWithValue("@Hinh", hh.Hinh);
                command.Parameters.AddWithValue("@NgaySx", hh.NgaySx);
                command.Parameters.AddWithValue("@GiamGia", hh.GiamGia);
                command.Parameters.AddWithValue("@SoLanXem", hh.SoLanXem);
                command.Parameters.AddWithValue("@MoTa", hh.MoTa);
                command.Parameters.AddWithValue("@MaNCC", hh.MaNCC);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(string maHH)
        {
            string queryString = @"Delete HangHoa Where MaHH = @MaHH";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaHH", maHH);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
