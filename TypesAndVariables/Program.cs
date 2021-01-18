using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types Değer tipleri
            //Console.WriteLine("Hello World!");
            int number1 = 2147483647; //32 bit
            long number2 = 9223372036854775807; //kadar sayı tutar çok yer kaplar 64 bit
            short number3 = -32768; //kadar sayı tutar 16bit
            byte number4 = 255; //0 ve 255'e kadar veri tutar - tutmaz
            bool condition = true; // true veya false değer verir //condition = şart demek
            char character = 'A';
            string city = "Ankara";
            double number5 = 10.4; //ondalıklı sayılar pythonda float
            decimal number6 = 10.4m; //sonuna M harfi koydugunuzda ondalıklı yapabiliyoruz
            var number7 = 10; // number7 ye 10 degeri atayip onu da A harfi olarak değerlendiriyor
            number7 = 'A'; // int değer olduğu için a'nın değeri 65 oluyor

                       
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number1 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("condition is {0}", condition);
            Console.WriteLine("character is : {0}",(int)character); // A değerinin rakamsal karşılığı 65'dir.
            Console.WriteLine((int)Days.Friday); //index kodunu söylüyor
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine()
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday //başlangıç değerini veya diğer indexleri değiştirebiliyoruz
    }
}
