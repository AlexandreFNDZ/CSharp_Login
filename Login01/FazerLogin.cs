using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login01
{
    public class FazerLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public FazerLogin(string username, string password)
        {
            Username = "Usuario64";
            Password = "senha123";

            if (Username != username || Password != password)
            {
                throw new ArgumentException("Usuário e/ou Senha inválidos! Confira os dados digitados");
            }          
        }     
    }
}
