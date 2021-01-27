using OyunSat.Somut;
using OyunSat.Soyut;
using OyunSat.Ticaret.Somut.DogrulamaKurallari.Soyut;
using OyunSat.Ticaret.Soyut;
using OyunSat.VeriErisim.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Somut
{
    class KullaniciYoneticisi : IVarlikServisi
    {
        List<ILoglamaServisi> _loglamaServisleri;
        List<IDogrulamaServisi> _dogrulamaServisleri;
        public KullaniciYoneticisi(List<ILoglamaServisi> loglamaServisleri, List<IDogrulamaServisi> dogrulamaServisleri)
        {
            _loglamaServisleri = loglamaServisleri;
            _dogrulamaServisleri = dogrulamaServisleri;
        }
        public void Ekle(IVarlik kisi)
        {
            try
            {
                foreach (var dogrula in _dogrulamaServisleri)
                {
                    dogrula.Dogrula((Kisi)kisi);
                }
                foreach (var logger in _loglamaServisleri)
                {
                    logger.Ekle(kisi);
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        public void Guncelle(IVarlik kisi)
        {
            foreach (var logger in _loglamaServisleri)
            {
                logger.Guncelle(kisi);
            }
        }
    
    public void Sil(IVarlik kisi)
        {
            foreach (var logger in _loglamaServisleri)
            {
                logger.Sil(kisi);
            }
        }
    }
}
