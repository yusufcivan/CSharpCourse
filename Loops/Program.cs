﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100; i++) // i++ i plus plus her dönüşte 1 arttır demek
            //i+=2 ise ikişer ikişer arttır demek. ya da i=i+2 ikişer arttırır.
            // for (int i = 100; i>= 100; i=i-2) //yüzden geriye doğru 

            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForEachLoop();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a Prime number");
            }
            else
            {
                Console.WriteLine("This is a not prime number");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number) //prime number asal sayı demek
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0) // sayının i bölümünden kalan sayı 0 sa
                {
                    result = false; //tam bölen bir sayı varsa resultu false yap
                    i = number;
                }
            }

            return result;
        } 

        private static void ForEachLoop()
        {
            string[] students = new string[3] {"Engin", "Derin", "Salih"};
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number); //while döngüsü şart sağlanana kadar döner durdurmak için şart belirtmemiz gerekir
                number--; // number--; sayıyı bir bir azalt demek
            }

            Console.WriteLine("Now Number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!");
        }
    }
}
