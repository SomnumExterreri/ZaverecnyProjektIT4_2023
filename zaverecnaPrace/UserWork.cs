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
    public partial class UserWork : Form
    {
        SqlRepository sqlRepository;
        UserMainPage mainPage;
        private int Id { get; set; }
        public UserWork(int id, UserMainPage MainPage)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            Id = id;
            mainPage = new UserMainPage(id);
        }

        private void UserWork_Load(object sender, EventArgs e)
        {
            cBoxContactId.Items.Clear();
            var Contacts = sqlRepository.GetContracts();
            var WorkTypeStyle = sqlRepository.GetWorkTypes();
            foreach (var Contact in Contacts)
                cBoxContactId.Items.Add(Contact.ContractNumber);
            foreach (var WorkType in WorkTypeStyle)
                cBoxWorkId.Items.Add(WorkType.Id);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(numHours.Value !=0 && cBoxContactId.Text != "" && cBoxWorkId.Text != "")
            {
                var user = sqlRepository.GetUserById(Id);
                sqlRepository.AddWorkHour(user.PersonalNumber, Convert.ToInt32(cBoxContactId.Text), Convert.ToInt32(cBoxWorkId.Text), Convert.ToInt32(numHours.Value));
                mainPage.LoadData();
                this.Close();
            }
        }
    }
}
