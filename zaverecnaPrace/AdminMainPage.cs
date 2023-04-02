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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void RoleControl_Click(object sender, EventArgs e)
        {
            AdminRoleControl adminRoleControl = new AdminRoleControl();
            adminRoleControl.ShowDialog();
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            AdminUserControl adminUserControl = new AdminUserControl();
            adminUserControl.ShowDialog();
        }

        private void btnContractControl_Click(object sender, EventArgs e)
        {
            AdminContractControl adminContractControl = new AdminContractControl();
            adminContractControl.ShowDialog();
        }

        private void btnWorkHours_Click(object sender, EventArgs e)
        {
            AdminWorkHoursControl adminWorkHoursControl = new AdminWorkHoursControl();
            adminWorkHoursControl.ShowDialog();
        }

        private void btnWorkType_Click(object sender, EventArgs e)
        {
            AdminWorkTypeControl adminWorkTypeControl = new AdminWorkTypeControl();
            adminWorkTypeControl.ShowDialog();
        }

        private void btnEmployye_Click(object sender, EventArgs e)
        {
            AdminEmployyeControl adminEmployyeControl = new AdminEmployyeControl();
            adminEmployyeControl.ShowDialog();
        }
    }
}
