using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace WMSwithRFID.Domain_Classes
{
    class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AccountType AccountType { get; set; }
        public string CompanyPosition { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public string passwordMD5(string pass)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            return str.ToString();
        }

    }

    

    enum AccountType
    {
        Administrator, Supervisor
    }
}
