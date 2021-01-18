using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1= new string[{"Ankara","Adana","Afyon"}]; //101 değeriyse
            string[] cities2 = new string[{ "Bursa", "Bolu", "Balıkesir" }]; //102 değeriyse
            cities2 = cities1; //102 değerini 101 değerine cevirtiyor
            cities1[0] = "Istanbul";
            Console.WriteLine(cities2[0]); //stringler referans tip oldukları için cities2 işlevsiz duruma düşüyor

            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;



            Console.ReadLine();
        }
    }
}
