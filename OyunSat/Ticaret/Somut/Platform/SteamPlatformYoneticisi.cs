using OyunSat.Soyut;
using OyunSat.Ticaret.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Platform
{
    class SteamPlatformYoneticisi : IPlatformServis
    {
        List<ISatisServisi> _satisServisleri;
        public SteamPlatformYoneticisi(List<ISatisServisi> satisServisleri)
        {
            _satisServisleri = satisServisleri;
        }
        public void OyunSatinAl(IVarlik kisi, IVarlik oyun)
        {
            foreach (var satis in _satisServisleri)
            {
                satis.Indirim(oyun);
            }
            Console.WriteLine(kisi.Ad + " " + oyun.Ad + "Oyununu Steam'den Satin Aldı.");
        }

        public void GeriOdeme(IVarlik kisi, IVarlik oyun)
        {
            Console.WriteLine(kisi.Ad + " " + oyun.Ad + " Oyununu Steam'e iade etti");
        }
    }
}
