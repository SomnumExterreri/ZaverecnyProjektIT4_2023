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
    public partial class AdminContractEdit : Form
    {
        AdminContractControl adminContractControl;
        SqlRepository sqlRepository;
        public int ContractNumber { get; set; }

        public AdminContractEdit(int contractNumber)
        {
            InitializeComponent();
            ContractNumber = contractNumber;
            sqlRepository = new SqlRepository();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtCustomer.Text != "" && txtDescription.Text != "")
            {
                sqlRepository.UpdateContract(ContractNumber, txtCustomer.Text, txtDescription.Text);
                adminContractControl.LoadData();
                Close();
                MessageBox.Show("Databáze aktualizována");
            }
            else
                MessageBox.Show("Vyplňte všechna pole");
        }

        private void AdminContractEdit_Load(object sender, EventArgs e)
        {
            var contract = sqlRepository.GetContract(ContractNumber);
            if(contract != null)
            {
                txtCustomer.Text = contract.Customer;
                txtDescription.Text = contract.Description;
            }
        }
    }
}
