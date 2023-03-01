using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class User
    {
        public User(string userName, byte[] password, byte[] passwordSalt)
        {
            UserName = userName;
            Password = password;
            PasswordSalt = passwordSalt;
        }

        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
