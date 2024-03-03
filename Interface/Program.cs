using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        //İnterface new'lenemez
        static void Main(string[] args)
        {
            //İnterfaceler impleme edildikleri sınıfın refarans numaralarını tutabilirler
            IPersonManager customerManager=new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }
    // inherits-class ----------- implements-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");

        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");

        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
            
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
