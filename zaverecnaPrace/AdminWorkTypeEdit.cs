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
    public partial class AdminWorkTypeEdit : Form
    {
        public int Id { get; set; }
        public AdminWorkTypeControl AdminWorkTypeControl { get; set; }
        SqlRepository sqlRepository;
        public AdminWorkTypeEdit(int id, AdminWorkTypeControl adminWorkTypeControl)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            Id = id;
            AdminWorkTypeControl = adminWorkTypeControl;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminWorkTypeEdit_Load(object sender, EventArgs e)
        {
            var workType = sqlRepository.GetWorkType(Id);
            if(workType != null)
            {
                txtName.Text = workType.Name;
                txtDescription.Text = workType.Description;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDescription.Text != "")
            {
                sqlRepository.UpdateWorkType(Id, txtName.Text, txtDescription.Text);
                AdminWorkTypeControl.LoadData();
                this.Close();
                MessageBox.Show("Databáze aktualizována");
            }
            else
                MessageBox.Show("Vyplňte vše");
        }
    }
}
