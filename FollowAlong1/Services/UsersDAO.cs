using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SideProject.Models;

namespace SideProject.Services
{
    public class UsersDAO
    {
        string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
            "MultiSubnetFailover=False";

        public bool finduser(UserModel user)
        {
            string sqlstmt = "SELECT * FROM dbo.Users WHERE userN = @username AND passW = @password";
            bool success = false;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlstmt, conn);
                cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.username;
                cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.password;

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return success;
            }

        }
    }
}
