using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //List();
            //Dictionary kelime anlamı olarak sözlük demek/ anahtar hangi türde değeri hangi türde belirtiyoruz
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer","bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                //Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass")); //glass yoksa true false dondurmesi için containskey kullanıyor
            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Istanbul");

            //Console.WriteLine(cities.Contains("Ankara")); // contains şehirlerin içerisinde Ankara varsa true doner seklinde

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Yusuf" });
            //customers.Add(new Customer { Id = 2, FirstName = "Merve" });


            List<Customer> customers = new List<Customer> //yukarıdakinin alternatifi
            {
                new Customer {Id = 1, FirstName = "Yusuf"},
                new Customer {Id = 2, FirstName = "Merve"}
            };

            //var count = customers.Count; //customers içerisinde iki eleman oldugu için 2 rakamı döner
            var customer2 = new Customer
            {
                Id = 3, FirstName = "Salih"
            };

            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Ali"},
                new Customer {Id = 5, FirstName = "Ayşe"}
            });

            Console.WriteLine(customers.Contains(customer2));

            //customers.Clear();


            var index = customers.IndexOf(customer2); //customer2'nin ilk index'ini buluyor
            Console.WriteLine("Index : {0}", index);


            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2); //index aramaya sondan başlar
            Console.WriteLine("Index: {0}", index2);

            customers.Insert(0,
                customer2); // kaçıncı sıraya neyi eklemek istiyorsun (add sona ekler burada ıstedıgımıze ekliyoruz)

            customers.Remove(customer2); // bu sekilde kullanımda bulduğu ilk değeri siler//customer2 "salih"'den üç tane var

            customers.RemoveAll(c => c.FirstName == "Salih"); // Müşterilerden Adı Salih olanları sil demek.

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.Id);
            }

            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("Istanbul");
            cities.Add(1);
            cities.Add("A");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
