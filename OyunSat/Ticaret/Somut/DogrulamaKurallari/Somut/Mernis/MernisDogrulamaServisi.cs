using OyunSat.Somut;
using OyunSat.Ticaret.Somut.DogrulamaKurallari.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Somut.DogrulamaKurallari.Somut.Mernis
{
    class MernisDogrulamaServisi : IDogrulamaServisi
    {
        public void Dogrula(Kisi kisi)
        {
            if (kisi.Ad.Length>2 && kisi.Soyad.Length>2 && kisi.TcKimlikNu.Length==11 && kisi.DogumTarihi > 1900)
            {
                Console.WriteLine(kisi.Ad + " " + kisi.Soyad + " Mernis Dogrulamasından Geçti.");
            }
            else
            {
                throw new Exception(kisi.Ad + " " + kisi.Soyad + " Mernis Dogrulamasından Geçemedi.");
            }
        }
    }
}
