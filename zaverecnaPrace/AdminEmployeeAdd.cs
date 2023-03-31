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
    public partial class AdminEmployeeAdd : Form
    {
        SqlRepository sqlRepository;
        AdminEmployyeControl employyeControl;
        public AdminEmployeeAdd()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            employyeControl = new AdminEmployyeControl();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                sqlRepository.AddEmployee(txtFirstName.Text, txtLastName.Text, dtBirthDate.Value, txtEmail.Text, txtPhone.Text);
                employyeControl.LoadData();
                this.Close();
                MessageBox.Show("Databáze aktualizována");
            }
            else
                MessageBox.Show("Vyplňte vše!");
        }
    }
}
