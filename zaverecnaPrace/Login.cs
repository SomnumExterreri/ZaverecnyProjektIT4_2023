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
    public partial class Login : Form
    {
        SqlRepository sqlRepository;
        public Login()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }
        private void login()
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                User user = sqlRepository.GetUserByUsername(txtUsername.Text);
                if (user != null)
                {
                    if (user.Verify(txtPassword.Text))
                    {
                        var Role = sqlRepository.GetRole(user.Role);
                        if (Role != null && Role.Name != "admin")
                        {
                            UserMainPage userMainPage = new UserMainPage();
                            userMainPage.Show();
                            this.Hide();
                        }
                        else
                        {
                            AdminMainPage adminPage = new AdminMainPage();
                            adminPage.Show();
                            this.Hide();
                        }
                    }
                    else
                        MessageBox.Show("Heslo není správné!!");
                }
            }
            else
                MessageBox.Show("Vyplňte všechny údaje!!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }
    }
}
