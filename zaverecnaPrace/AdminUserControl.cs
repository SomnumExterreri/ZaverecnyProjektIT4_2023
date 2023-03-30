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
    public partial class AdminUserControl : Form
    {
        SqlRepository sqlRepository;

        public AdminUserControl()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }
        //public void LoadData()
        //{
        //    lvControl.Items.Clear();
        //    var users = sqlRepository.GetUserByUsername()
        //        foreach(var user in users)
        //    {
        //        var em
        //    }
        //}
    }
}
