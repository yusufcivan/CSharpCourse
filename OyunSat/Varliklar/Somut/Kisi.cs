using OyunSat.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Somut
{
    class Kisi : IVarlik
    {
        public string TcKimlikNu { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public  int DogumTarihi { get; set; }
    }
}
