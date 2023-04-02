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
    public partial class AdminRoleControl : Form
    {
        SqlRepository sqlRepository;
        public AdminRoleControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvControl.Items.Clear();
            var roles = sqlRepository.GetRoles();
            foreach (var role in roles)
                lvControl.Items.Add(new ListViewItem(new string[] { role.Id.ToString(), role.Name}));
        }

        private void AdminRoleControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminRoleControlAdd adminRoleControlAdd = new AdminRoleControlAdd(this);
            adminRoleControlAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count > 0)
            {
                AdminRoleEdit adminRoleEdit = new AdminRoleEdit(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[0].Text), this);
                adminRoleEdit.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteRole(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[0].Text));
                LoadData();
            }
            else
                MessageBox.Show("Nebylo nic vybráno");
        }
    }
}
