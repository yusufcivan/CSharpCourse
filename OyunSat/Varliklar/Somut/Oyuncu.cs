using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Somut
{
    class Oyuncu : Kisi
    {
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        public  double Balance { get; set; }
    }
}
