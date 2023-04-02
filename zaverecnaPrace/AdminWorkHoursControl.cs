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
    public partial class AdminWorkHoursControl : Form
    {
        SqlRepository sqlRepository;
        public AdminWorkHoursControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminWorkHoursControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var workHours = sqlRepository.GetWorkHours();
            lvControl.Items.Clear();
            foreach (var workHour in workHours)
                lvControl.Items.Add(new ListViewItem(new string[] { workHour.Id.ToString(), sqlRepository.GetEmployee(workHour.PersonalNumber).FirstName + " " + sqlRepository.GetEmployee(workHour.PersonalNumber).LastName, workHour.ContactId.ToString(), sqlRepository.GetWorkType(workHour.WorkTypeStyleId).Name, workHour.Hours.ToString() }));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlRepository.DeleteWorkHours(Convert.ToInt32(lvControl.SelectedItems[0].SubItems[0].Text));
            LoadData();
        }
    }
}
