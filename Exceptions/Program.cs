using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundExpection expection)
            {
                Console.WriteLine(expection.Message);
            }

            //Method
            HandleExpection(() =>
            {
                Find();
            });


            Console.ReadLine();
        }

        private static void HandleExpection(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> {"Yusuf", "Merve", "Meryem"};

            if (!students.Contains("Ahmet")) //eğer öğrencilerin içerisinde ahmet varsa ! ünlem ise yoksa anlamına gelir
            {
                throw new RecordNotFoundExpection("Record not Found!");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] {"Engin", "Derin", "Salih"};
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
