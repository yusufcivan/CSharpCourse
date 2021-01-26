using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","Izmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Yusuf"}, new Customer{FirstName = "Merve"}, new Customer{FirstName = "Meryem"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();

        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }






        class Product : IEntity
        {
            
        }

        interface IProductDal:IRepository<Product>
        {
            List<Product> GetALl();
            Product Get(int id);
            void Add(Product product);
            void Delete(Product product);
            void Update(Product product);

        }

        class Customer: IEntity
        {
            public string FirstName { get; set; }
        }

        interface ICustomerDal:IRepository<Customer>
        {


        }

        interface IStudentDal: IRepository<Student>
        {
            
        }

        class Student:IEntity
        {
            
        }

        interface IEntity
        {
            
        }

        interface IRepository<T> where T:class,IEntity, new()
        {
            List<T> GetALl();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }

        class ProductDal : IProductDal
        {
            public void Add(Product product)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product product)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetALl()
            {
                throw new NotImplementedException();
            }

            public void Update(Product product)
            {
                throw new NotImplementedException();
            }
        }

        class CustormerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetALl()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
    }
}
