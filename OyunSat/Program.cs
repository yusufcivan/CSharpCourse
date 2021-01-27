using OyunSat.Somut;
using OyunSat.Soyut;
using OyunSat.Ticaret.Platform;
using OyunSat.Ticaret.Satis;
using OyunSat.Ticaret.Somut;
using OyunSat.Ticaret.Somut.DogrulamaKurallari.Somut.Mernis;
using OyunSat.Ticaret.Somut.DogrulamaKurallari.Soyut;
using OyunSat.Ticaret.Soyut;
using OyunSat.VeriErisim.Somut.Dosya;
using OyunSat.VeriErisim.Somut.Veritabani;
using OyunSat.VeriErisim.Soyut;
using System;
using System.Collections.Generic;

namespace OyunSat
{
    class Program
    {
        static void Main(string[] args)
        {


            // Poyraz Aktas'ın github hesabındaki örnekten yararlanılmıştır. Kendisine Teşekkür ediyorum.
            // https://github.com/poyrazaktas


            ILoglamaServisi dosyaLoggerServisi = new DosyaLoggerServisi();
            ILoglamaServisi veritabaniLoggerServis = new VeritabaniLoggerServis();
            IDogrulamaServisi mernisDogrulamaServisi = new MernisDogrulamaServisi();

            IVarlikServisi kullaniciYoneticisi = new KullaniciYoneticisi(new List<ILoglamaServisi> { dosyaLoggerServisi, veritabaniLoggerServis }, 
                new List<IDogrulamaServisi> { mernisDogrulamaServisi });

            Kisi enginHoca = new Oyuncu() { TcKimlikNu = "12345678911", Ad = "Engin", Soyad = "Demiroğ", DogumTarihi = 1985, Balance = 4000 };
            Kisi poyraz = new Oyuncu() { TcKimlikNu = "12345678999", Ad = "Poyraz", Soyad = "Aktaş", DogumTarihi = 2000, Balance = 1500 };
            Kisi aybuke = new Oyuncu() { TcKimlikNu = "22345678999", Ad = "Aybüke", Soyad = "Yalçın", DogumTarihi = 2000, Balance = 4444 };
            Kisi yusuf = new Oyuncu() { TcKimlikNu = "22345238999", Ad = "Yusuf", Soyad = "Civan", DogumTarihi = 1990, Balance = 20 };

            kullaniciYoneticisi.Ekle(enginHoca);
            kullaniciYoneticisi.Ekle(poyraz);
            kullaniciYoneticisi.Ekle(aybuke);
            kullaniciYoneticisi.Ekle(yusuf);

            IVarlik mario = new Oyun() { Id = 1, Ad = "Mario", Yayinci = " Nintendo", UrunFiyati = 150 };
            IVarlik witcher = new Oyun() { Id = 2, Ad = "Witcher 3", Yayinci = "CD Projekt", UrunFiyati = 999 };
            IVarlik cyberpunk = new Oyun() { Id = 3, Ad = "Cyberpunk 2077", Yayinci = "CD Projekt", UrunFiyati = 10 };

            IVarlikServisi oyunYoneticisi = new OyunYoneticisi(new List<ILoglamaServisi> { dosyaLoggerServisi });
            oyunYoneticisi.Ekle(mario);
            oyunYoneticisi.Ekle(witcher);
            oyunYoneticisi.Ekle(cyberpunk);

            ISatisServisi yaz_indirimi = new YazIndirimleriSatisYoneticisi();
            ISatisServisi karaCuma_indirimi = new KaraCumaSatisYoneticisi();
            ISatisServisi yilbasi_indirimi = new YeniYilSatisYoneticisi();
            ISatisServisi haftasonu_indirimi = new HaftaSonuSatislariYoneticisi();

            IPlatformServis steam = new SteamPlatformYoneticisi(new List<ISatisServisi> { });
            IPlatformServis gog = new GogPlatformYoneticisi(new List<ISatisServisi> {karaCuma_indirimi,haftasonu_indirimi});

            steam.OyunSatinAl(poyraz, mario);
            gog.OyunSatinAl(enginHoca, cyberpunk);
            steam.GeriOdeme(poyraz, mario);
            gog.OyunSatinAl(yusuf, witcher); 








        }
    }
}
