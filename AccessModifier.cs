using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class PublicPerson
    {
        public string name = "Rahma";
    }
    class ProtectedPerson
    {
        protected string name = "Fatiha";
    }
    class Program : ProtectedPerson
    {
        class PrivatePerson
        {
            private string name = "Tauchid";
            static void Main(String[] args)
            {
                Console.WriteLine("Access Modifier Public");
                PublicPerson person = new PublicPerson();
                Console.WriteLine(person.name);
                Console.WriteLine("");
                Console.WriteLine("Access Modifier Protected");
                Program program = new Program();
                Console.WriteLine(program.name);
                Console.WriteLine("");
                Console.WriteLine("Access Modifier Private");
                PrivatePerson privatePerson = new PrivatePerson();
                Console.WriteLine(privatePerson.name);
            }
        }
    }
}
