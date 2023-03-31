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
    public partial class AdminUserControl : Form
    {
        SqlRepository sqlRepository;

        public AdminUserControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }
        public void LoadData()
        {
            lvControl.Items.Clear();
            var users = sqlRepository.GetUsers();
                foreach (var user in users)
            {
                var employee = sqlRepository.GetEmployee(user.PersonalNumber);
                var role = sqlRepository.GetRole(user.Role);
                lvControl.Items.Add(new ListViewItem(new string[] { user.Id.ToString(), employee.FirstName + " " + employee.LastName, user.UserName, role.Name.ToString()}));
            }
            
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminUserAdd adminUserAdd = new AdminUserAdd();
            adminUserAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var IdUser = Convert.ToInt32(lvControl.SelectedItems[0].SubItems[2].Text);
            AdminUserEdit adminUserEdit = new AdminUserEdit(IdUser, this);
            adminUserEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteUser(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[2].Text));
                LoadData();
            }
            else
                MessageBox.Show("Nemůžeš vymazat nevybranou položku!");
        }
    }
}
