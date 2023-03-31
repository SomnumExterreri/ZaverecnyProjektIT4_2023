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
    public partial class AdminEmployyeControl : Form
    {
        SqlRepository sqlRepository;
        public AdminEmployyeControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminEmployyeControl_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        public void LoadData()
        {
            var employees = sqlRepository.GetEmployees();
            lvControl.Items.Clear();
            foreach(var employee in employees)
                lvControl.Items.Add(new ListViewItem(new string[] {employee.PersonalNumber.ToString(), employee.FirstName, employee.LastName, Convert.ToString(employee.BirthDate.ToString("d")), employee.Email.ToString(), string.Format("{0:### ### ###}"), employee.Phone}));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminEmployeeAdd adminEmployeeAdd = new AdminEmployeeAdd();
            adminEmployeeAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminEmployeeEdit adminEmployeeEdit = new AdminEmployeeEdit(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[0].Text), this);
            adminEmployeeEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvControl.Items.Count > 0)
            {
                sqlRepository.DeleteEmployee(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[0].Text));
                LoadData();
            }
        }
    }
}
