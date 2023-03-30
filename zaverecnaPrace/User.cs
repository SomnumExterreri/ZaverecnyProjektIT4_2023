using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnaPrace
{
    internal class User
    {
        public int Id { get; set; }
        public int PersonalNumber { get; set; }
        public int Role { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }



        public User(int id, int personalNumber, int role, string userName, byte[] password, byte[] passwordSalt)
        {
            Id = id;
            PersonalNumber = personalNumber;
            Role = role;
            UserName = userName;
            Password = password;
            PasswordSalt = passwordSalt;
        }
    
        private void Hashing(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public void ResetingPassword()
        {
            Hashing("Heslo");
        }

        public bool Verify(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(Password);
        }

        public void ChangePassword(string password)
        {
            Hashing(password);
        }
    }
}
