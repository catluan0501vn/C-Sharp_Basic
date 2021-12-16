using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseSQLServer
{
    class LoaiSPServices: AdapterSQLServer
    {
        public List<LoaiSP> GetAll()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["UseSQLServer.Properties.Settings.MyeStoreConnectionString"].ConnectionString;

            // Provide the query string with a parameter placeholder.
            List<LoaiSP> lLoaiSP = new List<LoaiSP>();
            string queryString = "Select *  from Loai";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lLoaiSP.Add(new LoaiSP
                    {
                        MaLoai = int.Parse(reader[0].ToString()),
                        TenLoai = reader[1].ToString(),
                        MoTa = reader[2].ToString(),
                        Hinh = reader[3].ToString(),
                    });
                }
                reader.Close();

                return lLoaiSP;
            }

        }

        public void Add(LoaiSP loaiSP)
        {
            string queryString = @"INSERT Loai 
                                ( TenLoai, MoTa, Hinh)
                                VALUES(@TenLoai, @MoTa, @Hinh)";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@TenLoai", loaiSP.TenLoai);
                command.Parameters.AddWithValue("@MoTa", loaiSP.MoTa);
                command.Parameters.AddWithValue("@Hinh", loaiSP.Hinh);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Edit(LoaiSP loaiSP)
        {
            string queryString = @"Update Loai
                                    set
                                    TenLoai = @TenLoai,
                                    MoTa = @MoTa,
                                    Hinh = @Hinh
                                    where MaLoai = @MaLoai";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaLoai", loaiSP.MaLoai.ToString());
                command.Parameters.AddWithValue("@TenLoai", loaiSP.TenLoai);
                command.Parameters.AddWithValue("@MoTa", loaiSP.MoTa);
                command.Parameters.AddWithValue("@Hinh", loaiSP.Hinh);

                connection.Open();
                command.ExecuteNonQuery();
            }    
        }
public void Delete(string maLoaiSP)
        {
            string queryString = @"Delete Loai Where MaLoai = @MaLoai";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaLoai", maLoaiSP);

                connection.Open();
                command.ExecuteNonQuery();
            }    
        }
        
    }
}
