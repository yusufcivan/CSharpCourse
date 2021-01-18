using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product {Id = 1, Name = "Laptop"};
            Product product2 = new Product(2,"Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger()); //filelogger ve databaselogger kullanılabiliyor


            //employeeManager.Logger = new DatabaseLogger(); 
            
            //employeeManager.Logger = new FileLogger(); // ctor yapıldıgı için ihtiyaç kalmadı

            //employeeManager.Logger = new DatabaseLogger(); // ctor yapıldığı için ihtiyaç kalmadı

            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10; // static oldugu için bu sekilde cagriliyor

            Utilities.Validate();

            Manager.DoSomething();// static oldugu için direk bu sekilde cagrılıyor


            Manager manager = new Manager(); //static olmadığı için isntance üzerinden cagrılıyor
            manager.DoSomethin2();

            Console.ReadLine();


        }
    }

    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }
        public void List()
        {
            Console.WriteLine("Listed! {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {
            
        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void log();
    }

    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity; //entity varlık demek

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            //mutlaka calısmasını istedigimiz kod blogu varsa onu koyuyoruz
        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("done");
        }

        public void DoSomethin2()
        {
            Console.WriteLine("done2");
        }
    }
}
