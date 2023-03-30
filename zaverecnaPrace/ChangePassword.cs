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
    public partial class ChangePassword : Form
    {
        SqlRepository sqlRepository;
        public ChangePassword()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(); 
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if(txtConfirmPassword.Text != "" && txtCurrentPassword.Text != "" && txtNewPassword.Text != "" && txtUsername.Text != "")
            {
                var user = sqlRepository.GetUserByUsername(txtUsername.Text);
                if (user != null)
                {
                    if (user.Verify(txtCurrentPassword.Text))
                    {
                        if (txtNewPassword.Text == txtConfirmPassword.Text)
                        {
                            user.ChangePassword(txtNewPassword.Text);
                            sqlRepository.ResetPassword(user.Password, user.PasswordSalt, user.Id);
                            MessageBox.Show("Změna hesla byla úspěšná");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nová hesla se neshodují!");
                        }
                    }
                    else
                        MessageBox.Show("Aktuální heslo se neshoduje!");
                }
                else
                    MessageBox.Show("Uživatelské jméno se neshoduje!");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
