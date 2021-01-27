using OyunSat.Soyut;
using OyunSat.Ticaret.Soyut;
using OyunSat.VeriErisim.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Somut
{
    class OyunYoneticisi : IVarlikServisi
    {
        List<ILoglamaServisi> _loglamaServisleri;
        public OyunYoneticisi(List<ILoglamaServisi> loglamaServisleri)
        {
            _loglamaServisleri = loglamaServisleri;
        }
        public void Ekle(IVarlik oyun)
        {
            foreach (var logger in _loglamaServisleri)
            {
                logger.Ekle(oyun);
            }
        }

        public void Guncelle(IVarlik oyun)
        {
            foreach (var logger in _loglamaServisleri)
            {
                logger.Guncelle(oyun);
            }
        }

        public void Sil(IVarlik oyun)
        {
            foreach (var logger in _loglamaServisleri)
            {
                logger.Sil(oyun);
            }
        }
    }
}
