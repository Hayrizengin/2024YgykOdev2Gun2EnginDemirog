using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////value types int,double,float,boolean
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayi 1:"+sayi1);


            //// reference types array,class,list
            //int[] sayilar1 = new int[] { 1, 2, 3, 4 };
            //int[] sayilar2 = new int[] { 10, 20, 30, 40 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar1[0] =" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Hayri";
            person2 = person1;
            person1.FirstName = "Erol";
            Console.WriteLine(person2.FirstName);
            

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = 12345678910;
            Employee employee= new Employee();
            employee.FirstName = "Veli";

            Person person3= customer;
            customer.FirstName = "Ahmet";


            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager= new PersonManager();
            personManager.Add(employee);

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // base class : Person
    class Customer:Person
    {
        public long CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
