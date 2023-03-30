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
    public partial class AdminRoleControlAdd : Form
    {
        SqlRepository sqlRepository;
        private AdminRoleControl AdminRoleControl { get; set; }
        public AdminRoleControlAdd(AdminRoleControl adminRoleControl)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminRoleControl = adminRoleControl;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtAdd.Text != "")
            {
                sqlRepository.AddRole(txtAdd.Text);
                AdminRoleControl.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("Vyplňte jméno role");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
