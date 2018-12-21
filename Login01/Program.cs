using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login01
{
    class Program
    {
        static void Main(string[] args)
        {         
            string username = "Usuario64";
            string password = "senha123";

            try
            {
                FazerLogin login = new FazerLogin(username, password);

                Console.WriteLine(login.Username);
                Console.WriteLine(login.Password);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            Console.ReadLine();
        }
    }
}
