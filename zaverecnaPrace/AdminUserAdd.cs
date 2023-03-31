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
    public partial class AdminUserAdd : Form
    {
        SqlRepository sqlRepository;
        private AdminUserControl adminUserControl;
        public AdminUserAdd()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e) //Nemazat, jinak nefunguje formulář!!
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && cboxEmployee.Text != null && cboxRole.Text != null)
            {
                var PersonalNumber = cboxEmployee.Text.Split('-');
                var user = new User(txtUsername.Text);
                var role = sqlRepository.GetRole(cboxRole.Text);
                user.ResetingPassword();
                sqlRepository.Register(Convert.ToInt32(PersonalNumber[1].Trim()), role.Id, user.UserName, user.Password, user.PasswordSalt);
                adminUserControl.LoadData();
                this.Close();
                MessageBox.Show("Nový uživatel v databázi");
            }
            else
                MessageBox.Show("Zadejte všechny údaje!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminUserAdd_Load(object sender, EventArgs e)
        {
            cboxEmployee.Items.Clear();
            var employees = sqlRepository.GetEmployees();
            foreach (var employee in employees)
            {
                if(!sqlRepository.IsUsernameAvailable(employee.PersonalNumber))
                    cboxEmployee.Items.Add(employee.FirstName +" "+ employee.LastName + " - " + employee.PersonalNumber);
                cboxRole.Items.Clear();
                var Role = sqlRepository.GetRole();
                foreach (var role in Role)
                    cboxRole.Items.Add(role.Name);
            }
        }
    }
}
