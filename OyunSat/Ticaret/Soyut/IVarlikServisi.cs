using OyunSat.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Soyut
{
    interface IVarlikServisi
    {
        void Ekle(IVarlik varlik);
        void Guncelle(IVarlik varlik);
        void Sil(IVarlik varlik);
    }
}
