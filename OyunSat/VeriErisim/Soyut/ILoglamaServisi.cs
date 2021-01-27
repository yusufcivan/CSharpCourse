using OyunSat.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.VeriErisim.Soyut
{
    interface ILoglamaServisi
    {
        void Ekle(IVarlik varlik);
        void Guncelle(IVarlik varlik);
        void Sil(IVarlik varlik);
    }
}
