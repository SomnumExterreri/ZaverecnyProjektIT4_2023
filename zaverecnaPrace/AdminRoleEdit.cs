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
    public partial class AdminRoleEdit : Form
    {
        SqlRepository sqlRepository;
        private int Id { get; set; }
        private AdminRoleControl AdminRoleControl { get; set; }
        public AdminRoleEdit(int id, AdminRoleControl adminRoleControl)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            Id = id;
            AdminRoleControl = adminRoleControl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminRoleControl.Text != "")
            {
                sqlRepository.UpdateRole(Id, txtRoleEdit.Text);
                AdminRoleControl.LoadData();
                Close();
                MessageBox.Show("Databáze aktualizována");
            }
            else
                MessageBox.Show("Chybý nové jméno role!!");
        }

        private void AdminRoleEdit_Load(object sender, EventArgs e)
        {
            var role = sqlRepository.GetRole(Id);
            if(role != null)
            {
                txtRoleEdit.Text = role.Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
