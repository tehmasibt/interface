using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace absinterface
{
    internal class User : IAccount
    {
        public readonly int Id=8;
        public string FullName;
        public string Email;
        public User(string password, string email)
        {          
            Password= password;
            Email = email;
        }
        public  void ShowInfo()
        {
            Console.WriteLine($"Password: {Password}, Email: {Email}");
        }
        string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!PasswordChecker(value))
                {
                    Console.WriteLine("Parolu duzgun daxil edin");
                    return;
                }
                _password = value;

            }
        }
        public bool PasswordChecker(string password)
        {
            
            int boyuk = 0;
            int kicik = 0;
            int reqem = 0;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    boyuk += c;
                }
                else if(char.IsLower(c))
                {
                    kicik += c;
                }
                else if (char.IsDigit(c))
                {
                    reqem += c;
                }
            }
            if (boyuk <= 1)
            {
                return false;
            }
            else if(kicik <= 1)
            {
                return false;
            }
            else if(reqem <= 1)
            {
                return false;
            }
            else if (password.Length <= 8)
            {
                return false;
            }
            return true;
        }
    }
}
