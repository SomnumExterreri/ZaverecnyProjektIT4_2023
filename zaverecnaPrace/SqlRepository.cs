using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
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


        public SqlRepository()
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Attendance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }


        public void UpdateUser(string Username, int Role, int Id)
        {
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Users SET Username=@Username, Role=@Role WHERE Id=Id";
                    cmd.Parameters.AddWithValue("Username", Username);
                    cmd.Parameters.AddWithValue("Role", Role);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateRole(int Id, string Name)
        {
            using(SqlConnection connection=new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd =connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Role set Name=@Name WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Name", Name);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


        public void ResetPassword(byte[] Password, byte[] PasswordSalt, int Id)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Users SET Password=@Password, PasswordSalt=@PasswordSalt WHERE Id=Id";
                    cmd.Parameters.AddWithValue("Password", Password);
                    cmd.Parameters.AddWithValue("PasswordSalt", PasswordSalt);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
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
                            user = new User(Convert.ToInt32(reader["Id"]), Convert.ToInt32(reader["PersonalNumber"]), Convert.ToInt32(reader["Role"]), reader["Username"].ToString(), (byte[])reader["Password"], (byte[])reader["PasswordSalt"]);
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
                            user = new User(Convert.ToInt32(reader["Id"]), Convert.ToInt32(reader["PersonalNumber"]), Convert.ToInt32(reader["Role"]), reader["Username"].ToString(), (byte[])reader["Password"], (byte[])reader["PasswordSalt"]);
                        else
                            MessageBox.Show("Neplatné uživatelské jméno");
                    }
                }
                connection.Close();
            }
            return user;
        }

        public Role GetRole(int Id)
        {
            Role role = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Role WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            role = new Role(reader["Name"].ToString(), 0);
                        else
                            MessageBox.Show("Špatné Id role!!");
                    }
                }
                connection.Close();
            }
            return role;
        }



        public Role GetRole(string Name)
        {
            Role role = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Role WHERE Name=@Name";
                    cmd.Parameters.AddWithValue("Name", Name);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            role = new Role(null, Convert.ToInt32(reader["Id"]));
                        else
                            MessageBox.Show("Špatné Id role!!");
                    }
                }
                connection.Close();
            }
            return role;
        }

        public Employee GetEmployee(int PersonalNumber)
        {
            Employee employee = null;
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Employee WHERE PersonalNumber=@PersonalNumber";
                    cmd.Parameters.AddWithValue("PersonalNumber", PersonalNumber);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            employee = new Employee(Convert.ToInt32(reader["PersonalNumber"]), reader["FirstName"].ToString(), reader["LastName"].ToString(), (DateTime)reader["BirthDate"], reader["Email"].ToString(), reader["Phone"].ToString());
                        else
                            MessageBox.Show("Zaměstnanec neexistuje!");
                    }
                }
                connection.Close();
            }
            return employee;
        }

        public List<Role> GetRoles()
        {
            List<Role> roleList = new List<Role>();
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Role";
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            roleList.Add(new Role(reader["Name"].ToString(), Convert.ToInt32(reader["Id"])));
                    }
                }
                connection.Close();
            }
            return roleList;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Employee";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            employees.Add(new Employee(Convert.ToInt32(reader["PersonalNumber"]), reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToDateTime(reader["BirthDate"]), reader["Email"].ToString(), reader["Phone"].ToString()));
                    }
                }
                connection.Close();
            }
            return employees;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection=new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            users.Add(new User(Convert.ToInt32(reader["IdUser"]), Convert.ToInt32(reader["PersonalNumber"]), Convert.ToInt32(reader["Roles"]), reader["Username"].ToString()));
                    }
                }
                connection.Close();
            }
            return users;
        }
        public bool IsUsernameAvailable(int PersonalNumber)
        {
            User user = null;
            using (SqlConnection connection=new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE PersonalNumber=@PersonalNumber";
                    cmd.Parameters.AddWithValue("PersonalNumber", PersonalNumber);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            user = new User(Convert.ToInt32(reader["IdUser"]));
                    }
                }
                connection.Close();
            }
            if(user != null)
                return true;
            else
                return false;
        }
        
    }
}
