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
    public partial class AdminContractAdd : Form
    {
        private AdminContractControl adminContractControl;
        SqlRepository sqlRepository;
        public AdminContractAdd()
        {
            sqlRepository = new SqlRepository();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "" && txtDescription.Text != "")
            {
                sqlRepository.AddContract(txtCustomer.Text, txtDescription.Text);
                adminContractControl.LoadData();
                Close();
                MessageBox.Show("Databáze aktualizována");
            }
            else
                MessageBox.Show("Vyplňte oba údaje!");
        }
    }
}
