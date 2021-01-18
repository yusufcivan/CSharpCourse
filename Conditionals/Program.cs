using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alternatif if methodu
            //var number = 11;
            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            //Console.ReadLine();
            var number = 11;
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");

            //}

            // if alternatifi
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            //Bir sayının 100'lük dilimlerde nereye geldiğini bulmaya calısacagız

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100"); //0 - 100 aralığındadır
            //}
            //else if (number > 100 && number <= 200) // sayı 100'den büyük 200 veya altı ise && and anlamında
            //{
            //    Console.WriteLine("Number is between 101-200"); //101- 200 aralığındadır
            //}
            //else if (number > 200 || number < 0) // || yada demek 200'den büyükse ya da 0 dan küçükse
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}

            if (number < 100)
            {
                if (number >= 90 && number<95)
                {

                }
            }

            Console.ReadLine(); //uygulama kapanmasın diye readline bırakıyor

        }
    }
}
