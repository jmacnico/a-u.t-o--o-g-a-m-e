using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Utilizador
    {
        public string userName
        {
            get;
            private set;
        }
        public string password
        {
            get;
            private set;
        }
        public string universo
        {
            get;
            private set;
        }
        public string email { get; set; }
        public Utilizador(string Username, string Password, string Universo, string Email)
        {
            userName = Username;
            password = Password;
            universo = Universo;
            email = Email;
        }
    }
}
