using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaverecnaPrace
{
    public partial class Login : Form
    {
        string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Attendance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlRepository sqlRepository;
        public Login()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }
    }
}
