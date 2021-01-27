using OyunSat.Soyut;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSat.Ticaret.Soyut
{
    interface IPlatformServis
    {
        void OyunSatinAl(IVarlik kisi, IVarlik oyun);
        void GeriOdeme(IVarlik kisi, IVarlik oyun);
    }
}
