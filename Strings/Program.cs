using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Yusuf Civan"; // sentence türkçe anlamı cümle
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Merve Ortaç"; //senteces'in clonu olusturulduktan sonra clonu değişmez

            bool result3 = sentence.EndsWith("n"); //EndsWith bu cümle n harfiyle bitiyor mu sorusuna bool cevap verir true false olarak
            bool result4 = sentence.StartsWith("My name"); //StartsWith cümle My name ile başlıyor mu sorusuna true false cevap verir

            var result5 = sentence.IndexOf("name"); // sentence içerisinde name arar ve indexini verir bulamazsa -1 dondurur
            var result6 = sentence.IndexOf(" "); // bulduğu ilk boşluğun indexini verir ve durur
            var result7 = sentence.LastIndexOf(" "); //aramaya en sondan baslar. son boşluğa baktı
            var result8 = sentence.Insert(0, "Hello, "); //cümlenin 0. karakterinden sonra hello ekliyor instert ile
            var result9 = sentence.Substring(3,4); // parçalamaya yarar 3.indexden sonrakileri al dedi 3 indexden sonra 4 karakter al
            var result10 = sentence.ToLower(); // tüm karakterleri küçük harfe cevirir
            var result11 = sentence.ToUpper(); // tüm karakterleri büyük harfe cevirir
            var result12 = sentence.Replace(" ", "-"); //yerine karakter ekler bosluk yerine - ekledi
            var result13 = sentence.Remove(2,5); // belli bir indexden sonrasını atmak için kullanılır 2. indexden itibaren 5 karakteri kaldır


            Console.WriteLine(result2);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "istanbul";
            //string result = city + city2; // bunu yapmak yerine direk writeline içerisinen yazdırıyor

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
