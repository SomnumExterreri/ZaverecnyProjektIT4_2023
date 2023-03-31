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
    public partial class AdminUserEdit : Form
    {
        SqlRepository sqlRepository;
        private int IdUser {get; set;}
        private AdminUserControl adminUserControl { get; set; }
        public AdminUserEdit(int idUser, AdminUserControl adminUserControl)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            adminUserControl = new AdminUserControl();  
            IdUser = idUser;
        }

        private void AdminUserEdit_Load(object sender, EventArgs e)
        {
            var user = sqlRepository.GetUserById(IdUser);
            var role = sqlRepository.GetRole(user.Role);
            var roles = sqlRepository.GetRoles();
            cboxRole.Text = role.Name;
            txtUsername.Text = user.UserName;
            foreach(var r in roles)
                cboxRole.Items.Add(r.Name);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboxRole.Text != null && txtUsername.Text != "")
            {
                var role = sqlRepository.GetRole(txtUsername.Text);
                sqlRepository.UpdateUser(txtUsername.Text, role.Id, IdUser);
                adminUserControl.LoadData();
                this.Close();
                MessageBox.Show("Data synchronizována.");
            }
            else
                MessageBox.Show("Vyplňte všechny údaje");
        }
    }
}
