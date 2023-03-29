using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Login(string Username, string Password)
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



        public void Register(int personalNumber, int role, string username, byte[] password, byte[] passwordSalt)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Users VALUES (@personalNumber, @role, @username, @password, @passwordSalt)";
                    cmd.Parameters.AddWithValue("personalNumber", @personalNumber);
                    cmd.Parameters.AddWithValue("role", @role);
                    cmd.Parameters.AddWithValue("username", @username);
                    cmd.Parameters.AddWithValue("password", @password);
                    cmd.Parameters.AddWithValue("passwordSalt", @passwordSalt);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void AddRole(string roleName)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Role VALUES (@roleName)";
                    cmd.Parameters.AddWithValue("roleName", roleName);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteRole(int Id)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Role WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                }
                connection.Close();
            }
        }

        public void DeleteUser(int Id)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Users WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                }
                connection.Close();
            }
        }

        public User GetUserByUsername(string Username)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE Username=@Username";
                    cmd.Parameters.AddWithValue("Username", Username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            user = new User(reader["Username"].ToString(), Convert.ToInt32(reader["Id"]), (byte[])reader["Password"], (byte[])reader["PasswordSalt"], Convert.ToInt32(reader["Role"]));
                        else
                            MessageBox.Show("Neplatné uživatelské jméno");
                    }
                }
                connection.Close();
            }
            return user;
        }

        public User GetUserById(int Id)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            user = new User(reader["Username"].ToString(), Convert.ToInt32(reader["Id"]), (byte[])reader["Password"], (byte[])reader["PasswordSalt"], Convert.ToInt32(reader["Role"]));
                        else
                            MessageBox.Show("Neplatné uživatelské jméno");
                    }
                }
                connection.Close();
            }
            return user;
        }
    }
}
