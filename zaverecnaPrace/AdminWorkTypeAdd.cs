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
    public partial class AdminWorkTypeAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminWorkTypeControl AdminWorkTypeControl { get; set; }
        public AdminWorkTypeAdd(AdminWorkTypeControl adminWorkTypeControl)
        {
            InitializeComponent();
            AdminWorkTypeControl = adminWorkTypeControl;
            sqlRepository = new SqlRepository();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtDescription.Text != "")
            {
                sqlRepository.AddWorkType(txtName.Text, txtDescription.Text);
                AdminWorkTypeControl.LoadData();
                this.Close();
                MessageBox.Show("Databáze aktualizována");
            }
        }
    }
}
