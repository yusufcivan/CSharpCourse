using OyunSat.Soyut;
using OyunSat.VeriErisim.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.VeriErisim.Somut.Dosya
{
    class DosyaLoggerServisi : ILoglamaServisi
    {
        public void Ekle(IVarlik varlik)
        {
            Console.WriteLine(varlik.Ad + " Dosyaya eklendi");
        }

        public void Guncelle(IVarlik varlik)
        {
            Console.WriteLine(varlik.Ad + " Dosyayadan guncellendi.");

        }

        public void Sil(IVarlik varlik)
        {
            Console.WriteLine(varlik.Ad + " Dosyayadan silindi.");

        }
    }
}
