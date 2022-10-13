using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructor
{
    //konstruktor
    public class Program
    {
        public class UserKonstruktor
        {
            public string username;
            public string password;

            public UserKonstruktor(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

        }
        public class UserDestruktor
        {
            public UserDestruktor()
            {
                Console.WriteLine("Instance Class Sudah Dibuat");
            }
            // Destructor
            ~UserDestruktor()
            {
                Console.WriteLine("Instance Class Sudah di Destroy");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Konstruktor");
            UserKonstruktor web = new UserKonstruktor("wikipedia", "hello");
            Console.WriteLine("Usernaem: " + web.username);
            Console.WriteLine("Password: " + web.password);
            Console.WriteLine(" ");
            Console.WriteLine("Destruktor");
            Run();
            GC.Collect();
        }
        public static void Run()
        {
            // Membuat Instance Class
            UserDestruktor userdestruktor = new UserDestruktor();
        }
    }
}
