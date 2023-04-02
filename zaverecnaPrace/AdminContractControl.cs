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
    public partial class AdminContractControl : Form
    {
        
        SqlRepository sqlRepository;
        public AdminContractControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvContract.Items.Clear();
            var contracts = sqlRepository.GetContracts();
            foreach (var contract in contracts)
                lvContract.Items.Add(new ListViewItem(new string[] { contract.ContractNumber.ToString(), contract.Customer, contract.Description }));
        }
        private void AdminContractControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminContractAdd adminContractAdd = new AdminContractAdd(this);
            adminContractAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvContract.SelectedItems.Count > 0)
            {
                AdminContractEdit adminContractEdit = new AdminContractEdit(Convert.ToInt32(lvContract.SelectedItems[0].SubItems[0].Text));
                adminContractEdit.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvContract.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteContract(Convert.ToInt32(lvContract.SelectedItems[0].SubItems[0].Text));
                LoadData();
            }
            else
                MessageBox.Show("Nic není vybrané!");

        }

       
    }
}
