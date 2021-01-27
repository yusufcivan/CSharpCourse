using OyunSat.Soyut;
using OyunSat.Ticaret.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Satis
{
    class YeniYilSatisYoneticisi : ISatisServisi
    {
        public void Indirim(IVarlik oyun)
        {
            Console.WriteLine(oyun.Ad + " oyununa yeni yil indirimi yapildi.");
        }
    }
}
