using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseSQLServer
{
    class NCCServices: AdapterSQLServer
    {
        public List<NCC> GetAll()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["UseSQLServer.Properties.Settings.MyeStoreConnectionString"].ConnectionString;

            // Provide the query string with a parameter placeholder.
            List<NCC> lnCCs = new List<NCC>();
            string queryString = "Select *  from NhaCungCap";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lnCCs.Add(new NCC
                    {
                        MaNCC = reader[0].ToString(),
                        TenCongTy = reader[1].ToString(),
                        Logo = reader[2].ToString(),
                        NguoiLienLac = reader[3].ToString(),
                        Email = reader[4].ToString(),
                        DienThoai = reader[5].ToString(),
                        DiaChi = reader[5].ToString(),
                        MoTa = reader[0].ToString()
                    });
                }
                reader.Close();

                return lnCCs;
            }

        }

        public void Add(NCC nCC)
        {
            string queryString = @"INSERT NhaCungCap 
                                (MaNCC, TenCongTy, Logo, NguoiLienLac, Email, DienThoai, DiaChi, MoTa)
                                VALUES(@MaNCC, @TenCongTy, @Logo, @NguoiLienLac, @Email, @DienThoai, @DiaChi, @MoTa)";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaNCC", nCC.MaNCC);
                command.Parameters.AddWithValue("@TenCongTy", nCC.TenCongTy);
                command.Parameters.AddWithValue("@Logo", nCC.Logo);
                command.Parameters.AddWithValue("@NguoiLienLac", nCC.NguoiLienLac);
                command.Parameters.AddWithValue("@Email", nCC.Email);
                command.Parameters.AddWithValue("@DienThoai", nCC.DienThoai);
                command.Parameters.AddWithValue("@DiaChi", nCC.DiaChi);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);


                connection.Open();
                command.ExecuteNonQuery();
            }    
        }

        public void Edit(NCC nCC)
        {
            string queryString = @"Update NhaCungCap
                                 set
                                 MaNCC = @MaNCC,
                                 TenCongTy = @TenCongTy,
                                 Logo = @Logo,
                                 NguoiLienLac = @NguoiLienLac,
                                 Email = @Email,
                                 DienThoai = @DienThoai,
                                 DiaChi = @DiaChi,
                                 MoTa = @MoTa
                                 Where MaNCC = @MaNCC";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaNCC", nCC.MaNCC);
                command.Parameters.AddWithValue("@TenCongTy", nCC.TenCongTy);
                command.Parameters.AddWithValue("@Logo", nCC.Logo);
                command.Parameters.AddWithValue("@NguoiLienLac", nCC.NguoiLienLac);
                command.Parameters.AddWithValue("@Email", nCC.Email);
                command.Parameters.AddWithValue("@DienThoai", nCC.DienThoai);
                command.Parameters.AddWithValue("@DiaChi", nCC.DiaChi);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);


                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(string maNCC)
        {
            string queryString = @"Delete NhaCungCap Where MaNCC = @MaNCC";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaNCC", maNCC);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
