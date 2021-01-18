﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //var result = Add2(2, 20);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2); // ref'in alternatifi out tur out number1, number2 gibi değiştirilecek iç referansa da yazılması gerekir
            //// ref ile out arasındaki farkda ref'de number1'e illaki bir değer girmek gerekirken out'da boş bırakılabiliyor 
            //Console.WriteLine(result2);
            //Console.WriteLine(result);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(2,3,4,5,6,7));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30) // number2 verilmezse yerine 30 değerini kullan diyor 
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2) //ref number olarak gonderirsek içeride değişikliğe uğradığı için iki değer de değişir. ref olmazsa dışarıdaki değer değişmez
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

        
    }
}
