using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer //Ctrl Space bastığımızda City, FirstName gibi bilgiler otomatik cıkıyor
            {
                Id = 2, City = "Istanbul", FirstName = "Derin", LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName); //customer2'nin firstname yazdırdı.

            Console.ReadLine();
        }
    }
    
}
