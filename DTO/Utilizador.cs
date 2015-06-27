using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Utilizador
    {
        private string _userName;
        private string _password;
        private string _universo;
        public string userName
        {
            get
            {
                return _userName;
            }
        }
        public string password
        {
            get
            {
                return _password;
            }
        }
        public string universo
        {
            get
            {
                return _universo;
            }
        }
        public Utilizador(string Username, string Password, string Universo)
        {
            _userName = Username;
            _password = Password;
            _universo = Universo;
        }
    }
}
