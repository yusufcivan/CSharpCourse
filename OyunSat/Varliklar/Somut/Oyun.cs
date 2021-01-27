using OyunSat.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Somut
{
    class Oyun : IVarlik
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yayinci { get; set; }
        public double UrunFiyati { get; set; }
    }
}
