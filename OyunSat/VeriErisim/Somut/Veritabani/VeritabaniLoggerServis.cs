using OyunSat.Soyut;
using OyunSat.VeriErisim.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.VeriErisim.Somut.Veritabani
{
    class VeritabaniLoggerServis : ILoglamaServisi
    {
        public void Ekle(IVarlik varlik)
        {
            Console.WriteLine(varlik.Ad + " veritabanına eklendi.");
        }

        public void Guncelle(IVarlik varlik)
        {
            Console.WriteLine(varlik.Ad + " veritabanına guncelendi.");
        }

        public void Sil(IVarlik varlik)
        {
            Console.WriteLine(varlik.Ad + " veritabanına kaldirildi.");
        }
    }
}
