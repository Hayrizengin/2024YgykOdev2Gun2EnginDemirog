using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Hayri", LastName = "Zengin", City = "Giresun" };
            Customer customer2 = new Customer ( 2,"Erol","Zengin","Ankara");

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }

        
    }
    class Customer
    {
        //defaul constructor
        public Customer()
        {
            
        }
         
        //Metot parametreleri camelcase yazılır
        public Customer(int id,string firstName,string lastName,string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
