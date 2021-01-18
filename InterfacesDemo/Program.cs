using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work(); //tüm IWorkerlere çalış emri veriyor

            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();

                Console.ReadLine();
            }
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat Başlatıldı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager GetSalary Aktif edildi");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work Calisiyor");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat Başlatıldı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker GetSalary Başlatıldı");
        }

        public void Work()
        {
            Console.WriteLine("Worker Work Başlatıldı");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work Başlatıldı");
        }
    }

}