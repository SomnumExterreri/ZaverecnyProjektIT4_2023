using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class SqlRepository
    {
        public string Connection { get; set; }
        byte[] passwordSalt;
        byte[] passwordHash;


        public SqlRepository(string connection)
        {
            this.Connection = connection;
        }

        public void Login(string Username, string password)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where Username = @username";
                    cmd.Parameters.AddWithValue("username", Username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {

                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
