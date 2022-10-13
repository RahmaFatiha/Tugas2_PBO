using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisSuper
{
    public class Person
    {
        protected string name = "Rahma Fatiha Tauhid";
        protected int age = 19;

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }
    class Employee : Person
    {
        public string salary = "Rp. 5.000.000";
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Salary: {0}", salary);
        }
    }
    class Student
    {
        private string username;
        private string password;

        public Student(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void printStudent()
        {
            Console.WriteLine("Username: {0}\nPassword: {1}", username, password);
        }
    }
    class TestClass
    {
        static void Main()
        {
            Console.WriteLine("Super/Base");
            Employee E = new Employee();
            E.GetInfo();
            Console.WriteLine("");
            Console.WriteLine("This");
            Student S = new Student("Rahma", "003");
            S.printStudent();
        }
    }
}
