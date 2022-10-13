using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetterGetter
{
    class User
    {
        static void Main(string[] args)
        {
            user fatiha = new user();
            fatiha.Username = "Rahma2003";
            fatiha.Password = "NgopiYuk";

            Console.WriteLine("Username = " + fatiha.Username);
            Console.WriteLine("Password = " + fatiha.Password);

            Console.ReadKey();
        }
    }
    public class user
    {
        string username;
        string password;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }

}
