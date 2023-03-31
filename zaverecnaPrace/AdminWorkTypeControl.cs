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
    public partial class AdminWorkTypeControl : Form
    {
        SqlRepository sqlRepository;
        public AdminWorkTypeControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            var WorkTypes = sqlRepository.GetWorkTypes();
            lvControl.Items.Clear();
            foreach (var workType in WorkTypes)
                lvControl.Items.Add(new ListViewItem(new string[] { workType.Id.ToString(), workType.Name, workType.Description }));
        }

        private void AdminWorkTypeControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminWorkTypeAdd adminWorkTypeAdd = new AdminWorkTypeAdd(this);
            adminWorkTypeAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminWorkTypeEdit adminWorkTypeEdit = new AdminWorkTypeEdit(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[1].Text), this);
            adminWorkTypeEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvControl.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteWorkType(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[1].Text));
                LoadData();
            }
        }
    }
}
