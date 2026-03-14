using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Customer
    {
        public int Id;
        public string Name;
        public string Email;

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void GetInfo()
        {
            Console.WriteLine("Customer ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
        }
    }
}
