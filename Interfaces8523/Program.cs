using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Id = 1,
                FirstName = "Çağıl",
                LastName = "Alsaç"
            };
            Console.WriteLine("ID : " + person1.Id  + ", Adı : " + person1.FirstName + ", Soyadı : " + person1.LastName);

            IPerson person2 = new Person()
            {
                Id = 2,
                FirstName = "Leo",
                LastName = "Alsaç"
            };

            Console.WriteLine("ID : " + person2.Id + ", Adı : " + person2.FirstName + ", Soyadı : " + person2.LastName);

            Customer customer1 = new Customer()
            {
                Address = "Ankara",
                Id = 3,
                FirstName = "Yağız",
                LastName = "Yılmaz"
            };

            Customer customer2 = new Customer();
            customer2.FirstName = "Yahya";
            customer2.LastName = "Önder";
            customer2.Id = 4;
            customer2.Address = "New York";

            IPerson customer3 = new Customer();
            customer3.Id = 5;
            customer3.FirstName = "Melik";
            customer3.LastName = "Baykal";

            IPerson customer4 = new Customer()
            {
                Address = "İstanbul",
                FirstName = "Simge",
                LastName = "Işık",
                Id = 6
            };

            //Customer customer44 = (Customer)customer4;
            Customer customer44 = customer4 as Customer;
            Console.WriteLine($"ID : {customer44.Id} ,Adı : {customer44.FirstName}, Soyadı : {customer44.LastName}, Adres : {customer44.Address}");

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }

        string LastName { get; set; }
    }

    class Person : IPerson // class : somut, concrete
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }
}
