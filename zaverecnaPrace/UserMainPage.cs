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
    public partial class UserMainPage : Form
    {
        private int id { get; set; }
        SqlRepository sqlRepository;
        public UserMainPage(int Id)
        {
            sqlRepository = new SqlRepository();
            id = Id;
            InitializeComponent();
        }

        public void LoadData()
        {
            var workHours = sqlRepository.GetWorkHours();
            lvControl.Items.Clear();
            foreach (var workHour in workHours)
                lvControl.Items.Add(new ListViewItem(new string[] { workHour.Id.ToString(), sqlRepository.GetEmployee(workHour.PersonalNumber).FirstName + " " + sqlRepository.GetEmployee(workHour.PersonalNumber).LastName, sqlRepository.GetContract(workHour.ContactId).Customer, sqlRepository.GetWorkType(workHour.WorkTypeStyleId).Name, workHour.Hours.ToString() }));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserWork userWork = new UserWork(id, this);
            userWork.ShowDialog();
        }

        private void UserMainPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
