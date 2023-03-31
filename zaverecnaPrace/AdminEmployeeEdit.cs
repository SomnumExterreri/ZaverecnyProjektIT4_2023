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
    public partial class AdminEmployeeEdit : Form
    {
        SqlRepository sqlRepository;
        private int PersonalNumber { get; set; }
        AdminEmployyeControl AdminEmployyeControl { get; set; }
        public AdminEmployeeEdit(int personalNumber, AdminEmployyeControl adminEmployyeControl)
        {
            PersonalNumber = personalNumber;
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminEmployyeControl = adminEmployyeControl;
        }

        private void AdminEmployeeEdit_Load(object sender, EventArgs e)
        {
            var employee = sqlRepository.GetEmployee(PersonalNumber);
            if(employee != null)
            {
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                dtBirthDate.Value = employee.BirthDate;
                txtEmail.Text = employee.Email;
                txtPhone.Text = employee.Phone;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                sqlRepository.UpdateEmployee(PersonalNumber, txtFirstName.Text, txtLastName.Text, dtBirthDate.Value, txtEmail.Text, txtPhone.Text);
                AdminEmployyeControl.LoadData();
                this.Close();
                MessageBox.Show("Databáze aktualizována");
            }
            else
                MessageBox.Show("Vyplňte vše!");
        }
    }
}
