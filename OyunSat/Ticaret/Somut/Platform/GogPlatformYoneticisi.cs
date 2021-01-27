using OyunSat.Soyut;
using OyunSat.Ticaret.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Platform
{
    class GogPlatformYoneticisi : IPlatformServis
    {
        List<ISatisServisi> _satisServisleri;
        public GogPlatformYoneticisi(List<ISatisServisi> satisServisleri)
        {
            _satisServisleri = satisServisleri;
        }
        public void OyunSatinAl(IVarlik kisi, IVarlik oyun)
        {
            foreach (var satis in _satisServisleri)
            {
                satis.Indirim(oyun);
            }
            Console.WriteLine(kisi.Ad + " "+ oyun.Ad + "Oyunu Gog Games üzerinden satin aldi.");
        }

        public void GeriOdeme(IVarlik kisi, IVarlik oyun)
        {
            Console.WriteLine(kisi.Ad + " " + oyun.Ad + " Oyunu Gog Games üzerinden iade etti.");
        }
    }
}
