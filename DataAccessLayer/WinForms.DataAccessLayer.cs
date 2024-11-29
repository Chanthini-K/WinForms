using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class SecurityCodeDAL
    { 

        private string connectionString = "Server=10.1.13.31;Database=AdventureWorks2019;User=Traininguser;password=Traininguser;TrustServerCertificate=true";

        public void AddSecurityCode(string code, string description)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SecurityCodes (Code, Description) VALUES (@Code, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSecurityCode(string code, string description)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE SecurityCodes SET Description = @Description WHERE Code = @Code";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", code);
                cmd.Parameters.AddWithValue("@Description", description);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetAllSecurityCodes()
        {
            List<string> codes = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Code FROM SecurityCodes";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    codes.Add(reader["Code"].ToString());
                }
            }
            return codes;
        }
    }
}

