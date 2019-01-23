using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public class Login
    {
        public string Username { get; set; }
        public string Userpassword { get; set; }

        public Login(string user, string pass)
        {
            Username = user;
            Userpassword = pass;
        }

        public bool AutenticadorString(string input)
        {
            string padronizar = "[^0-9]";

            if (Regex.IsMatch(input, padronizar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AutenticadorInt(string input)
        {
            string padronizar = "[^0-9^]";

            if(Regex.IsMatch(input, padronizar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
