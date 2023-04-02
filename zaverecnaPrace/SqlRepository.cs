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
            Connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Attendance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }


        public void UpdateUser(string Username, int Role, int Id)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
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
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
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

        public void AddContract(string Customer, string Description)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Contract VALUES (@Customer, @Description)";
                    cmd.Parameters.AddWithValue("Customer", Customer);
                    cmd.Parameters.AddWithValue("Description", Description);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateContract(int ContractNumber, string Customer, string Description)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Contract SET Customer=@Customer, Description=@Description WHERE ContractNumber=@ContractNumber";
                    cmd.Parameters.AddWithValue("Customer", Customer);
                    cmd.Parameters.AddWithValue("Description", Description);
                    cmd.Parameters.AddWithValue("ContractNumber", ContractNumber);
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
                    cmd.ExecuteNonQuery();
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
                    cmd.ExecuteNonQuery();
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
                            user = new User(Convert.ToInt32(reader["IdUser"]), Convert.ToInt32(reader["PersonalNumber"]), Convert.ToInt32(reader["Roles"]), reader["Username"].ToString(), (byte[])reader["Password"], (byte[])reader["PasswordSalt"]);
                        else
                            MessageBox.Show("Neplatné uživatelské jméno");
                    }
                }
                connection.Close();
            }
            return user;
        }

        public User GetUserById(int IdUser)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Users WHERE IdUser=@IdUser";
                    cmd.Parameters.AddWithValue("IdUser", IdUser);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            user = new User(Convert.ToInt32(reader["IdUser"]), Convert.ToInt32(reader["PersonalNumber"]), Convert.ToInt32(reader["Roles"]), reader["Username"].ToString(), (byte[])reader["Password"], (byte[])reader["PasswordSalt"]);
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
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Role WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
            using (SqlConnection connection = new SqlConnection(Connection))
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
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Role";
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
        public void AddEmployee(string FirstName, string LastName, DateTime BirthDate, string Email, string Phone)
        {
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Employee VALUES (@FirstName, @LastName, @BirthDate, @Email, @Phone)";
                    cmd.Parameters.AddWithValue("FirstName", FirstName);
                    cmd.Parameters.AddWithValue("LastName", LastName);
                    cmd.Parameters.AddWithValue("BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Phone", Phone);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void UpdateEmployee(int PersonalNumber, string FirstName, string LastName, DateTime BirthDate, string Email, string Phone)
        {
            using(SqlConnection connection=new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Employee SET FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate, Email=@Email, Phone=@Phone WHERE PersonalNumber=@PersonalNumber";
                    cmd.Parameters.AddWithValue("FirstName", FirstName);
                    cmd.Parameters.AddWithValue("LastName", LastName);
                    cmd.Parameters.AddWithValue("BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Phone", Phone);
                    cmd.Parameters.AddWithValue("PersonalNumber", PersonalNumber);
                    cmd.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
        public void DeleteEmployee(int PersonalNumber)
        {
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Employee WHERE PersonalNumber=@PersonalNumber";
                    cmd.Parameters.AddWithValue("PersonalNumber", PersonalNumber);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<Contract> GetContracts()
        {
            List<Contract> contracts = new List<Contract>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contract";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            contracts.Add(new Contract(Convert.ToInt32(reader["ContractNumber"]), reader["Customer"].ToString(), reader["Description"].ToString()));
                    }
                }
                connection.Close();
            }
            return contracts;
        }
        public Contract GetContract(int ContractNumber)
        {
            Contract contract = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contract WHERE ContractNumber=@ContractNumber";
                    cmd.Parameters.AddWithValue("ContractNumber", ContractNumber);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            contract = new Contract(Convert.ToInt32(reader["ContractNumber"]), reader["Customer"].ToString(), reader["Description"].ToString());
                    }
                }
                connection.Close();
            }
            return contract;
        }

        public Contract GetContractByName(string Customer)
        {
            Contract contract = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Contract WHERE Customer=@Customer";
                    cmd.Parameters.AddWithValue("Customer", Customer);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            contract = new Contract(Convert.ToInt32(reader["ContractNumber"]), reader["Customer"].ToString(), reader["Description"].ToString());
                    }
                }
                connection.Close();
            }
            return contract;
        }

        public void AddWorkHour(int PersonalNumber, int ContactId, int WorkTypeStyleId, int Hours)
        {
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WorkHours VALUES (@PersonalNumber, @ContactId, @WorkTypeStyleId, @Hours)";
                    cmd.Parameters.AddWithValue("PersonalNumber", PersonalNumber);
                    cmd.Parameters.AddWithValue("ContactId", ContactId);
                    cmd.Parameters.AddWithValue("WorkTypeStyleId", WorkTypeStyleId);
                    cmd.Parameters.AddWithValue("Hours", Hours);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
             
        }

        public void DeleteContract(int ContractNumber)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Contract WHERE ContractNumber=@ContractNumber";
                    cmd.Parameters.AddWithValue("ContractNumber", ContractNumber);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(Connection))
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

        public List<WorkType> GetWorkTypes()
        {
            List<WorkType> workTypes = new List<WorkType>();
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkType";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            workTypes.Add(new WorkType(Convert.ToInt32(reader["Id"]), reader["Name"].ToString(), reader["Description"].ToString()));
                    }
                }
                connection.Close();
            }
            return workTypes;
        }

        public void AddWorkType(string Name, string Description)
        {
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO WorkType VALUES (@Name, @Description)";
                    cmd.Parameters.AddWithValue("Name", Name);
                    cmd.Parameters.AddWithValue("Description", Description);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public WorkType GetWorkType(int Id)
        {
            WorkType workType = null;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkType WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            workType = new WorkType(Convert.ToInt32(reader["ID"]), reader["Name"].ToString(), reader["Description"].ToString());
                    }
                }
                connection.Close();
            }
            return workType;
        }
        public void UpdateWorkType(int Id, string Name, string Description)
        {
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE WorkType SET Name=@Name, Description=@Description WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Name", Name);
                    cmd.Parameters.AddWithValue("Description", Description);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void DeleteWorkType(int Id)
        {
            using( SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using( SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WorkType WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<WorkHours>GetWorkHours()
        {
            List<WorkHours> workHours = new List<WorkHours>();
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM WorkHours";
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            workHours.Add(new WorkHours(Convert.ToInt32(reader["Id"]), Convert.ToInt32(reader["PersonalNumber"]), Convert.ToInt32(reader["ContactId"]), Convert.ToInt32(reader["WorkTypeStyleId"]), Convert.ToInt32(reader["Hours"])));
                    }
                }
                connection.Close();
            }
            return workHours;
        }

        public List<Contract> GetContract()
        {
            List<Contract> contracts = new List<Contract>();
            using( SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using( SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT  FROM Contract";
                    using( SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            contracts.Add(new Contract(Convert.ToInt32(reader["ContractNumber"]), reader["Customer"].ToString(), reader[""].ToString()));
                    }
                }
                connection.Close();
            }
            return contracts;
        }

        public void DeleteWorkHours(int Id)
        {
            using(SqlConnection connection = new SqlConnection(Connection))
            {
                connection.Open();
                using(SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM WorkHours WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
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
